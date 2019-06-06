using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;

namespace MY_C_fe
{
    public partial class Form1 : Form
    {
        private SoundPlayer sou;
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\Project\MY C@fe\MY C@fe\Register.mdf;Integrated Security=True;User Instance=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration();
            reg.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {}
        private void txt_UserName_MouseClick(object sender, MouseEventArgs e)
        {
            txt_UserName.Enabled = true;
            
            txt_UserName.Clear();
            if (txt_password.Text == "")
            {
                txt_password.Text = "Password";
            }
        }
        private void txt_password_MouseClick(object sender, MouseEventArgs e)
        {
            txt_password.Enabled = true;
            txt_password.Clear();
            if (txt_UserName.Text == "")
            {
                txt_password.ForeColor=Color.Gray;
                    Font = new Font(label1.Font, label1.Font.Style & ~FontStyle.Bold);
                txt_UserName.Text = "User Name";
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sou = new SoundPlayer("welcome.wav");
            sou.Play();
        }

        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetterOrDigit(ch) && !char.IsControl(ch))
            {
                e.Handled = true;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter("select password from UserData where username like '" + txt_UserName.Text + "'", con);
                ad.Fill(dt);
                String pwd = dt.Rows[0][0].ToString();
                con.Close();
                
                if (pwd == txt_password.Text)
                {
                    if (txt_UserName.Text == "admin")
                    {
                        this.Hide();
                        Admin adu = new Admin();
                        adu.ShowDialog();
                    }
                    else
                    {
                        this.Hide();
                        WelCome wc = new WelCome();
                        wc.ShowDialog();
                    }
                }
                else
                {
                    SoundPlayer sou2;
                    sou2 = new SoundPlayer("authentication failed.wav");
                    sou2.Play();
                    MessageBox.Show("Invalid UserName or Password.");
                }
            }
            catch (Exception)
            {
                SoundPlayer sou1;
                sou1 = new SoundPlayer("authentication failed.wav");
                sou1.Play();
                MessageBox.Show("User Not Exists");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            changePassword chpwd = new changePassword();
            chpwd.ShowDialog();
        }
    }
}
