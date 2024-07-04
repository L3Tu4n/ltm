﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class ClientInfo
{
    public string Name { get; set; }
    public string Image { get; set; }
}

public class Room
{
    public string RoomId { get; set; }
    public List<(TcpClient client, ClientInfo info)> Clients { get; set; }

    public Room(string roomId)
    {
        RoomId = roomId;
        Clients = new List<(TcpClient client, ClientInfo info)>();
    }
}

public class KaraokeServer
{
    private TcpListener server;
    private bool isRunning;
    private Dictionary<string, Room> rooms;
    private Random random;
    private object lockObj = new object();

    public KaraokeServer()
    {
        server = new TcpListener(IPAddress.Any, 8888);
        server.Start();
        isRunning = true;
        rooms = new Dictionary<string, Room>();
        random = new Random();
        Listen();
    }

    private void Listen()
    {
        Console.WriteLine("Server started, waiting for connections...");
        while (isRunning)
        {
            try
            {
                // Accept incoming connection requests and handle them in separate threads
                TcpClient newClient = server.AcceptTcpClient();
                Console.WriteLine("New client connected.");
                Thread t = new Thread(new ParameterizedThreadStart(HandleClient));
                t.Start(newClient);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error accepting client connection: {ex.Message}");
            }
        }
    }

    private void HandleClient(object obj)
    {
        TcpClient client = (TcpClient)obj;
        NetworkStream stream = client.GetStream();
        byte[] buffer = new byte[1024];

        try
        {
            while (true)
            {
                int byteCount = stream.Read(buffer, 0, buffer.Length);
                if (byteCount == 0)
                {
                    // Client disconnected
                    break;
                }

                string message = Encoding.ASCII.GetString(buffer, 0, byteCount);
                Console.WriteLine(message);
                ProcessMessage(client, message);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error handling client: {ex.Message}");
        }
        finally
        {
            lock (lockObj)
            {
                client.Close();
                Console.WriteLine("Client disconnected.");
            }
        }
    }

    private void ProcessMessage(TcpClient client, string message)
    {
        NetworkStream stream = client.GetStream();

        if (message.StartsWith("CREATE_ROOM"))
        {
            var jsonData = message.Substring("CREATE_ROOM ".Length);
            if (JsonConvert.DeserializeObject(jsonData) is JObject clientData)
            {
                string roomId = GenerateRoomId();
                Room newRoom = new Room(roomId);

                ClientInfo newClientInfo = new ClientInfo
                {
                    Name = clientData["name"].ToString(),
                    Image = clientData["image"].ToString()
                };

                lock (lockObj)
                {
                    newRoom.Clients.Add((client, newClientInfo));
                    rooms.Add(roomId, newRoom);
                    Console.WriteLine($"Room {roomId} created.");

                    string successMessage = $"CREATE_ROOM_SUCCESS {roomId}";
                    byte[] successMessageBytes = Encoding.ASCII.GetBytes(successMessage);
                    stream.Write(successMessageBytes, 0, successMessageBytes.Length);
                }

                SendNewClientInfo(roomId, clientData["name"].ToString(), clientData["image"].ToString(), client);
            }
            else
            {
                Console.WriteLine("Invalid JSON format for CREATE_ROOM");
            }
        }
        else if (message.StartsWith("JOIN_ROOM"))
        {
            var jsonData = message.Substring("JOIN_ROOM ".Length);
            if (JsonConvert.DeserializeObject(jsonData) is JObject clientData)
            {
                string roomId = clientData["roomId"].ToString();
                if (rooms.ContainsKey(roomId))
                {
                    ClientInfo newClientInfo = new ClientInfo
                    {
                        Name = clientData["name"].ToString(),
                        Image = clientData["image"].ToString()
                    };

                    lock (lockObj)
                    {
                        rooms[roomId].Clients.Add((client, newClientInfo));
                        Console.WriteLine($"Client joined room {roomId}");

                        string successMessage = $"JOIN_ROOM_SUCCESS {roomId}";
                        byte[] successMessageBytes = Encoding.ASCII.GetBytes(successMessage);
                        stream.Write(successMessageBytes, 0, successMessageBytes.Length);
                    }

                    SendNewClientInfo(roomId, clientData["name"].ToString(), clientData["image"].ToString(),client);
                    SendExistingClientsInfo(roomId, client);
                }
                else
                {
                    Console.WriteLine($"Room {roomId} not found");
                }
            }
            else
            {
                Console.WriteLine("Invalid JSON format for JOIN_ROOM");
            }
        }
        else if (message.StartsWith("GET_CLIENTS_INFO"))
        {
            string roomId = message.Substring("GET_CLIENTS_INFO ".Length);
            if (rooms.ContainsKey(roomId))
            {
                SendExistingClientsInfo(roomId, client);
            }
            else
            {
                Console.WriteLine($"Room {roomId} not found");
            }
        }
        else
        {
            Console.WriteLine($"Unknown command: {message}");
        }
    }

    private void SendNewClientInfo(string roomId, string newClientName, string newClientImage, TcpClient newClient)
    {
        Room room = rooms[roomId];
        lock (lockObj)
        {
            foreach ((TcpClient client, ClientInfo info) in room.Clients)
            {
                NetworkStream stream = client.GetStream();

                var data = new
                {
                    type = "NEW_CLIENT_JOIN",
                    name = newClientName,
                    image = newClientImage
                };

                string jsonData = JsonConvert.SerializeObject(data);
                byte[] jsonDataBytes = Encoding.ASCII.GetBytes(jsonData);

                stream.Write(jsonDataBytes, 0, jsonDataBytes.Length);
            }
        }
    }

    private void SendExistingClientsInfo(string roomId, TcpClient newClient)
    {
        Room room = rooms[roomId];
        lock (lockObj)
        {
            foreach ((TcpClient client, ClientInfo info) in room.Clients)
            {
                if (client != newClient) // Bỏ qua newClient
                {
                    NetworkStream stream = newClient.GetStream();

                    var data = new
                    {
                        type = "EXISTING_CLIENT_INFO",
                        name = info.Name,
                        image = info.Image
                    };

                    string jsonData = JsonConvert.SerializeObject(data);
                    byte[] jsonDataBytes = Encoding.ASCII.GetBytes(jsonData);

                    stream.Write(jsonDataBytes, 0, jsonDataBytes.Length);
                }
            }
        }
    }

    private string GenerateRoomId()
    {
        string roomId;
        lock (lockObj)
        {
            do
            {
                roomId = random.Next(100000, 999999).ToString();
            } while (rooms.ContainsKey(roomId));
        }
        return roomId;
    }

    public static void Main()
    {
        new KaraokeServer();
    }
}