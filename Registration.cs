using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MY_C_fe
{
    public partial class Registration : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\Project\MY C@fe\MY C@fe\Register.mdf;Integrated Security=True;User Instance=True");
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_alreadyReg_Click(object sender, EventArgs e)
        {
            goToLogin();
        }

        private void goToLogin()
        {
            this.Hide();
            Form1 Login = new Form1();
            Login.ShowDialog();
        }

        private void btn_Reg_Reg_Click(object sender, EventArgs e)
        {
            try
            {
                int day = dtp_dob.Value.Day;
                int month = dtp_dob.Value.Month;
                int year = dtp_dob.Value.Year;
                String gender;
                    if (txt_Fname.Text == "")
                    {
                        clearLable();
                        label10.Text = "Enter First Name";
                    }
                    else if (txt_Lname.Text == "")
                    {
                        clearLable();
                        label11.Text = "Enter Last Name";
                    }
                    else if (txt_UserName.Text == "")
                    {
                        clearLable();
                        label12.Text = "Enter User Name";
                    }
                    else if (txt_Passwd.Text == "")
                    {
                        clearLable();
                        label13.Text = "Enter Passowrd";
                    }
                    else if (txt_Passwd.TextLength < 6)
                    {
                        clearLable();
                        label13.Text = "Password Length Too Short";
                    }
                    else if (txt_RePasswd.Text == "")
                    {
                        clearLable();
                        label14.Text = "Enter Password";
                    }
                    else if (txt_mobile.Text == "")
                    {
                        clearLable();
                        label15.Text = "Enter Mobile Number";
                    }
                    else if (txt_mail.Text == "")
                    {
                        clearLable();
                        label16.Text = "Enter E-Mail ID";
                    }
                    else if (txt_Passwd.Text != txt_RePasswd.Text)
                    {
                        clearLable();
                        label14.Text = "Password Doesn't Match";
                    }
                    else if (!(txt_mobile.Text.Length == 10 || txt_mobile.Text.Length == 13))
                    {
                        clearLable();
                        label15.Text = "Invalid Mobile Number";
                    }
                    else
                    {
                        if (rdb_male.Checked)
                            gender = "Male";
                        else
                            gender = "Female";
                        String bday = day.ToString() + "-" + month.ToString() + "-" + year.ToString();
                        SqlCommand cmd = new SqlCommand("insert into UserData values(@uname,@firstname,@lastname,@passwd,@bday,@mobno,@mail,@gender)", con);
                        cmd.Parameters.AddWithValue("@uname", txt_UserName.Text);
                        cmd.Parameters.AddWithValue("@firstname", txt_Fname.Text);
                        cmd.Parameters.AddWithValue("@lastname", txt_Lname.Text);
                        cmd.Parameters.AddWithValue("@passwd", txt_Passwd.Text);
                        cmd.Parameters.AddWithValue("@bday", bday.ToString());
                        cmd.Parameters.AddWithValue("@mobno", txt_mobile.Text);
                        cmd.Parameters.AddWithValue("@mail", txt_mail.Text);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        con.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("User Succerrfully Registered.");
                            goToLogin();
                        }
                        else
                            MessageBox.Show("User can't be Register.");
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Registration Failed.");
                }
                finally
                {
                    con.Close();
                }
        }

        private void txt_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetterOrDigit(ch) && !char.IsControl(ch))
            {
                e.Handled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_mobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Fname_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        void clearLable()
        {
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
        }

        private void txt_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && !char.IsControl(ch))
            {
                e.Handled = true;
            }
        }

        private void txt_mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_mail_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}