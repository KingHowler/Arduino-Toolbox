namespace Arduino_Toolbox
{
    partial class SerialMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialMonitor));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.Menu = new System.Windows.Forms.ToolStripLabel();
            this.marginLabel = new System.Windows.Forms.ToolStripLabel();
            this.website = new System.Windows.Forms.ToolStripLabel();
            this.Serial_Monitor = new System.Windows.Forms.ToolStripLabel();
            this.GyroReader = new System.Windows.Forms.ToolStripLabel();
            this.ServoArm = new System.Windows.Forms.ToolStripLabel();
            this.MenuBarAnimation = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Scan = new Guna.UI2.WinForms.Guna2Button();
            this.Applet = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Connect_pbar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.baud = new System.Windows.Forms.ComboBox();
            this.prts = new System.Windows.Forms.ComboBox();
            this.Monitor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Connect = new Guna.UI2.WinForms.Guna2Button();
            this.Disconnect = new Guna.UI2.WinForms.Guna2Button();
            this.Arduino = new System.IO.Ports.SerialPort(this.components);
            this.toolStrip.SuspendLayout();
            this.Applet.SuspendLayout();
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
            this.ServoArm});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(148, 569);
            this.toolStrip.TabIndex = 5;
            // 
            // Menu
            // 
            this.Menu.AutoSize = false;
            this.Menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu.Image = ((System.Drawing.Image)(resources.GetObject("Menu.Image")));
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
            // ServoArm
            // 
            this.ServoArm.AutoSize = false;
            this.ServoArm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ServoArm.ForeColor = System.Drawing.Color.White;
            this.ServoArm.Margin = new System.Windows.Forms.Padding(0);
            this.ServoArm.Name = "ServoArm";
            this.ServoArm.Size = new System.Drawing.Size(148, 30);
            this.ServoArm.Text = "Servo Arm";
            this.ServoArm.Click += new System.EventHandler(this.ServoArm_Click);
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
            this.Applet.Controls.Add(this.Connect_pbar);
            this.Applet.Controls.Add(this.baud);
            this.Applet.Controls.Add(this.prts);
            this.Applet.Controls.Add(this.Monitor);
            this.Applet.Controls.Add(this.label2);
            this.Applet.Controls.Add(this.Connect);
            this.Applet.Controls.Add(this.label1);
            this.Applet.Controls.Add(this.Scan);
            this.Applet.Controls.Add(this.Disconnect);
            this.Applet.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Applet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Applet.ForeColor = System.Drawing.Color.White;
            this.Applet.Location = new System.Drawing.Point(228, 204);
            this.Applet.Name = "Applet";
            this.Applet.Size = new System.Drawing.Size(473, 182);
            this.Applet.TabIndex = 6;
            this.Applet.Click += new System.EventHandler(this.SerialMonitor_Click);
            // 
            // Connect_pbar
            // 
            this.Connect_pbar.Location = new System.Drawing.Point(15, 117);
            this.Connect_pbar.Name = "Connect_pbar";
            this.Connect_pbar.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.SolidTransition;
            this.Connect_pbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(145)))));
            this.Connect_pbar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(145)))));
            this.Connect_pbar.Size = new System.Drawing.Size(431, 10);
            this.Connect_pbar.TabIndex = 7;
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
            // Monitor
            // 
            this.Monitor.AutoSize = true;
            this.Monitor.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monitor.ForeColor = System.Drawing.Color.Black;
            this.Monitor.Location = new System.Drawing.Point(24, 141);
            this.Monitor.Name = "Monitor";
            this.Monitor.Size = new System.Drawing.Size(121, 31);
            this.Monitor.TabIndex = 8;
            this.Monitor.Text = "Serial Data:";
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
            // Arduino
            // 
            this.Arduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Arduino_DataReceived);
            // 
            // SerialMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(931, 569);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.Applet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SerialMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SerialMonitor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exit);
            this.Load += new System.EventHandler(this.SerialMonitor_Load);
            this.SizeChanged += new System.EventHandler(this.SerialMonitor_SizeChanged);
            this.Click += new System.EventHandler(this.SerialMonitor_Click);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.Applet.ResumeLayout(false);
            this.Applet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        #pragma warning disable
        private System.Windows.Forms.ToolStripLabel Menu;
        #pragma warning enable
        private System.Windows.Forms.ToolStripLabel marginLabel;
        private System.Windows.Forms.ToolStripLabel Serial_Monitor;
        private System.Windows.Forms.ToolStripLabel GyroReader;
        private System.Windows.Forms.ToolStripLabel ServoArm;
        private System.Windows.Forms.Timer MenuBarAnimation;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button Scan;
        private Guna.UI2.WinForms.Guna2GroupBox Applet;
        private Guna.UI2.WinForms.Guna2Button Connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Monitor;
        private System.IO.Ports.SerialPort Arduino;
        private System.Windows.Forms.ComboBox baud;
        private System.Windows.Forms.ComboBox prts;
        private Guna.UI2.WinForms.Guna2Button Disconnect;
        private Guna.UI2.WinForms.Guna2ProgressBar Connect_pbar;
        private System.Windows.Forms.ToolStripLabel website;
    }
}