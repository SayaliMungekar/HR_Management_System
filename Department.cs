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
    public partial class Department : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\.net practicals\Project\Project\Project\HRMS.mdf;Integrated Security=True;Connect Timeout=30;");
        public Department()
        {
            InitializeComponent();
        }



        private void btn_insert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Department values('" + txt_ID.Text + "','" + txt_Name.Text + "','" + txt_Location.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("Record Inserted Successfully");

            //SqlConnection con = new SqlConnection(@"Data source=(LocalDB)\v11.0;AttachDbFilename=E:\.net practicals\Project\Project\Project\Department.mdf;Integrated Security=True;Connect Timeout=30;");
            //con.Open();
            //SqlDataAdapter sda =new SqlDataAdapter("insert into Department values('"+txtID.Text+"','"+txtName.Text+"','"+txtLocation.Text+"')",con);
            //DataTable dt = new DataTable();
            // sda.Fill(dt);
            // dataGridView1.DataSource = dt;
            // disp_data();
            // MessageBox.Show("Data Inserted Successfully.");
            // con.Close();
        }

        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Department";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            //dataGridViewdept.DataSource = dt;
            dataGridView1.DataSource = dt;
            

            con.Close();



            // SqlConnection con = new SqlConnection(@"Data source=(LocalDB)\v11.0;AttachDbFilename=E:\.net practicals\Project\Project\Project\Department.mdf;Integrated Security=True;Connect Timeout=30;");
            // con.Open();
            // SqlDataAdapter sda = new SqlDataAdapter ("select * from Department",con);
            // DataTable dt = new DataTable();
            // sda.Fill(dt);
            // dataGridView1.DataSource = dt;


            // con.Close();
        }




        private void btn_delete_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Department where Department_ID='" + txt_ID.Text + "'";
            cmd.ExecuteNonQuery();


            con.Close();
            disp_data();
            MessageBox.Show("Record Deleted Successfully");
            //SqlConnection con = new SqlConnection(@"Data source=(LocalDB)\v11.0;AttachDbFilename=E:\.net practicals\Project\Project\Project\Department.mdf;Integrated Security=True;Connect Timeout=30;");
            // con.Open();
            // SqlDataAdapter sda = new SqlDataAdapter("Delete from Department where Department_ID='" + txtID.Text + "' ", con);
            // DataTable dt = new DataTable();
            // sda.Fill(dt);
            //dataGridView1.DataSource = dt;
            //disp_data();
            // MessageBox.Show("Data Deleted Successfully.");
            // con.Close();
        }

        private void Department_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'deptDataSet1.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter3.Fill(this.deptDataSet1.Department);
            // TODO: This line of code loads data into the 'hRMSDataSet.Post' table. You can move, or remove it, as needed.
            //this.postTableAdapter.Fill(this.hRMSDataSet.Post);
            // TODO: This line of code loads data into the 'hRMSDataSet.Department' table. You can move, or remove it, as needed.
            // this.departmentTableAdapter2.Fill(this.hRMSDataSet.Department);
            disp_data();
            // TODO: This line of code loads data into the 'departmentDataSet1.Department' table. You can move, or remove it, as needed.
            //this.departmentTableAdapter1.Fill(this.departmentDataSet1.Department);
            // TODO: This line of code loads data into the 'departmentDataSet.Department' table. You can move, or remove it, as needed.
            //this.departmentTableAdapter.Fill(this.departmentDataSet.Department);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txt_ID.Text = row.Cells["Department_ID"].Value.ToString();
                txt_Name.Text = row.Cells["Department_Name"].Value.ToString();
                txt_Location.Text = row.Cells["Department_Location"].Value.ToString();
                
                
            }



        }



    }
}


