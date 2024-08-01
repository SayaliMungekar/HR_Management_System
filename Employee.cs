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
    public partial class Employee : Form
    {
        
        public Employee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO EMPLOYEE_tABLE VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + dateTimePicker2.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insert Data Successsfully");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Employee_Table SET Employee_Name='" + textBox1.Text + "',Address='" + textBox2.Text + "',Phone Number='" + textBox3.Text + "',Email Address='" + textBox4.Text + "' Where Employee_Id='" + textBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update Data Successsfully");
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE Employee_Table WHERE Employee_Id='" + textBox6.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Data Successsfully");
            con.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox6.Text = textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + dateTimePicker2.Text + dateTimePicker1.Text + textBox8.Text + textBox9.Text + "";
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

    }
}
