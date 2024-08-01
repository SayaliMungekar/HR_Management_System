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
    public partial class Recruitment : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\.net practicals\Project\Project\Project\HRMS.mdf;Integrated Security=True;Connect Timeout=30;");
        public Recruitment()
        {
            InitializeComponent();
        }

        private void Recruitment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMSDataSet1Recruit.Recruitment' table. You can move, or remove it, as needed.
            this.recruitmentTableAdapter.Fill(this.hRMSDataSet1Recruit.Recruitment);

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Recruitment values('" +txt_RID .Text + "','" + txt_Vacancy.Text + "','" + txt_AdvDate.Text + "''" + txt_Resumes.Text + "','" + txt_Interview.Text + "','" + txt_AttendedInterview.Text + "','" + txt_ShortList.Text + "','" + txt_PostID.Text + "')";
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
            cmd.CommandText = "select * from Recruitment";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            

            con.Close();
        }

    }
}
