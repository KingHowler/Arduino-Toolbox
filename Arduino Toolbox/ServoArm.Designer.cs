namespace Arduino_Toolbox
{
    partial class ServoArm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServoArm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.Menu = new System.Windows.Forms.ToolStripLabel();
            this.marginLabel = new System.Windows.Forms.ToolStripLabel();
            this.website = new System.Windows.Forms.ToolStripLabel();
            this.Serial_Monitor = new System.Windows.Forms.ToolStripLabel();
            this.GyroReader = new System.Windows.Forms.ToolStripLabel();
            this.Servo_Arm = new System.Windows.Forms.ToolStripLabel();
            this.MenuBarAnimation = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Scan = new Guna.UI2.WinForms.Guna2Button();
            this.Applet = new Guna.UI2.WinForms.Guna2GroupBox();
            this.timer = new System.Windows.Forms.Label();
            this.B_Label = new System.Windows.Forms.Label();
            this.B = new Guna.UI2.WinForms.Guna2TrackBar();
            this.raw = new System.Windows.Forms.Label();
            this.Claw = new Guna.UI2.WinForms.Guna2Button();
            this.A2_A3_Label = new System.Windows.Forms.Label();
            this.A1_A2_Label = new System.Windows.Forms.Label();
            this.B_A1_Label = new System.Windows.Forms.Label();
            this.A2_A3 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.A1_A2 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.B_A1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.Connect_pbar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.baud = new System.Windows.Forms.ComboBox();
            this.prts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Connect = new Guna.UI2.WinForms.Guna2Button();
            this.Disconnect = new Guna.UI2.WinForms.Guna2Button();
            this.Arduino = new System.IO.Ports.SerialPort(this.components);
            this.gfx_refresh = new System.Windows.Forms.Timer(this.components);
            this.refresh_angles = new System.Windows.Forms.Timer(this.components);
            this.Base = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Arm1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Arm2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Arm3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.toolStrip.SuspendLayout();
            this.Applet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arm1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arm2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arm3)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(145)))));
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu,
            this.marginLabel,
            this.website,
            this.Serial_Monitor,
            this.GyroReader,
            this.Servo_Arm});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(148, 667);
            this.toolStrip.TabIndex = 5;
            // 
            // Menu
            // 
            this.Menu.AutoSize = false;
            this.Menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu.Image = global::Arduino_Toolbox.Properties.Resources.hamburger_menu;
            this.Menu.ImageTransparentColor = System.Drawing.Color.White;
            this.Menu.Margin = new System.Windows.Forms.Padding(2, 1, 0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(36, 36);
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // marginLabel
            // 
            this.marginLabel.AutoSize = false;
            this.marginLabel.Margin = new System.Windows.Forms.Padding(0);
            this.marginLabel.Name = "marginLabel";
            this.marginLabel.Size = new System.Drawing.Size(111, 20);
            // 
            // Serial_Monitor
            // 
            this.Serial_Monitor.AutoSize = false;
            this.Serial_Monitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Serial_Monitor.ForeColor = System.Drawing.Color.White;
            this.Serial_Monitor.Margin = new System.Windows.Forms.Padding(0);
            this.Serial_Monitor.Name = "Serial_Monitor";
            this.Serial_Monitor.Size = new System.Drawing.Size(148, 30);
            this.Serial_Monitor.Text = "Serial Monitor";
            this.Serial_Monitor.Click += new System.EventHandler(this.SerialMonitor_Click);
            // 
            // GyroReader
            // 
            this.GyroReader.AutoSize = false;
            this.GyroReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GyroReader.ForeColor = System.Drawing.Color.White;
            this.GyroReader.Margin = new System.Windows.Forms.Padding(0);
            this.GyroReader.Name = "GyroReader";
            this.GyroReader.Size = new System.Drawing.Size(148, 30);
            this.GyroReader.Text = "Gyro Reader";
            this.GyroReader.Click += new System.EventHandler(this.GyroReader_Click);
            // 
            // Servo_Arm
            // 
            this.Servo_Arm.AutoSize = false;
            this.Servo_Arm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Servo_Arm.ForeColor = System.Drawing.Color.White;
            this.Servo_Arm.Margin = new System.Windows.Forms.Padding(0);
            this.Servo_Arm.Name = "Servo_Arm";
            this.Servo_Arm.Size = new System.Drawing.Size(148, 30);
            this.Servo_Arm.Text = "Servo Arm";
            // 
            // MenuBarAnimation
            // 
            this.MenuBarAnimation.Interval = 1;
            this.MenuBarAnimation.Tick += new System.EventHandler(this.MenuBarAnimation_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(227, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ports";
            // 
            // Scan
            // 
            this.Scan.BorderColor = System.Drawing.Color.LightGray;
            this.Scan.BorderRadius = 10;
            this.Scan.BorderThickness = 1;
            this.Scan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Scan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Scan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Scan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Scan.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Scan.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scan.ForeColor = System.Drawing.Color.Black;
            this.Scan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(145)))));
            this.Scan.HoverState.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scan.HoverState.ForeColor = System.Drawing.Color.White;
            this.Scan.Location = new System.Drawing.Point(15, 15);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(180, 45);
            this.Scan.TabIndex = 2;
            this.Scan.Text = "Scan Ports";
            this.Scan.Click += new System.EventHandler(this.Scan_Click);
            // 
            // Applet
            // 
            this.Applet.BorderColor = System.Drawing.Color.Black;
            this.Applet.BorderRadius = 5;
            this.Applet.BorderThickness = 0;
            this.Applet.Controls.Add(this.timer);
            this.Applet.Controls.Add(this.B_Label);
            this.Applet.Controls.Add(this.B);
            this.Applet.Controls.Add(this.raw);
            this.Applet.Controls.Add(this.Claw);
            this.Applet.Controls.Add(this.A2_A3_Label);
            this.Applet.Controls.Add(this.A1_A2_Label);
            this.Applet.Controls.Add(this.B_A1_Label);
            this.Applet.Controls.Add(this.A2_A3);
            this.Applet.Controls.Add(this.A1_A2);
            this.Applet.Controls.Add(this.B_A1);
            this.Applet.Controls.Add(this.Connect_pbar);
            this.Applet.Controls.Add(this.baud);
            this.Applet.Controls.Add(this.prts);
            this.Applet.Controls.Add(this.label2);
            this.Applet.Controls.Add(this.Connect);
            this.Applet.Controls.Add(this.label1);
            this.Applet.Controls.Add(this.Scan);
            this.Applet.Controls.Add(this.Disconnect);
            this.Applet.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Applet.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Applet.ForeColor = System.Drawing.Color.Black;
            this.Applet.Location = new System.Drawing.Point(151, 12);
            this.Applet.Name = "Applet";
            this.Applet.Size = new System.Drawing.Size(457, 512);
            this.Applet.TabIndex = 6;
            this.Applet.Click += new System.EventHandler(this.ServoArm_Click);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.ForeColor = System.Drawing.Color.Black;
            this.timer.Location = new System.Drawing.Point(9, 426);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(70, 31);
            this.timer.TabIndex = 24;
            this.timer.Text = "Timer";
            // 
            // B_Label
            // 
            this.B_Label.AutoSize = true;
            this.B_Label.Location = new System.Drawing.Point(333, 133);
            this.B_Label.Name = "B_Label";
            this.B_Label.Size = new System.Drawing.Size(62, 28);
            this.B_Label.TabIndex = 23;
            this.B_Label.Text = "Joint 1";
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(15, 164);
            this.B.Maximum = 180;
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(431, 23);
            this.B.TabIndex = 22;
            this.B.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(145)))));
            this.B.Value = 90;
            this.B.ValueChanged += new System.EventHandler(this.base_ValueChanged);
            // 
            // raw
            // 
            this.raw.AutoSize = true;
            this.raw.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raw.ForeColor = System.Drawing.Color.Black;
            this.raw.Location = new System.Drawing.Point(9, 381);
            this.raw.Name = "raw";
            this.raw.Size = new System.Drawing.Size(54, 31);
            this.raw.TabIndex = 21;
            this.raw.Text = "Raw";
            // 
            // Claw
            // 
            this.Claw.BorderColor = System.Drawing.Color.LightGray;
            this.Claw.BorderRadius = 10;
            this.Claw.BorderThickness = 1;
            this.Claw.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Claw.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Claw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Claw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Claw.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Claw.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Claw.ForeColor = System.Drawing.Color.Black;
            this.Claw.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(145)))));
            this.Claw.HoverState.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Claw.HoverState.ForeColor = System.Drawing.Color.White;
            this.Claw.Location = new System.Drawing.Point(266, 372);
            this.Claw.Name = "Claw";
            this.Claw.Size = new System.Drawing.Size(180, 45);
            this.Claw.TabIndex = 20;
            this.Claw.Text = "Open";
            this.Claw.Click += new System.EventHandler(this.Claw_Click);
            // 
            // A2_A3_Label
            // 
            this.A2_A3_Label.AutoSize = true;
            this.A2_A3_Label.Location = new System.Drawing.Point(333, 304);
            this.A2_A3_Label.Name = "A2_A3_Label";
            this.A2_A3_Label.Size = new System.Drawing.Size(66, 28);
            this.A2_A3_Label.TabIndex = 18;
            this.A2_A3_Label.Text = "Joint 4";
            // 
            // A1_A2_Label
            // 
            this.A1_A2_Label.AutoSize = true;
            this.A1_A2_Label.Location = new System.Drawing.Point(333, 247);
            this.A1_A2_Label.Name = "A1_A2_Label";
            this.A1_A2_Label.Size = new System.Drawing.Size(65, 28);
            this.A1_A2_Label.TabIndex = 17;
            this.A1_A2_Label.Text = "Joint 3";
            // 
            // B_A1_Label
            // 
            this.B_A1_Label.AutoSize = true;
            this.B_A1_Label.Location = new System.Drawing.Point(333, 190);
            this.B_A1_Label.Name = "B_A1_Label";
            this.B_A1_Label.Size = new System.Drawing.Size(65, 28);
            this.B_A1_Label.TabIndex = 16;
            this.B_A1_Label.Text = "Joint 2";
            // 
            // A2_A3
            // 
            this.A2_A3.Location = new System.Drawing.Point(15, 335);
            this.A2_A3.Maximum = 180;
            this.A2_A3.Minimum = 30;
            this.A2_A3.Name = "A2_A3";
            this.A2_A3.Size = new System.Drawing.Size(431, 23);
            this.A2_A3.TabIndex = 15;
            this.A2_A3.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(145)))));
            this.A2_A3.Value = 100;
            this.A2_A3.ValueChanged += new System.EventHandler(this.joint3_ValueChanged);
            // 
            // A1_A2
            // 
            this.A1_A2.Location = new System.Drawing.Point(15, 278);
            this.A1_A2.Maximum = 45;
            this.A1_A2.Name = "A1_A2";
            this.A1_A2.Size = new System.Drawing.Size(431, 23);
            this.A1_A2.TabIndex = 14;
            this.A1_A2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(145)))));
            this.A1_A2.Value = 45;
            this.A1_A2.ValueChanged += new System.EventHandler(this.joint2_ValueChanged);
            // 
            // B_A1
            // 
            this.B_A1.Location = new System.Drawing.Point(15, 221);
            this.B_A1.Maximum = 115;
            this.B_A1.Minimum = 20;
            this.B_A1.Name = "B_A1";
            this.B_A1.Size = new System.Drawing.Size(431, 23);
            this.B_A1.TabIndex = 13;
            this.B_A1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(145)))));
            this.B_A1.Value = 20;
            this.B_A1.ValueChanged += new System.EventHandler(this.joint1_ValueChanged);
            // 
            // Connect_pbar
            // 
            this.Connect_pbar.Location = new System.Drawing.Point(15, 117);
            this.Connect_pbar.Name = "Connect_pbar";
            this.Connect_pbar.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.SolidTransition;
            this.Connect_pbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(145)))));
            this.Connect_pbar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(145)))));
            this.Connect_pbar.Size = new System.Drawing.Size(431, 10);
            this.Connect_pbar.TabIndex = 8;
            this.Connect_pbar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // baud
            // 
            this.baud.Enabled = false;
            this.baud.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baud.FormattingEnabled = true;
            this.baud.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "31250",
            "38400",
            "57600",
            "115200"});
            this.baud.Location = new System.Drawing.Point(325, 72);
            this.baud.Name = "baud";
            this.baud.Size = new System.Drawing.Size(121, 39);
            this.baud.TabIndex = 10;
            // 
            // prts
            // 
            this.prts.Enabled = false;
            this.prts.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prts.FormattingEnabled = true;
            this.prts.Location = new System.Drawing.Point(325, 18);
            this.prts.Name = "prts";
            this.prts.Size = new System.Drawing.Size(121, 39);
            this.prts.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(200, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Baud Rate";
            // 
            // Connect
            // 
            this.Connect.BorderColor = System.Drawing.Color.LightGray;
            this.Connect.BorderRadius = 10;
            this.Connect.BorderThickness = 1;
            this.Connect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Connect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Connect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Connect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Connect.Enabled = false;
            this.Connect.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Connect.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.ForeColor = System.Drawing.Color.Black;
            this.Connect.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(145)))));
            this.Connect.HoverState.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.HoverState.ForeColor = System.Drawing.Color.White;
            this.Connect.Location = new System.Drawing.Point(15, 66);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(180, 45);
            this.Connect.TabIndex = 4;
            this.Connect.Text = "Connect";
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Disconnect
            // 
            this.Disconnect.BorderColor = System.Drawing.Color.LightGray;
            this.Disconnect.BorderRadius = 10;
            this.Disconnect.BorderThickness = 1;
            this.Disconnect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Disconnect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Disconnect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Disconnect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Disconnect.Enabled = false;
            this.Disconnect.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Disconnect.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disconnect.ForeColor = System.Drawing.Color.Black;
            this.Disconnect.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(145)))));
            this.Disconnect.HoverState.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disconnect.HoverState.ForeColor = System.Drawing.Color.White;
            this.Disconnect.Location = new System.Drawing.Point(15, 66);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(180, 45);
            this.Disconnect.TabIndex = 12;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // gfx_refresh
            // 
            this.gfx_refresh.Interval = 10;
            this.gfx_refresh.Tick += new System.EventHandler(this.refresh_gfx);
            // 
            // refresh_angles
            // 
            this.refresh_angles.Interval = 1050;
            this.refresh_angles.Tick += new System.EventHandler(this.refresh_angles_Tick);
            // 
            // Base
            // 
            this.Base.BackColor = System.Drawing.Color.Transparent;
            this.Base.FillColor = System.Drawing.Color.Transparent;
            this.Base.Image = global::Arduino_Toolbox.Properties.Resources.Servo_arm_base_resized;
            this.Base.ImageRotate = 0F;
            this.Base.Location = new System.Drawing.Point(527, 12);
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(400, 291);
            this.Base.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Base.TabIndex = 10;
            this.Base.TabStop = false;
            this.Base.UseTransparentBackground = true;
            this.Base.Click += new System.EventHandler(this.ServoArm_Click);
            // 
            // Arm1
            // 
            this.Arm1.BackColor = System.Drawing.Color.Transparent;
            this.Arm1.Image = global::Arduino_Toolbox.Properties.Resources.Servo_arm_1_resized;
            this.Arm1.ImageRotate = 0F;
            this.Arm1.Location = new System.Drawing.Point(527, 12);
            this.Arm1.Name = "Arm1";
            this.Arm1.Size = new System.Drawing.Size(427, 189);
            this.Arm1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Arm1.TabIndex = 7;
            this.Arm1.TabStop = false;
            this.Arm1.UseTransparentBackground = true;
            this.Arm1.Click += new System.EventHandler(this.ServoArm_Click);
            // 
            // Arm2
            // 
            this.Arm2.BackColor = System.Drawing.Color.Transparent;
            this.Arm2.BorderRadius = 2;
            this.Arm2.Image = global::Arduino_Toolbox.Properties.Resources.Servo_arm_2_resized;
            this.Arm2.ImageRotate = 0F;
            this.Arm2.Location = new System.Drawing.Point(614, 98);
            this.Arm2.Name = "Arm2";
            this.Arm2.Size = new System.Drawing.Size(400, 62);
            this.Arm2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Arm2.TabIndex = 8;
            this.Arm2.TabStop = false;
            this.Arm2.UseTransparentBackground = true;
            this.Arm2.Click += new System.EventHandler(this.ServoArm_Click);
            // 
            // Arm3
            // 
            this.Arm3.BackColor = System.Drawing.Color.Transparent;
            this.Arm3.Image = global::Arduino_Toolbox.Properties.Resources.Servo_arm_claw_resized;
            this.Arm3.ImageRotate = 0F;
            this.Arm3.Location = new System.Drawing.Point(614, 184);
            this.Arm3.Name = "Arm3";
            this.Arm3.Size = new System.Drawing.Size(303, 50);
            this.Arm3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Arm3.TabIndex = 9;
            this.Arm3.TabStop = false;
            this.Arm3.UseTransparentBackground = true;
            this.Arm3.Click += new System.EventHandler(this.ServoArm_Click);
            // 
            // ServoArm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1410, 667);
            this.Controls.Add(this.Applet);
            this.Controls.Add(this.Base);
            this.Controls.Add(this.Arm1);
            this.Controls.Add(this.Arm2);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.Arm3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServoArm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Servo Arm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exit);
            this.Load += new System.EventHandler(this.ServoArm_Load);
            this.SizeChanged += new System.EventHandler(this.ServoArm_SizeChanged);
            this.Click += new System.EventHandler(this.ServoArm_Click);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.Applet.ResumeLayout(false);
            this.Applet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arm1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arm2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arm3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
#pragma warning disable
        private System.Windows.Forms.ToolStripLabel Menu;
#pragma warning enable
        private System.Windows.Forms.ToolStripLabel marginLabel;
        private System.Windows.Forms.ToolStripLabel Serial_Monitor;
        private System.Windows.Forms.ToolStripLabel GyroReader;
        private System.Windows.Forms.ToolStripLabel Servo_Arm;
        private System.Windows.Forms.Timer MenuBarAnimation;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button Scan;
        private Guna.UI2.WinForms.Guna2GroupBox Applet;
        private Guna.UI2.WinForms.Guna2Button Connect;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort Arduino;
        private System.Windows.Forms.ComboBox baud;
        private System.Windows.Forms.ComboBox prts;
        private Guna.UI2.WinForms.Guna2Button Disconnect;
        private Guna.UI2.WinForms.Guna2ProgressBar Connect_pbar;
        private Guna.UI2.WinForms.Guna2TrackBar B_A1;
        private System.Windows.Forms.Timer gfx_refresh;
        private Guna.UI2.WinForms.Guna2TrackBar A1_A2;
        private Guna.UI2.WinForms.Guna2PictureBox Arm1;
        private Guna.UI2.WinForms.Guna2PictureBox Arm2;
        private Guna.UI2.WinForms.Guna2PictureBox Arm3;
        private Guna.UI2.WinForms.Guna2TrackBar A2_A3;
        private System.Windows.Forms.Label B_A1_Label;
        private System.Windows.Forms.Label A1_A2_Label;
        private System.Windows.Forms.Label A2_A3_Label;
        private Guna.UI2.WinForms.Guna2Button Claw;
        private System.Windows.Forms.Label raw;
        private System.Windows.Forms.Timer refresh_angles;
        private System.Windows.Forms.Label B_Label;
        private Guna.UI2.WinForms.Guna2TrackBar B;
        private Guna.UI2.WinForms.Guna2PictureBox Base;
        private System.Windows.Forms.ToolStripLabel website;
        private System.Windows.Forms.Label timer;
    }
}