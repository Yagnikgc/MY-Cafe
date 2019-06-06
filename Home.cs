using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MY_C_fe
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            WelCome home = new WelCome();
            String totalTime = home.getTime();
            MessageBox.Show("Time Used : " + home.getTime());
        }
    }
}
