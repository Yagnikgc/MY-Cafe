using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Media;
namespace MY_C_fe
{
     
    public partial class WelCome : Form
    {
        private SoundPlayer sou;
        int timeCs, timeSec, timeMin, timeH;
       public static  String time;
        bool isActive;
        public WelCome()
        {
            InitializeComponent();
            
        }

        private void WelCome_Load(object sender, EventArgs e)
        {
            sou = new SoundPlayer("logged in successfuly.wav");
            sou.Play();
            timeCs = 0;
            timeSec = 0;
            timeMin = 0;
            timeH=0;
            MessageBox.Show("Press \"YES\" in the next Popup Box to Continue ....");
            try
            {
                System.Diagnostics.Process.Start("enable");
                System.Diagnostics.Process.Start("Wifi Enable");
                isActive = true;
            }
            catch (Exception)
            {
                this.Hide();
                Form1 f = new Form1();
                f.ShowDialog();
            }
        }

        private void ovalShape1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void ovalShape1_Click_1(object sender, EventArgs e)
        {
        //System .Diagnostics .Process .Start (@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");
        }

        private void ovalShape1_Click_2(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("chrome.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("Your Chrome Browser Is not Working Properly \n\n Retry Opening the same broweser or Another Browser ");
            }
        }

        private void shp_explorer_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("iexplore.exe");
            }
            catch (Exception )
            {
                MessageBox.Show("Your Internet Explorer Is not Working Properly \n\n Retry Opening the same broweser or Another Browser ");
            }

        }

        private void mozila_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("firefox.exe");
            }
            catch (Exception )
            {
                MessageBox.Show("Your Firefox Browser Is not Working Properly \n\n Retry Opening the same broweser or Another Browser ");
            }
        }

        private void safari_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Safari");
            }
            catch (Exception )
            {
                MessageBox.Show("Your Safari Browser Is not Working Properly \n\n Retry Opening the same broweser or Another Browser ");
            }
        }

        private void opera_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Opera");
            }
            catch (Exception )
            {
                MessageBox.Show("Your Opera Browser Is not Working Properly \n\n Retry Opening the same broweser or Another Browser ");
            }
        }

        private void timer1_Tick(object sender, EventArgs e) 
        {
            if (isActive)
            {
                timeCs++;
                if (timeCs >= 60)
                {
                    timeSec++;
                    timeCs = 0;
                    if (timeSec >= 60)
                    {
                        timeMin++;
                        timeSec = 0;
                        if (timeMin >= 60)
                        {
                            timeH++;
                            timeMin = 0;
                        }
                    }
                }
            }
            drawTime();
        }

        private void drawTime()
        {
            lbl_sec.Text = String.Format("{0:00}",timeSec);
            lbl_tm.Text = String.Format("{00:00}",timeMin);
            lbl_hours.Text = String.Format("{0:00}",timeH);

        }

        private void lbl_sec_Click(object sender, EventArgs e)
        {

        }

        public void btn_logout_Click(object sender, EventArgs e)
        {
            isActive = false;
            time = lbl_hours.Text + ":" + lbl_tm.Text + ":" + lbl_sec.Text;
            MessageBox.Show(time);
            //System.Diagnostics.Process.Start("");
            MessageBox.Show("Press \"YES\" in the next Popup Box to Continue ....");
            try
            {
                System.Diagnostics.Process.Start("disable");
                System.Diagnostics.Process.Start("Wifi DIsable");
                MessageBox.Show("Disconnected");
            }
            catch (Exception)
            {

            }
            this.Hide();
            Home exit = new Home();
            exit.ShowDialog();
        }
        public string getTime()
        {
            return time;
        }
      
    }
}