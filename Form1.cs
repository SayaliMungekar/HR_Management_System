using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\.net practicals\Project\Project\Project\HRMS.mdf;Integrated Security=True;Connect Timeout=30;"); 
            SqlDataAdapter sda=new SqlDataAdapter("select * from Login WHERE UserName='"+textBox1.Text+"'AND Password='"+textBox2.Text+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (textBox1.Text == "admin" && textBox2.Text == "123456")
            {
                new HomePage().Show();
                
                this.Hide();

            }
            else
            {
              MessageBox.Show("UserName or Password is incorect") ;
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMSDataSet.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.hRMSDataSet.Login);
            // TODO: This line of code loads data into the 'loginDB1DataSet.Table' table. You can move, or remove it, as needed.
            //this.tableTableAdapter.Fill(this.loginDB1DataSet.Table);

        }

       // private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
       // {

       // }

        private void tableBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        }
    }

