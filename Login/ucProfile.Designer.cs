﻿using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    partial class ucProfile
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProfile));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.btnEdit = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSaveChanges = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtPhone = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtEmail = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnEditPhoto = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtName = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.ActiveImage = null;
            this.btnEdit.AllowAnimations = true;
            this.btnEdit.AllowBuffering = false;
            this.btnEdit.AllowToggling = false;
            this.btnEdit.AllowZooming = true;
            this.btnEdit.AllowZoomingOnFocus = false;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEdit.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.ErrorImage")));
            this.btnEdit.FadeWhenInactive = false;
            this.btnEdit.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnEdit.Image = global::Login.Properties.Resources.icons8_edit_150;
            this.btnEdit.ImageActive = null;
            this.btnEdit.ImageLocation = null;
            this.btnEdit.ImageMargin = 20;
            this.btnEdit.ImageSize = new System.Drawing.Size(29, 21);
            this.btnEdit.ImageZoomSize = new System.Drawing.Size(49, 41);
            this.btnEdit.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.InitialImage")));
            this.btnEdit.Location = new System.Drawing.Point(956, 517);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Rotation = 0;
            this.btnEdit.ShowActiveImage = true;
            this.btnEdit.ShowCursorChanges = true;
            this.btnEdit.ShowImageBorders = true;
            this.btnEdit.ShowSizeMarkers = false;
            this.btnEdit.Size = new System.Drawing.Size(49, 41);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.ToolTipText = "";
            this.btnEdit.WaitOnLoad = false;
            this.btnEdit.Zoom = 20;
            this.btnEdit.ZoomSpeed = 10;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(86, 257);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 191);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.AllowAnimations = true;
            this.btnSaveChanges.AllowMouseEffects = true;
            this.btnSaveChanges.AllowToggling = false;
            this.btnSaveChanges.AnimationSpeed = 200;
            this.btnSaveChanges.AutoGenerateColors = false;
            this.btnSaveChanges.AutoRoundBorders = false;
            this.btnSaveChanges.AutoSizeLeftIcon = true;
            this.btnSaveChanges.AutoSizeRightIcon = true;
            this.btnSaveChanges.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveChanges.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSaveChanges.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveChanges.BackgroundImage")));
            this.btnSaveChanges.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveChanges.ButtonText = "Save Changes";
            this.btnSaveChanges.ButtonTextMarginLeft = 0;
            this.btnSaveChanges.ColorContrastOnClick = 45;
            this.btnSaveChanges.ColorContrastOnHover = 45;
            this.btnSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSaveChanges.CustomizableEdges = borderEdges1;
            this.btnSaveChanges.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveChanges.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSaveChanges.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnSaveChanges.DisabledForecolor = System.Drawing.Color.White;
            this.btnSaveChanges.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.IconLeft = null;
            this.btnSaveChanges.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveChanges.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveChanges.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSaveChanges.IconMarginLeft = 11;
            this.btnSaveChanges.IconPadding = 10;
            this.btnSaveChanges.IconRight = null;
            this.btnSaveChanges.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveChanges.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveChanges.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSaveChanges.IconSize = 25;
            this.btnSaveChanges.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btnSaveChanges.IdleBorderRadius = 35;
            this.btnSaveChanges.IdleBorderThickness = 2;
            this.btnSaveChanges.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.btnSaveChanges.IdleIconLeftImage = null;
            this.btnSaveChanges.IdleIconRightImage = null;
            this.btnSaveChanges.IndicateFocus = false;
            this.btnSaveChanges.Location = new System.Drawing.Point(659, 608);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSaveChanges.OnDisabledState.BorderRadius = 1;
            this.btnSaveChanges.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveChanges.OnDisabledState.BorderThickness = 1;
            this.btnSaveChanges.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSaveChanges.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSaveChanges.OnDisabledState.IconLeftImage = null;
            this.btnSaveChanges.OnDisabledState.IconRightImage = null;
            this.btnSaveChanges.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSaveChanges.onHoverState.BorderRadius = 1;
            this.btnSaveChanges.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveChanges.onHoverState.BorderThickness = 1;
            this.btnSaveChanges.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSaveChanges.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.onHoverState.IconLeftImage = null;
            this.btnSaveChanges.onHoverState.IconRightImage = null;
            this.btnSaveChanges.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveChanges.OnIdleState.BorderRadius = 1;
            this.btnSaveChanges.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveChanges.OnIdleState.BorderThickness = 1;
            this.btnSaveChanges.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveChanges.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.OnIdleState.IconLeftImage = null;
            this.btnSaveChanges.OnIdleState.IconRightImage = null;
            this.btnSaveChanges.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSaveChanges.OnPressedState.BorderRadius = 1;
            this.btnSaveChanges.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveChanges.OnPressedState.BorderThickness = 1;
            this.btnSaveChanges.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSaveChanges.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.OnPressedState.IconLeftImage = null;
            this.btnSaveChanges.OnPressedState.IconRightImage = null;
            this.btnSaveChanges.Size = new System.Drawing.Size(178, 60);
            this.btnSaveChanges.TabIndex = 15;
            this.btnSaveChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveChanges.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveChanges.TextMarginLeft = 0;
            this.btnSaveChanges.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSaveChanges.UseDefaultRadiusAndThickness = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = false;
            this.txtPassword.AcceptsTab = false;
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.AnimationSpeed = 200;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.AutoSizeHeight = true;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.BackgroundImage")));
            this.txtPassword.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.txtPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(206)))), ((int)(((byte)(15)))));
            this.txtPassword.BorderRadius = 30;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HideSelection = true;
            this.txtPassword.IconLeft = global::Login.Properties.Resources.icons8_password_120;
            this.txtPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.IconPadding = 10;
            this.txtPassword.IconRight = null;
            this.txtPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(497, 504);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MaximumSize = new System.Drawing.Size(533, 123);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MinimumSize = new System.Drawing.Size(133, 43);
            this.txtPassword.Modified = false;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(206)))), ((int)(((byte)(15)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnIdleState = stateProperties4;
            this.txtPassword.Padding = new System.Windows.Forms.Padding(4);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(533, 72);
            this.txtPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPassword.TabIndex = 13;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMarginBottom = 0;
            this.txtPassword.TextMarginLeft = 5;
            this.txtPassword.TextMarginTop = 1;
            this.txtPassword.TextPlaceholder = "Password";
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.WordWrap = true;
            // 
            // txtPhone
            // 
            this.txtPhone.AcceptsReturn = false;
            this.txtPhone.AcceptsTab = false;
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.AnimationSpeed = 200;
            this.txtPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPhone.AutoSizeHeight = true;
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPhone.BackgroundImage")));
            this.txtPhone.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.txtPhone.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtPhone.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtPhone.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(230)))), ((int)(((byte)(126)))));
            this.txtPhone.BorderRadius = 30;
            this.txtPhone.BorderThickness = 2;
            this.txtPhone.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtPhone.DefaultText = "";
            this.txtPhone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.HideSelection = true;
            this.txtPhone.IconLeft = global::Login.Properties.Resources.icons8_phone_100;
            this.txtPhone.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.IconPadding = 10;
            this.txtPhone.IconRight = null;
            this.txtPhone.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(497, 409);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.MaximumSize = new System.Drawing.Size(533, 123);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.MinimumSize = new System.Drawing.Size(133, 43);
            this.txtPhone.Modified = false;
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPhone.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPhone.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPhone.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(230)))), ((int)(((byte)(126)))));
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            stateProperties8.ForeColor = System.Drawing.Color.White;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPhone.OnIdleState = stateProperties8;
            this.txtPhone.Padding = new System.Windows.Forms.Padding(4);
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPhone.PlaceholderText = "Phone";
            this.txtPhone.ReadOnly = false;
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(533, 72);
            this.txtPhone.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPhone.TabIndex = 11;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhone.TextMarginBottom = 0;
            this.txtPhone.TextMarginLeft = 5;
            this.txtPhone.TextMarginTop = 1;
            this.txtPhone.TextPlaceholder = "Phone";
            this.txtPhone.UseSystemPasswordChar = false;
            this.txtPhone.WordWrap = true;
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptsReturn = false;
            this.txtEmail.AcceptsTab = false;
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.AnimationSpeed = 200;
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmail.AutoSizeHeight = true;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtEmail.BackgroundImage")));
            this.txtEmail.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.txtEmail.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtEmail.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(230)))), ((int)(((byte)(126)))));
            this.txtEmail.BorderRadius = 30;
            this.txtEmail.BorderThickness = 2;
            this.txtEmail.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtEmail.DefaultText = "";
            this.txtEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.HideSelection = true;
            this.txtEmail.IconLeft = global::Login.Properties.Resources.envelope1;
            this.txtEmail.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.IconPadding = 10;
            this.txtEmail.IconRight = null;
            this.txtEmail.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(497, 319);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaximumSize = new System.Drawing.Size(533, 123);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MinimumSize = new System.Drawing.Size(133, 43);
            this.txtEmail.Modified = false;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmail.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtEmail.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmail.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(230)))), ((int)(((byte)(126)))));
            stateProperties12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            stateProperties12.ForeColor = System.Drawing.Color.White;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmail.OnIdleState = stateProperties12;
            this.txtEmail.Padding = new System.Windows.Forms.Padding(4);
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(533, 72);
            this.txtEmail.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtEmail.TabIndex = 10;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TextMarginBottom = 0;
            this.txtEmail.TextMarginLeft = 5;
            this.txtEmail.TextMarginTop = 1;
            this.txtEmail.TextPlaceholder = "Email";
            this.txtEmail.UseSystemPasswordChar = false;
            this.txtEmail.WordWrap = true;
            // 
            // btnEditPhoto
            // 
            this.btnEditPhoto.AllowAnimations = true;
            this.btnEditPhoto.AllowMouseEffects = true;
            this.btnEditPhoto.AllowToggling = false;
            this.btnEditPhoto.AnimationSpeed = 200;
            this.btnEditPhoto.AutoGenerateColors = false;
            this.btnEditPhoto.AutoRoundBorders = false;
            this.btnEditPhoto.AutoSizeLeftIcon = true;
            this.btnEditPhoto.AutoSizeRightIcon = true;
            this.btnEditPhoto.BackColor = System.Drawing.Color.Transparent;
            this.btnEditPhoto.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnEditPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditPhoto.BackgroundImage")));
            this.btnEditPhoto.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEditPhoto.ButtonText = "Change Avatar";
            this.btnEditPhoto.ButtonTextMarginLeft = 0;
            this.btnEditPhoto.ColorContrastOnClick = 45;
            this.btnEditPhoto.ColorContrastOnHover = 45;
            this.btnEditPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnEditPhoto.CustomizableEdges = borderEdges2;
            this.btnEditPhoto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditPhoto.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnEditPhoto.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnEditPhoto.DisabledForecolor = System.Drawing.Color.White;
            this.btnEditPhoto.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnEditPhoto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditPhoto.ForeColor = System.Drawing.Color.White;
            this.btnEditPhoto.IconLeft = null;
            this.btnEditPhoto.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditPhoto.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEditPhoto.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnEditPhoto.IconMarginLeft = 11;
            this.btnEditPhoto.IconPadding = 10;
            this.btnEditPhoto.IconRight = null;
            this.btnEditPhoto.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditPhoto.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEditPhoto.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEditPhoto.IconSize = 25;
            this.btnEditPhoto.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btnEditPhoto.IdleBorderRadius = 35;
            this.btnEditPhoto.IdleBorderThickness = 2;
            this.btnEditPhoto.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.btnEditPhoto.IdleIconLeftImage = null;
            this.btnEditPhoto.IdleIconRightImage = null;
            this.btnEditPhoto.IndicateFocus = false;
            this.btnEditPhoto.Location = new System.Drawing.Point(68, 504);
            this.btnEditPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditPhoto.Name = "btnEditPhoto";
            this.btnEditPhoto.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnEditPhoto.OnDisabledState.BorderRadius = 1;
            this.btnEditPhoto.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEditPhoto.OnDisabledState.BorderThickness = 1;
            this.btnEditPhoto.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEditPhoto.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEditPhoto.OnDisabledState.IconLeftImage = null;
            this.btnEditPhoto.OnDisabledState.IconRightImage = null;
            this.btnEditPhoto.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnEditPhoto.onHoverState.BorderRadius = 1;
            this.btnEditPhoto.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEditPhoto.onHoverState.BorderThickness = 1;
            this.btnEditPhoto.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnEditPhoto.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnEditPhoto.onHoverState.IconLeftImage = null;
            this.btnEditPhoto.onHoverState.IconRightImage = null;
            this.btnEditPhoto.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnEditPhoto.OnIdleState.BorderRadius = 1;
            this.btnEditPhoto.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEditPhoto.OnIdleState.BorderThickness = 1;
            this.btnEditPhoto.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnEditPhoto.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnEditPhoto.OnIdleState.IconLeftImage = null;
            this.btnEditPhoto.OnIdleState.IconRightImage = null;
            this.btnEditPhoto.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEditPhoto.OnPressedState.BorderRadius = 1;
            this.btnEditPhoto.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEditPhoto.OnPressedState.BorderThickness = 1;
            this.btnEditPhoto.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEditPhoto.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnEditPhoto.OnPressedState.IconLeftImage = null;
            this.btnEditPhoto.OnPressedState.IconRightImage = null;
            this.btnEditPhoto.Size = new System.Drawing.Size(265, 54);
            this.btnEditPhoto.TabIndex = 9;
            this.btnEditPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditPhoto.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditPhoto.TextMarginLeft = 0;
            this.btnEditPhoto.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEditPhoto.UseDefaultRadiusAndThickness = true;
            this.btnEditPhoto.Click += new System.EventHandler(this.btnEditPhoto_Click);
            // 
            // txtName
            // 
            this.txtName.AcceptsReturn = false;
            this.txtName.AcceptsTab = false;
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.AnimationSpeed = 200;
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtName.AutoSizeHeight = true;
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.txtName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtName.BackgroundImage")));
            this.txtName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(230)))), ((int)(((byte)(126)))));
            this.txtName.BorderRadius = 30;
            this.txtName.BorderThickness = 2;
            this.txtName.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtName.DefaultText = "";
            this.txtName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.HideSelection = true;
            this.txtName.IconLeft = global::Login.Properties.Resources.icons8_user_96;
            this.txtName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.IconPadding = 10;
            this.txtName.IconRight = null;
            this.txtName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(497, 226);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MaximumSize = new System.Drawing.Size(533, 123);
            this.txtName.MaxLength = 32767;
            this.txtName.MinimumSize = new System.Drawing.Size(133, 43);
            this.txtName.Modified = false;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            stateProperties13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtName.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtName.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtName.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(230)))), ((int)(((byte)(126)))));
            stateProperties16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            stateProperties16.ForeColor = System.Drawing.Color.White;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtName.OnIdleState = stateProperties16;
            this.txtName.Padding = new System.Windows.Forms.Padding(4);
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtName.PlaceholderText = "Name";
            this.txtName.ReadOnly = false;
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(533, 72);
            this.txtName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtName.TabIndex = 7;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.TextMarginBottom = 0;
            this.txtName.TextMarginLeft = 5;
            this.txtName.TextMarginTop = 1;
            this.txtName.TextPlaceholder = "Name";
            this.txtName.UseSystemPasswordChar = false;
            this.txtName.WordWrap = true;
            // 
            // ucProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnEditPhoto);
            this.Controls.Add(this.txtName);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucProfile";
            this.Size = new System.Drawing.Size(1058, 961);
            this.Load += new System.EventHandler(this.ucProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuTextBox txtName;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEditPhoto;
        private Bunifu.UI.WinForms.BunifuTextBox txtEmail;
        private Bunifu.UI.WinForms.BunifuTextBox txtPhone;
        private Bunifu.UI.WinForms.BunifuTextBox txtPassword;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSaveChanges;
        private PictureBox pictureBox2;
        private Bunifu.UI.WinForms.BunifuImageButton btnEdit;
    }
}
