using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_Toolbox
{
    public partial class ServoArm : Form
    {
        //  Initialize
        bool test;
        bool menuOpen = true;
        int claw = 0;
        readonly int n = 3;
        readonly Bitmap A1 = Arduino_Toolbox.Properties.Resources.Servo_arm_1_resized;
        readonly Bitmap A2 = Arduino_Toolbox.Properties.Resources.Servo_arm_2_resized;
        readonly Bitmap A3 = Arduino_Toolbox.Properties.Resources.Servo_arm_claw_resized;
        readonly Bitmap ba = Arduino_Toolbox.Properties.Resources.Servo_arm_base_resized;

        public ServoArm(int height, int width, int x, int y, System.Windows.Forms.FormWindowState state)
        {
            InitializeComponent();
            this.Height = height;
            this.Width = width;
            this.Location = new Point(x, y);
            this.WindowState = state;
            marginLabel.Height = ((toolStrip.Size.Height - 52) / 2) - (15 * n);
            Applet.Location = new Point(151, (this.Size.Height / 2) - (Applet.Height / 2));
        }

        private void ServoArm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            gfx_refresh.Start();
            //refresh_angles.Start();
            timer.Text = 50.ToString();
            B.Value = 90;
            B_A1.Value = 20;
            A1_A2.Value = 45;
            A2_A3.Value = 110;
        }




        //   Menu 
        private void Menu_Click(object sender, EventArgs e)
        {
            MenuBarAnimation.Start();
        }

        private void ServoArm_Click(object sender, EventArgs e)
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
                    toolStrip.Width += 36;
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
                    toolStrip.Width -= 36;
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
            Servo_Arm.Visible = !state;
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

        private async void GyroReader_Click(object sender, EventArgs e)
        {
            Arduino.Close();
            Form SRMonitor = new GyroscopeReader(this.Height, this.Width, this.Location.X, this.Location.Y, this.WindowState);
            SRMonitor.Show();
            await Task.Delay(70);
            this.Hide();
        }




        //  Auto Allign
        private void ServoArm_SizeChanged(object sender, EventArgs e)
        {
            marginLabel.Height = ((toolStrip.Size.Height - 52) / 2) - (15 * n);
            Applet.Location = new Point(151, (this.Size.Height / 2) - (Applet.Height / 2));
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
        
        private void SendAngles()
        {
            raw.Text = "a" + B.Value.ToString() + "b" + B_A1.Value.ToString() + "c" + A1_A2.Value.ToString() + "d" + A2_A3.Value.ToString() + "e" + claw.ToString();
            if (Arduino.IsOpen == true) Arduino.WriteLine(raw.Text);
        }

        private void Claw_Click(object sender, EventArgs e)
        {
            if (claw == 0) { claw = 1; Claw.Text = "Close"; }
            else { claw = 0; Claw.Text = "Open"; }
        }




        // Exit
        private void Exit(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            System.Environment.Exit(0);
        }




        // Graphics Varibles
        Point Centre_WRT_picBox;
        Point Centre_WRT_IMG;
        Point CentreTranslation;
        int Radius;
        Size GFX_Size;


        // Graphics Functions
        private Point CircularTranslation(int degrees, int radius, Point centre) // Calculates the new location of the top left corner
        {
            double radians = degrees * Math.PI / 180.0;

            // Calculate new coordinates
            double newX = centre.X - radius * Math.Cos(radians);
            double newY = centre.Y - radius * Math.Sin(radians);

            return new Point((int)newX, (int)newY);
        }

        private Bitmap RotateImage(Bitmap bmp, float angle, Point Centre_WRT_picBox, Point Centre_WRT_IMG, Size picBox_size)
        {
            Bitmap rotatedImage = new Bitmap(picBox_size.Width, picBox_size.Height);
            rotatedImage.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                // Set the rotation point to the center in the matrix
                g.TranslateTransform(Centre_WRT_picBox.X, Centre_WRT_picBox.Y);
                // Rotate
                g.RotateTransform(angle);
                // Restore rotation point in the matrix
                g.TranslateTransform(-Centre_WRT_IMG.X, -Centre_WRT_IMG.Y);
                // Draw the image on the bitmap
                g.DrawImage(bmp, new Point(0, 0));
            }

            return rotatedImage;
        }




        // Graphics Engine
        private void base_ValueChanged(object sender, EventArgs e)
        {
            B_Label.Text = B.Value.ToString();
            //SendAngles();
        }

        private void joint1_ValueChanged(object sender, EventArgs e)
        {
            B_A1_Label.Text = B_A1.Value.ToString();
            //SendAngles();
        }

        private void joint2_ValueChanged(object sender, EventArgs e)
        {
            A1_A2_Label.Text = A1_A2.Value.ToString();
            //SendAngles();
        }

        private void joint3_ValueChanged(object sender, EventArgs e)
        {
            A2_A3_Label.Text = A2_A3.Value.ToString();
            //refresh_angles.Interval = A2_A3.Value;
        }

        private void refresh_gfx(object sender, EventArgs e)
        {
            Centre_WRT_picBox = new Point(1100, 700);
            Centre_WRT_IMG = new Point(A1.Width - 40, 40);
            GFX_Size = new Size(1400, 1000);

            Arm1.Image = RotateImage(A1, B_A1.Value + 5, Centre_WRT_picBox, Centre_WRT_IMG, GFX_Size);
            Base.Image = RotateImage(ba, 0, Centre_WRT_picBox, new Point(ba.Width-120,40), GFX_Size);

            Radius = A1.Width - 70;
            Centre_WRT_IMG = new Point(A2.Width - 30, A2.Height / 2);
            CentreTranslation = new Point(Arm1.Location.X + Centre_WRT_picBox.X - Centre_WRT_IMG.X, Arm1.Location.Y + Centre_WRT_picBox.Y - Centre_WRT_IMG.Y);
            Centre_WRT_picBox = Centre_WRT_IMG;
            GFX_Size = new Size(A2.Width+5, A2.Width+5);

            Arm2.Image = RotateImage(A2, -A1_A2.Value - 5, Centre_WRT_picBox, Centre_WRT_IMG, GFX_Size);
            Arm2.Location = CircularTranslation(B_A1.Value - 10, Radius, CentreTranslation);

            Radius = A2.Width - 60;
            CentreTranslation = new Point(Arm2.Location.X + Centre_WRT_picBox.X - (A3.Width - 15), Arm2.Location.Y + Centre_WRT_picBox.Y - (A3.Height/2));

            Arm3.Location = CircularTranslation(-A1_A2.Value - 5, Radius, CentreTranslation);

            if (timer.Text == "0")
            {
                timer.Text = 50.ToString();
                SendAngles();
            }
            else {
                timer.Text = (int.Parse(timer.Text) - 1).ToString();
            }
        }

        private void refresh_angles_Tick(object sender, EventArgs e)
        {
            SendAngles();
        }
    }
}
