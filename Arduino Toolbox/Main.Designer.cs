namespace Arduino_Toolbox
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.Menu = new System.Windows.Forms.ToolStripLabel();
            this.marginLabel = new System.Windows.Forms.ToolStripLabel();
            this.Serial_Monitor = new System.Windows.Forms.ToolStripLabel();
            this.GyroReader = new System.Windows.Forms.ToolStripLabel();
            this.ServoArm = new System.Windows.Forms.ToolStripLabel();
            this.MenuBarAnimation = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Scan = new Guna.UI2.WinForms.Guna2Button();
            this.prts = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Applet = new Guna.UI2.WinForms.Guna2GroupBox();
            this.website = new System.Windows.Forms.ToolStripLabel();
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
            this.toolStrip.Size = new System.Drawing.Size(40, 521);
            this.toolStrip.TabIndex = 0;
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
            this.Serial_Monitor.Visible = false;
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
            this.GyroReader.Visible = false;
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
            this.ServoArm.Visible = false;
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
            this.label1.Location = new System.Drawing.Point(5, 6);
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
            this.Scan.Location = new System.Drawing.Point(32, 78);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(180, 45);
            this.Scan.TabIndex = 2;
            this.Scan.Text = "Scan Ports";
            this.Scan.Click += new System.EventHandler(this.Scan_Click);
            // 
            // prts
            // 
            this.prts.BackColor = System.Drawing.Color.Transparent;
            this.prts.BorderColor = System.Drawing.Color.LightGray;
            this.prts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.prts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prts.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prts.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prts.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.prts.ItemHeight = 30;
            this.prts.Location = new System.Drawing.Point(94, 5);
            this.prts.Name = "prts";
            this.prts.Size = new System.Drawing.Size(140, 36);
            this.prts.TabIndex = 3;
            // 
            // Applet
            // 
            this.Applet.BorderColor = System.Drawing.Color.Black;
            this.Applet.BorderRadius = 5;
            this.Applet.BorderThickness = 0;
            this.Applet.Controls.Add(this.label1);
            this.Applet.Controls.Add(this.prts);
            this.Applet.Controls.Add(this.Scan);
            this.Applet.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Applet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Applet.ForeColor = System.Drawing.Color.White;
            this.Applet.Location = new System.Drawing.Point(216, 188);
            this.Applet.Name = "Applet";
            this.Applet.Size = new System.Drawing.Size(242, 130);
            this.Applet.TabIndex = 4;
            this.Applet.Click += new System.EventHandler(this.Main_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(667, 521);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.Applet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino Toolbox";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exit);
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.Click += new System.EventHandler(this.Main_Click);
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
        private System.Windows.Forms.Timer MenuBarAnimation;
        private System.Windows.Forms.ToolStripLabel Serial_Monitor;
        private System.Windows.Forms.ToolStripLabel marginLabel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button Scan;
        private Guna.UI2.WinForms.Guna2ComboBox prts;
        private Guna.UI2.WinForms.Guna2GroupBox Applet;
        private System.Windows.Forms.ToolStripLabel GyroReader;
        private System.Windows.Forms.ToolStripLabel ServoArm;
        private System.Windows.Forms.ToolStripLabel website;
    }
}

