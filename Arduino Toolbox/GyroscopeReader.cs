using System;
using System.Drawing;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_Toolbox
{
    public partial class GyroscopeReader : Form
    {
        //  Initialize
        bool test;
        bool menuOpen = true;
        int n = 4;
        public GyroscopeReader(int height, int width, int x, int y , System.Windows.Forms.FormWindowState state)
        {
            InitializeComponent();
            this.Height = height;
            this.Width = width;
            this.Location = new Point(x, y);
            this.WindowState = state;
            marginLabel.Height = ((toolStrip.Size.Height - 52) / 2) - (15 * n);
            Applet.Location = new Point((this.Size.Width / 2) - (Applet.Width / 2), (this.Size.Height / 2) - (Applet.Height / 2));
        }

        private void GyroscopeReader_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        //   Menu 
        private void Menu_Click(object sender, EventArgs e)
        {
            MenuBarAnimation.Start();
        }

        private void GyroscopeReader_Click(object sender, EventArgs e)
        {
            menuOpen = true;
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

        //  Redirection
        private async void SerialMonitor_Click(object sender, EventArgs e)
        {
            Arduino.Close();
            Form SRMonitor = new SerialMonitor(this.Height, this.Width, this.Location.X, this.Location.Y, this.WindowState);
            SRMonitor.Show();
            await Task.Delay(70);
            this.Hide();
        }

        private async void ServoArm_Click(object sender, EventArgs e)
        {
            Arduino.Close();
            Form SRMonitor = new ServoArm(this.Height, this.Width, this.Location.X, this.Location.Y, this.WindowState);
            SRMonitor.Show();
            await Task.Delay(70);
            this.Hide();
        }

        //  Auto Allign
        private void GyroscopeReader_SizeChanged(object sender, EventArgs e)
        {
            marginLabel.Height = ((toolStrip.Size.Height - 52) / 2) - (15 * n);
            Applet.Location = new Point((this.Size.Width / 2) - (Applet.Width / 2), (this.Size.Height / 2) - (Applet.Height / 2));
        }

        // Applet
        private void Scan_Click(object sender, EventArgs e)
        {
            Arduino.Close();
            Connect_pbar.Value = 0;

            Connect.Enabled = false;
            Connect.BringToFront();

            Disconnect.Enabled = false;
            Disconnect.SendToBack();

            baud.Enabled = false;
            baud.SelectedItem = "9600";

            prts.Enabled = false;
            prts.Items.Clear();
            prts.Items.AddRange(SerialPort.GetPortNames());

            try
            {
                prts.SelectedIndex = 0;
                test = true;
            }
            catch
            {
                MessageBox.Show("No Ports detected");
                test = false;
                prts.Text = "";
                prts.Items.Clear();
            }

            if (test == true)
            {
                Connect.Enabled = true;
                prts.Enabled = true;
                baud.Enabled = true;
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                Arduino.BaudRate = int.Parse(baud.Text);
                Arduino.PortName = prts.Text;
                Arduino.Open();
                test = true;
            }
            catch (Exception x)
            {
                MessageBox.Show("Could not Connect \n" + x.ToString());
                test = false;
            }

            if (test == true)
            {
                Connect_pbar.Value = 100;

                Connect.Enabled = false;
                Connect.SendToBack();

                Disconnect.Enabled = true;
                Disconnect.BringToFront();

                prts.Enabled = false;

                baud.Enabled = false;
            }
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            Disconnect.Enabled = false;
            Disconnect.SendToBack();

            Connect.Enabled = true;
            Connect.BringToFront();

            Arduino.Close();
            Connect_pbar.Value = 0;
        }

        private void Arduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            String[] data = Arduino.ReadLine().Split('/');
            try
            {
                roll_pbar.Value = (int)float.Parse(data[0]) + 180;
                pitch_pbar.Value = (int)float.Parse(data[1]) + 90;
                roll.Text = data[0];
                pitch.Text = data[1];
            }
            catch { }
        }

        // Exit
        private void Exit(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            System.Environment.Exit(0);
        }
    }
}
