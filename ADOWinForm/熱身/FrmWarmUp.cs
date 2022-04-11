using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOWinForm
{
    public partial class FrmWarmUp : Form
    {
        public FrmWarmUp()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello:" + textBox1.Text);
        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi:" + textBox1.Text);
        }

        private void btnSetProperty_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Blue;
            label1.ForeColor = Color.Green;
            label1.BorderStyle = BorderStyle.Fixed3D;
            btnHello.Visible = false;
        }

        private void btnReg3_Click(object sender, EventArgs e)
        {
            btn3.Click += btn3_Click;
            //btn3 += aaa;
           
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botton3 Click");
        }
        private void aaa(object sender, EventArgs e)
        {
            MessageBox.Show("aaa");
        }

        private void btnNew1_Click(object sender, EventArgs e)
        {
            FrmWarmUp f = new FrmWarmUp();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //static property --shared property
            MessageBox.Show(SystemInformation.ComputerName);
            //instance property
            button1.Text = "xxx";
            btn3.Text = "yyy";

            //set property
//            SystemInformation.ComputerName = "xxx";

//            嚴重性 程式碼 說明 專案  檔案 行   隱藏項目狀態
//錯誤  CS0200 無法指派為屬性或索引子 'SystemInformation.ComputerName'--
//                其為唯讀 ADOWinForm

            //get property
            string s = SystemInformation.ComputerName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //static method
            //預設檔案位置bin/Debug
            //File.Copy
            //true屬性表示覆蓋
            File.Copy("a.txt", "a1.txt", true);
            //instance method
            FileInfo f = new FileInfo("b.txt");
            f.CopyTo("b2.txt", true);
            //f 物件的屬性
            MessageBox.Show(f.FullName + "\n" + f.Extension + "\n" + f.CreationTime);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Text = "Hello," +textBox1.Text ;
            //錯誤Demo1
            //            Form1.Text = "Hello," + textBox1.Text;
            //            嚴重性 程式碼 說明 專案  檔案 行   隱藏項目狀態
            //錯誤  CS0120 需要有物件參考，才可使用非靜態欄位、方法或屬性 'Form.Text' ADOWinForm 

            //錯誤Demo2
            //Form1 f = new Form1();
            //f.Text = "Hello," + textBox1.Text;
            //f.Show();
            //不寫this預設代表此表單，但可讀性差
            Text = "HELLO," + this.textBox1.Text;
            //更有可讀性的寫法,都加this
            this.Text = "HELLO," + this.textBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //啟動表單關閉程式關閉(即使有new一個新表單)
            //Close();
            this.Close();
        }
    }
}
