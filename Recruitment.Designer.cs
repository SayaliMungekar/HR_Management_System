namespace Project
{
    partial class Recruitment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_RID = new System.Windows.Forms.TextBox();
            this.txt_Vacancy = new System.Windows.Forms.TextBox();
            this.txt_AdvDate = new System.Windows.Forms.TextBox();
            this.txt_Resumes = new System.Windows.Forms.TextBox();
            this.txt_Interview = new System.Windows.Forms.TextBox();
            this.txt_AttendedInterview = new System.Windows.Forms.TextBox();
            this.txt_ShortList = new System.Windows.Forms.TextBox();
            this.txt_PostID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hRMSDataSet1Recruit = new Project.HRMSDataSet1Recruit();
            this.recruitmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recruitmentTableAdapter = new Project.HRMSDataSet1RecruitTableAdapters.RecruitmentTableAdapter();
            this.recruitmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofJOBVacancyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofAdvertisementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofResumesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofInterviewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidateattendedinterviewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortListCandidateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMSDataSet1Recruit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recruitmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recruitment ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of JOB Vacancy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Advertisement Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Resumes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Interview Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(397, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Number of Candidates Attended Interview";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Number of ShortList Candidate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Post ID";
            // 
            // txt_RID
            // 
            this.txt_RID.Location = new System.Drawing.Point(494, 28);
            this.txt_RID.Name = "txt_RID";
            this.txt_RID.Size = new System.Drawing.Size(156, 20);
            this.txt_RID.TabIndex = 8;
            // 
            // txt_Vacancy
            // 
            this.txt_Vacancy.Location = new System.Drawing.Point(494, 82);
            this.txt_Vacancy.Name = "txt_Vacancy";
            this.txt_Vacancy.Size = new System.Drawing.Size(156, 20);
            this.txt_Vacancy.TabIndex = 9;
            // 
            // txt_AdvDate
            // 
            this.txt_AdvDate.Location = new System.Drawing.Point(494, 134);
            this.txt_AdvDate.Name = "txt_AdvDate";
            this.txt_AdvDate.Size = new System.Drawing.Size(156, 20);
            this.txt_AdvDate.TabIndex = 10;
            // 
            // txt_Resumes
            // 
            this.txt_Resumes.Location = new System.Drawing.Point(494, 189);
            this.txt_Resumes.Name = "txt_Resumes";
            this.txt_Resumes.Size = new System.Drawing.Size(156, 20);
            this.txt_Resumes.TabIndex = 11;
            // 
            // txt_Interview
            // 
            this.txt_Interview.Location = new System.Drawing.Point(494, 251);
            this.txt_Interview.Name = "txt_Interview";
            this.txt_Interview.Size = new System.Drawing.Size(156, 20);
            this.txt_Interview.TabIndex = 12;
            // 
            // txt_AttendedInterview
            // 
            this.txt_AttendedInterview.Location = new System.Drawing.Point(494, 301);
            this.txt_AttendedInterview.Name = "txt_AttendedInterview";
            this.txt_AttendedInterview.Size = new System.Drawing.Size(156, 20);
            this.txt_AttendedInterview.TabIndex = 13;
            // 
            // txt_ShortList
            // 
            this.txt_ShortList.Location = new System.Drawing.Point(494, 347);
            this.txt_ShortList.Name = "txt_ShortList";
            this.txt_ShortList.Size = new System.Drawing.Size(156, 20);
            this.txt_ShortList.TabIndex = 14;
            // 
            // txt_PostID
            // 
            this.txt_PostID.Location = new System.Drawing.Point(494, 392);
            this.txt_PostID.Name = "txt_PostID";
            this.txt_PostID.Size = new System.Drawing.Size(156, 20);
            this.txt_PostID.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(745, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 57);
            this.button1.TabIndex = 16;
            this.button1.Text = "ADD Employee";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_insert
            // 
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(52, 437);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(116, 39);
            this.btn_insert.TabIndex = 17;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recruitmentIDDataGridViewTextBoxColumn,
            this.numberofJOBVacancyDataGridViewTextBoxColumn,
            this.dateofAdvertisementDataGridViewTextBoxColumn,
            this.numberofResumesDataGridViewTextBoxColumn,
            this.dateofInterviewDataGridViewTextBoxColumn,
            this.candidateattendedinterviewDataGridViewTextBoxColumn,
            this.shortListCandidateDataGridViewTextBoxColumn,
            this.postIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.recruitmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(674, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(166, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // hRMSDataSet1Recruit
            // 
            this.hRMSDataSet1Recruit.DataSetName = "HRMSDataSet1Recruit";
            this.hRMSDataSet1Recruit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recruitmentBindingSource
            // 
            this.recruitmentBindingSource.DataMember = "Recruitment";
            this.recruitmentBindingSource.DataSource = this.hRMSDataSet1Recruit;
            // 
            // recruitmentTableAdapter
            // 
            this.recruitmentTableAdapter.ClearBeforeFill = true;
            // 
            // recruitmentIDDataGridViewTextBoxColumn
            // 
            this.recruitmentIDDataGridViewTextBoxColumn.DataPropertyName = "Recruitment_ID";
            this.recruitmentIDDataGridViewTextBoxColumn.HeaderText = "Recruitment_ID";
            this.recruitmentIDDataGridViewTextBoxColumn.Name = "recruitmentIDDataGridViewTextBoxColumn";
            // 
            // numberofJOBVacancyDataGridViewTextBoxColumn
            // 
            this.numberofJOBVacancyDataGridViewTextBoxColumn.DataPropertyName = "Number_of_JOB_Vacancy";
            this.numberofJOBVacancyDataGridViewTextBoxColumn.HeaderText = "Number_of_JOB_Vacancy";
            this.numberofJOBVacancyDataGridViewTextBoxColumn.Name = "numberofJOBVacancyDataGridViewTextBoxColumn";
            // 
            // dateofAdvertisementDataGridViewTextBoxColumn
            // 
            this.dateofAdvertisementDataGridViewTextBoxColumn.DataPropertyName = "Date_of_Advertisement";
            this.dateofAdvertisementDataGridViewTextBoxColumn.HeaderText = "Date_of_Advertisement";
            this.dateofAdvertisementDataGridViewTextBoxColumn.Name = "dateofAdvertisementDataGridViewTextBoxColumn";
            // 
            // numberofResumesDataGridViewTextBoxColumn
            // 
            this.numberofResumesDataGridViewTextBoxColumn.DataPropertyName = "Number_of_Resumes";
            this.numberofResumesDataGridViewTextBoxColumn.HeaderText = "Number_of_Resumes";
            this.numberofResumesDataGridViewTextBoxColumn.Name = "numberofResumesDataGridViewTextBoxColumn";
            // 
            // dateofInterviewDataGridViewTextBoxColumn
            // 
            this.dateofInterviewDataGridViewTextBoxColumn.DataPropertyName = "Date_of_Interview";
            this.dateofInterviewDataGridViewTextBoxColumn.HeaderText = "Date_of_Interview";
            this.dateofInterviewDataGridViewTextBoxColumn.Name = "dateofInterviewDataGridViewTextBoxColumn";
            // 
            // candidateattendedinterviewDataGridViewTextBoxColumn
            // 
            this.candidateattendedinterviewDataGridViewTextBoxColumn.DataPropertyName = "Candidate_attended_interview";
            this.candidateattendedinterviewDataGridViewTextBoxColumn.HeaderText = "Candidate_attended_interview";
            this.candidateattendedinterviewDataGridViewTextBoxColumn.Name = "candidateattendedinterviewDataGridViewTextBoxColumn";
            // 
            // shortListCandidateDataGridViewTextBoxColumn
            // 
            this.shortListCandidateDataGridViewTextBoxColumn.DataPropertyName = "ShortList_Candidate";
            this.shortListCandidateDataGridViewTextBoxColumn.HeaderText = "ShortList_Candidate";
            this.shortListCandidateDataGridViewTextBoxColumn.Name = "shortListCandidateDataGridViewTextBoxColumn";
            // 
            // postIDDataGridViewTextBoxColumn
            // 
            this.postIDDataGridViewTextBoxColumn.DataPropertyName = "Post_ID";
            this.postIDDataGridViewTextBoxColumn.HeaderText = "Post_ID";
            this.postIDDataGridViewTextBoxColumn.Name = "postIDDataGridViewTextBoxColumn";
            // 
            // Recruitment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 479);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_PostID);
            this.Controls.Add(this.txt_ShortList);
            this.Controls.Add(this.txt_AttendedInterview);
            this.Controls.Add(this.txt_Interview);
            this.Controls.Add(this.txt_Resumes);
            this.Controls.Add(this.txt_AdvDate);
            this.Controls.Add(this.txt_Vacancy);
            this.Controls.Add(this.txt_RID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Recruitment";
            this.Text = "Recruitment";
            this.Load += new System.EventHandler(this.Recruitment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMSDataSet1Recruit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recruitmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_RID;
        private System.Windows.Forms.TextBox txt_Vacancy;
        private System.Windows.Forms.TextBox txt_AdvDate;
        private System.Windows.Forms.TextBox txt_Resumes;
        private System.Windows.Forms.TextBox txt_Interview;
        private System.Windows.Forms.TextBox txt_AttendedInterview;
        private System.Windows.Forms.TextBox txt_ShortList;
        private System.Windows.Forms.TextBox txt_PostID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HRMSDataSet1Recruit hRMSDataSet1Recruit;
        private System.Windows.Forms.BindingSource recruitmentBindingSource;
        private HRMSDataSet1RecruitTableAdapters.RecruitmentTableAdapter recruitmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recruitmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofJOBVacancyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofAdvertisementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofResumesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofInterviewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidateattendedinterviewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortListCandidateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postIDDataGridViewTextBoxColumn;
    }
}