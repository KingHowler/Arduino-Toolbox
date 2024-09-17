using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Arduino_Toolbox
{
    public partial class Main : Form
    {
        //  Initialize
        bool menuOpen = false;
        int n = 4;
        public Main()
        {        
            InitializeComponent();       
            marginLabel.Height = ((toolStrip.Size.Height - 52) / 2) - (15 * n);
            Applet.Location = new Point((this.Size.Width / 2) - (Applet.Width / 2), (this.Size.Height / 2) - (Applet.Height / 2));
        }        

        //   Menu 
        private void Menu_Click(object sender, EventArgs e)
        {        
            MenuBarAnimation.Start();
        }
                 
        private void MenuBarAnimation_Tick(object sender, EventArgs e)
        {        
            if (menuOpen == false)
            {    
                if (toolStrip.Width < 148)
                {
                    toolStrip.Width = toolStrip.Width + 12;
                    Hide_MenuItems(false);
                }
                else
                {
                    menuOpen = true;     
                    MenuBarAnimation.Stop();
                }
            }    
            else
            {    
                if (toolStrip.Width > 40)
                {
                    toolStrip.Width = toolStrip.Width - 12;
                    Hide_MenuItems(true);
                }
                else
                {
                    menuOpen = false;
                    MenuBarAnimation.Stop();
                }
            }
        }

        private void Hide_MenuItems(bool state)
        {
            Serial_Monitor.Visible = !state;
            GyroReader.Visible = !state;
            ServoArm.Visible = !state;
            //website.Visible = !state;
        }

        //   Redirection
        private async void SerialMonitor_Click(object sender, EventArgs e)
        {
            Form SRMonitor = new SerialMonitor(this.Height, this.Width, this.Location.X, this.Location.Y, this.WindowState);
            SRMonitor.Show();
            await Task.Delay(70);
            this.Hide();
        }

        private async void GyroReader_Click(object sender, EventArgs e)
        {
            Form SRMonitor = new GyroscopeReader(this.Height, this.Width, this.Location.X, this.Location.Y, this.WindowState);
            SRMonitor.Show();
            await Task.Delay(70);
            this.Hide();
        }

        private async void ServoArm_Click(object sender, EventArgs e)
        {
            Form SRMonitor = new ServoArm(this.Height, this.Width, this.Location.X, this.Location.Y, this.WindowState);
            SRMonitor.Show();
            await Task.Delay(70);
            this.Hide();
        }

        //   Auto Allign
        private void Main_SizeChanged(object sender, EventArgs e)
        {
            marginLabel.Height = ((toolStrip.Size.Height - 52) / 2) - (15 * n);
            Applet.Location = new Point((this.Size.Width/2) - (Applet.Width/2), (this.Size.Height / 2) - (Applet.Height / 2));
        }

        private void Main_Click(object sender, EventArgs e)
        {
            menuOpen = true;
            MenuBarAnimation.Start();
        }

        //  Scan Ports
        private void Scan_Click(object sender, EventArgs e)
        {
            prts.Items.Clear();
            prts.Items.AddRange(SerialPort.GetPortNames());
            try
            {
                prts.SelectedIndex = 0;
            } catch
            {
                MessageBox.Show("No ports Found");
            }
        }

        // Exit
        private void Exit(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            System.Environment.Exit(0);
        }
    }
}
