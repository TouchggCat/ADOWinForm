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
            //this.tabControl1.Dock = DockStyle.Fill;
            this.tabControl1.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Step 1 : SqlConnection
            //Step 2 : SqlCommand
            //Step 3 : SqlDataReader
            //Step 4 : UI Control
            //伺服器總管>資料連接>屬性>連接字串(Key=value)
            //使用try/catch保護程式碼的例外情形
            
            SqlConnection conn=null;
            //為了給finally使用，在try外面宣告，並指派null
            try
            {
                //SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn =new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();
                SqlCommand command = new SqlCommand("select*from Products",conn);
                SqlDataReader dataReader = command.ExecuteReader();
                //讀第一筆資料
                //dataReader.Read();
                //MessageBox.Show(dataReader["ProductName"].ToString());
                //SqlDataReader.Read為布林值
                this.listBox1.Items.Clear();
                while (dataReader.Read())
                {
                    //Add(object 名)
                    //this.listBox1.Items.Add(dataReader["ProductName"] + dataReader["UnitPrice"].ToString());
                    //字串格式化
                    string s = $"{dataReader["ProductName"],-40} - {dataReader["UnitPrice"]:c2}";
                    this.listBox1.Items.Add(s);
                }
     
                MessageBox.Show("successful");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Step 1 : SqlConnection
            //Step 2 : SqlDataAdapter
            //Step 3 : DataSet         -In memory DB
            //Step 4 : UI Control     -DataGridView-Table
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("select*from Products", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("select*from Categories", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=AdventureWorks;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter adapter = new SqlDataAdapter("select*from [Production].[ProductPhoto]", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            //單價>30
            SqlDataAdapter adapter = new SqlDataAdapter("select*from Products where Unitprice>30", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            this.dataGridView2.DataSource=this.nwDataSet1.Products;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.categoriesTableAdapter1.Fill(this.nwDataSet1.Categories);
            this.dataGridView2.DataSource = this.nwDataSet1.Categories;
        }
    }
}
