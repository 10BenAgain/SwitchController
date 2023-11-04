namespace SwitchController
{
    partial class Controller
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CAPUTREButton = new Button();
            HOMEButton = new Button();
            DLEFTButton = new Button();
            DRIGHTButton = new Button();
            DUPButton = new Button();
            DDOWNButton = new Button();
            DPADGroupBox = new GroupBox();
            groupBox1 = new GroupBox();
            XButton = new Button();
            BButton = new Button();
            YButton = new Button();
            AButton = new Button();
            PLUSBUtton = new Button();
            MINUSButton = new Button();
            LButton = new Button();
            RButton = new Button();
            IPAddress = new TextBox();
            Connect = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            IsConnectedTextBox = new TextBox();
            DPADGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // CAPUTREButton
            // 
            CAPUTREButton.Location = new Point(7, 17);
            CAPUTREButton.Name = "CAPUTREButton";
            CAPUTREButton.Size = new Size(52, 27);
            CAPUTREButton.TabIndex = 0;
            CAPUTREButton.Text = "SC";
            CAPUTREButton.UseVisualStyleBackColor = true;
            CAPUTREButton.Click += CAPUTREButton_Click;
            // 
            // HOMEButton
            // 
            HOMEButton.Location = new Point(7, 50);
            HOMEButton.Name = "HOMEButton";
            HOMEButton.Size = new Size(52, 27);
            HOMEButton.TabIndex = 1;
            HOMEButton.Text = "H";
            HOMEButton.UseVisualStyleBackColor = true;
            HOMEButton.Click += HOMEButton_Click;
            // 
            // DLEFTButton
            // 
            DLEFTButton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DLEFTButton.Location = new Point(6, 45);
            DLEFTButton.Name = "DLEFTButton";
            DLEFTButton.Size = new Size(26, 26);
            DLEFTButton.TabIndex = 2;
            DLEFTButton.Text = "⟵";
            DLEFTButton.UseVisualStyleBackColor = true;
            DLEFTButton.Click += DLEFTButton_Click;
            DLEFTButton.MouseDown += DLEFTButton_MouseDown;
            DLEFTButton.MouseUp += DLEFTButton_MouseUp;
            // 
            // DRIGHTButton
            // 
            DRIGHTButton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DRIGHTButton.Location = new Point(55, 45);
            DRIGHTButton.Name = "DRIGHTButton";
            DRIGHTButton.Size = new Size(26, 26);
            DRIGHTButton.TabIndex = 3;
            DRIGHTButton.Text = "⟶";
            DRIGHTButton.UseVisualStyleBackColor = true;
            DRIGHTButton.Click += DRIGHTButton_Click;
            DRIGHTButton.MouseDown += DRIGHTButton_MouseDown;
            DRIGHTButton.MouseUp += DRIGHTButton_MouseUp;
            // 
            // DUPButton
            // 
            DUPButton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DUPButton.Location = new Point(31, 20);
            DUPButton.Name = "DUPButton";
            DUPButton.Size = new Size(26, 26);
            DUPButton.TabIndex = 4;
            DUPButton.Text = "↑";
            DUPButton.UseVisualStyleBackColor = true;
            DUPButton.Click += DUPButton_Click;
            DUPButton.MouseDown += DUPButton_MouseDown;
            DUPButton.MouseUp += DUPButton_MouseUp;
            // 
            // DDOWNButton
            // 
            DDOWNButton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DDOWNButton.Location = new Point(31, 70);
            DDOWNButton.Name = "DDOWNButton";
            DDOWNButton.Size = new Size(26, 26);
            DDOWNButton.TabIndex = 5;
            DDOWNButton.Text = "↓";
            DDOWNButton.UseVisualStyleBackColor = true;
            DDOWNButton.Click += DDOWNButton_Click;
            DDOWNButton.MouseDown += DDOWNButton_MouseDown;
            DDOWNButton.MouseUp += DDOWNButton_MouseUp;
            // 
            // DPADGroupBox
            // 
            DPADGroupBox.Controls.Add(DUPButton);
            DPADGroupBox.Controls.Add(DDOWNButton);
            DPADGroupBox.Controls.Add(DLEFTButton);
            DPADGroupBox.Controls.Add(DRIGHTButton);
            DPADGroupBox.Location = new Point(12, 97);
            DPADGroupBox.Name = "DPADGroupBox";
            DPADGroupBox.Size = new Size(85, 109);
            DPADGroupBox.TabIndex = 6;
            DPADGroupBox.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(XButton);
            groupBox1.Controls.Add(BButton);
            groupBox1.Controls.Add(YButton);
            groupBox1.Controls.Add(AButton);
            groupBox1.Location = new Point(175, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(98, 109);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // XButton
            // 
            XButton.Location = new Point(37, 77);
            XButton.Name = "XButton";
            XButton.Size = new Size(25, 25);
            XButton.TabIndex = 4;
            XButton.Text = "X";
            XButton.UseVisualStyleBackColor = true;
            XButton.Click += XButton_Click;
            XButton.MouseDown += XButton_MouseDown;
            XButton.MouseUp += XButton_MouseUp;
            // 
            // BButton
            // 
            BButton.Location = new Point(37, 15);
            BButton.Name = "BButton";
            BButton.Size = new Size(25, 25);
            BButton.TabIndex = 5;
            BButton.Text = "B";
            BButton.UseVisualStyleBackColor = true;
            BButton.Click += BButton_Click;
            BButton.MouseDown += BButton_MouseDown;
            BButton.MouseUp += BButton_MouseUp;
            // 
            // YButton
            // 
            YButton.Location = new Point(9, 46);
            YButton.Name = "YButton";
            YButton.Size = new Size(25, 25);
            YButton.TabIndex = 2;
            YButton.Text = "Y";
            YButton.UseVisualStyleBackColor = true;
            YButton.Click += YButton_Click;
            YButton.MouseDown += YButton_MouseDown;
            YButton.MouseUp += YButton_MouseUp;
            // 
            // AButton
            // 
            AButton.Location = new Point(65, 46);
            AButton.Name = "AButton";
            AButton.Size = new Size(25, 25);
            AButton.TabIndex = 3;
            AButton.Text = "A";
            AButton.UseVisualStyleBackColor = true;
            AButton.Click += AButton_Click;
            AButton.MouseDown += AButton_MouseDown;
            AButton.MouseUp += AButton_MouseUp;
            // 
            // PLUSBUtton
            // 
            PLUSBUtton.Location = new Point(152, 21);
            PLUSBUtton.Name = "PLUSBUtton";
            PLUSBUtton.Size = new Size(22, 23);
            PLUSBUtton.TabIndex = 9;
            PLUSBUtton.Text = "+";
            PLUSBUtton.UseVisualStyleBackColor = true;
            PLUSBUtton.Click += PLUSBUtton_Click;
            // 
            // MINUSButton
            // 
            MINUSButton.AllowDrop = true;
            MINUSButton.Location = new Point(93, 21);
            MINUSButton.Name = "MINUSButton";
            MINUSButton.Size = new Size(23, 23);
            MINUSButton.TabIndex = 8;
            MINUSButton.Text = "-";
            MINUSButton.UseVisualStyleBackColor = true;
            MINUSButton.Click += MINUSButton_Click;
            // 
            // LButton
            // 
            LButton.Location = new Point(15, 21);
            LButton.Name = "LButton";
            LButton.Size = new Size(75, 23);
            LButton.TabIndex = 11;
            LButton.Text = "L";
            LButton.UseVisualStyleBackColor = true;
            LButton.Click += LButton_Click;
            // 
            // RButton
            // 
            RButton.Location = new Point(180, 21);
            RButton.Name = "RButton";
            RButton.Size = new Size(75, 23);
            RButton.TabIndex = 12;
            RButton.Text = "R";
            RButton.UseVisualStyleBackColor = true;
            RButton.Click += RButton_Click;
            // 
            // IPAddress
            // 
            IPAddress.Location = new Point(14, 13);
            IPAddress.Name = "IPAddress";
            IPAddress.Size = new Size(112, 23);
            IPAddress.TabIndex = 13;
            // 
            // Connect
            // 
            Connect.Location = new Point(132, 12);
            Connect.Name = "Connect";
            Connect.Size = new Size(77, 25);
            Connect.TabIndex = 14;
            Connect.Text = "Connect";
            Connect.UseVisualStyleBackColor = true;
            Connect.Click += Connect_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(MINUSButton);
            groupBox2.Controls.Add(PLUSBUtton);
            groupBox2.Controls.Add(LButton);
            groupBox2.Controls.Add(RButton);
            groupBox2.Location = new Point(12, 41);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(261, 50);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(HOMEButton);
            groupBox3.Controls.Add(CAPUTREButton);
            groupBox3.Location = new Point(105, 105);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(64, 88);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            // 
            // IsConnectedTextBox
            // 
            IsConnectedTextBox.BackColor = Color.Firebrick;
            IsConnectedTextBox.Cursor = Cursors.No;
            IsConnectedTextBox.Location = new Point(219, 14);
            IsConnectedTextBox.Name = "IsConnectedTextBox";
            IsConnectedTextBox.ReadOnly = true;
            IsConnectedTextBox.Size = new Size(54, 23);
            IsConnectedTextBox.TabIndex = 17;
            // 
            // Controller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 216);
            Controls.Add(IsConnectedTextBox);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(Connect);
            Controls.Add(IPAddress);
            Controls.Add(DPADGroupBox);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "Controller";
            Text = "Controller";
            Load += Controller_Load;
            DPADGroupBox.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CAPUTREButton;
        private Button HOMEButton;
        private Button DLEFTButton;
        private Button DRIGHTButton;
        private Button DUPButton;
        private Button DDOWNButton;
        private GroupBox DPADGroupBox;
        private GroupBox groupBox1;
        private Button XButton;
        private Button AButton;
        private Button YButton;
        private Button BButton;
        private Button PLUSBUtton;
        private Button MINUSButton;
        private Button LButton;
        private Button RButton;
        private TextBox IPAddress;
        private Button Connect;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox IsConnectedTextBox;
    }
}