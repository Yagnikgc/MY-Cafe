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
    public partial class UserData : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\Project\MY C@fe\MY C@fe\Register.mdf;Integrated Security=True;User Instance=True");
        public UserData()
        {
            InitializeComponent();
        }

        private void UserData_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter("select * from UserData",con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
