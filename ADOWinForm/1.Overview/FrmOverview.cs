using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ADOWinForm._1.Overview
{
    public partial class FrmOverview : Form
    {
        public FrmOverview()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Step 1 : SqlConnection
            //Step 2 : SqlCommand
            //Step 3 : SqlDataReader
            //Step 4 : UI Control
            //伺服器總管>資料連接>屬性>連接字串(Key=value)
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            conn.Open();

            conn.Close();
        }
    }
}
