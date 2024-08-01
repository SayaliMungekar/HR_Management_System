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
    public partial class Post : Form
    {
        SqlConnection con = new SqlConnection (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\.net practicals\Project\Project\Project\HRMS.mdf;Integrated Security=True;Connect Timeout=30;");
        public Post()
        {
            InitializeComponent();
        }

       

       
            private void btn_insert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Post values('" + txt_PostID.Text + "','" + txt_PostName.Text + "','" + combo_DepartmentID.Text + "','" + txt_AllotedPost.Text + "','" + txt_VacantPost.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("Record Inserted Successfully");
            
        }
            public void disp_data()
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Post";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }

            private void btn_delete_Click(object sender, EventArgs e)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Post where Post_ID='" + txt_PostID.Text + "'";
                cmd.ExecuteNonQuery();


                con.Close();
                disp_data();
                MessageBox.Show("Record Deleted Successfully");
            }
            private void Post_Load(object sender, EventArgs e)
            {
                // TODO: This line of code loads data into the 'postdataset.Post' table. You can move, or remove it, as needed.
                this.postTableAdapter.Fill(this.postdataset.Post);
                disp_data();
                // TODO: This line of code loads data into the 'hRMSDataSet.Post' table. You can move, or remove it, as needed.
                //this.postTableAdapter.Fill(this.hRMSDataSet.Post);
                // TODO: This line of code loads data into the 'departmentDataSet1.Department' table. You can move, or remove it, as needed.
               // this.departmentTableAdapter.Fill(this.departmentDataSet1.Department);

            }

           
            

            private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    txt_PostID.Text = row.Cells["txt_PostID"].Value.ToString();
                    txt_PostName.Text = row.Cells["txt_PostName"].Value.ToString();
                    combo_DepartmentID.Text = row.Cells["combo_DepartmentID"].Value.ToString();
                    txt_AllotedPost.Text = row.Cells["txt_AllotedPost"].Value.ToString();
                    txt_VacantPost.Text = row.Cells["txt_VacantPost"].Value.ToString();



                }
            }


    }
}

