using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQL_LocalDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\DB1.mdf; Integrated Security = True");

        private  bool OpenConn()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(OpenConn())
            {
                MessageBox.Show("OK");
            }
        }
    }
}
