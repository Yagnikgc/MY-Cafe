using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MY_C_fe
{
    public partial class Hostory : Form
    {
        public Hostory()
        {
            InitializeComponent();
        }

        private void btn_chrome_Click(object sender, EventArgs e)
        {
            string google = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Google\Chrome\User Data\Default\History";
            SQLiteConnection cn = new SQLiteConnection("Data Source=" + google + ";Version=3;New=False;Compress=True;");
            cn.Open();
            SQLiteDataAdapter sd = new SQLiteDataAdapter("select url,title,visit_count,last_visit_time from urls order by last_visit_time desc",cn);
            DataSet ds = new DataSet();
            sd.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            cn.Clone();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Safari_Click(object sender, EventArgs e)
        {
            string apple = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Apple Computer\Safari\WebpageIcons.db";
            SQLiteConnection cn = new SQLiteConnection("Data Source=" + apple + ";Version=3;New=False;Compress=True;");
            cn.Open();
            SQLiteDataAdapter sd = new SQLiteDataAdapter("select * from PageURL", cn);
            DataSet ds = new DataSet();
            sd.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            cn.Clone();
        }

        private void btn_Mozila_Click(object sender, EventArgs e)
        {
            string mozilla = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Mozilla\Firefox\Profiles\t2c9q1nj.default\places.sqlite";
            SQLiteConnection cn = new SQLiteConnection("Data Source=" + mozilla + ";Version=3;New=False;Compress=True;");
            cn.Open();
            SQLiteDataAdapter sd = new SQLiteDataAdapter("select * from moz_places order by last_visit_date desc", cn);
            DataSet ds = new DataSet();
            sd.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            cn.Clone();
        }

        private void btn_Opera_Click(object sender, EventArgs e)
        {
            string opera = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Opera Software\Opera Stable\History";
            SQLiteConnection cn = new SQLiteConnection("Data Source=" + opera + ";Version=3;New=False;Compress=True;");
            cn.Open();
            SQLiteDataAdapter sd = new SQLiteDataAdapter("select * from urls order by last_visit_time desc ",cn);
            DataTable ds = new DataTable();
            sd.Fill(ds);
            dataGridView1.DataSource = ds;
            cn.Clone();
        }
    }
}
