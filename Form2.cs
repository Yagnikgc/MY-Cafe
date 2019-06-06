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
    public partial class changePassword : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\Project\MY C@fe\MY C@fe\Register.mdf;Integrated Security=True;User Instance=True");

        int check = 0;
        public changePassword()
        {
            InitializeComponent();
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter  adp = new SqlDataAdapter("select count(*) from UserData where username='"+txt_user.Text+"'",con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            check = Convert.ToInt32(dt.Rows[0][0].ToString());
            if (check != 0)
                lbl_user.Text = "";
            else
                lbl_user.Text = "User Not Found";
            con.Close();
        }

        private void changePassword_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear_Lables();
            txt_user.Clear();
            txt_mail.Clear();
            txt_passwd.Clear();
            txt_rpasswd.Clear();
        }

        private void btn_chng_click(object sender, EventArgs e)
        {
            
        }

        private void btn_chng_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select count(*) from UserData where username='" + txt_user.Text + "' and mailid='" + txt_mail.Text + "'", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            int check1 = Convert.ToInt32(dt.Rows[0][0].ToString());
            if (txt_user.Text == "")
            {
                Clear_Lables();
                lbl_user.Text = "Enter User Name";
            }
            else if (!(check1 > 0))
            {
                Clear_Lables();
                lbl_mail.Text = "Invalid E-Mail";
            }
            else if (txt_passwd.TextLength < 6)
            {
                Clear_Lables();
                lbl_pwd.Text = "Password Too Short";
            }
            else if (txt_passwd.Text != txt_rpasswd.Text)
            {
                Clear_Lables();
                lbl_rpwd.Text = "Password Not Match";
            }
            else
            {
                Clear_Lables();
                SqlCommand cmd = new SqlCommand("update UserData set password='" + txt_passwd.Text + "' where username='" + txt_user.Text + "' and mailid='" + txt_mail.Text + "'", con);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Password Successfully Changed");
                    this.Close();
                }
                else
                    MessageBox.Show("Password can't be Changed");
            }
            con.Close();
        }
        void Clear_Lables()
        {
            lbl_rpwd.Text = "";
            lbl_pwd.Text = "";
            lbl_mail.Text = "";
            lbl_user.Text = "";
        }
   }
}
