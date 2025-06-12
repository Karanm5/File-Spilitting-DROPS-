using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace FileSplitter
{
    public partial class Admin : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cloud"].ConnectionString);
        public Admin()
        {
            InitializeComponent();
            showUser();
        }
        public void showUser()
        {
            con.Open();
            string q1 = "select ID,username,Emailid,contactno from Registration";
            DataTable dt1 = new DataTable();
            SqlDataAdapter dp1 = new SqlDataAdapter(q1, con);
            dp1.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt1;
            }
            con.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home hm = new home();
            hm.Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
