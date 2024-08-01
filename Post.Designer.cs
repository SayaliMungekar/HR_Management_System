namespace Project
{
    partial class Post
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
            this.btn_insert = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_PostName = new System.Windows.Forms.TextBox();
            this.txt_AllotedPost = new System.Windows.Forms.TextBox();
            this.txt_VacantPost = new System.Windows.Forms.TextBox();
            this.combo_DepartmentID = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentDataSet1 = new Project.DepartmentDataSet1();
            this.txt_PostID = new System.Windows.Forms.TextBox();
            this.departmentTableAdapter = new Project.DepartmentDataSet1TableAdapters.DepartmentTableAdapter();
            this.btn_delete = new System.Windows.Forms.Button();
            this.hRMSDataSet = new Project.HRMSDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.postdataset = new Project.postdataset();
            this.postdatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postTableAdapter = new Project.postdatasetTableAdapters.PostTableAdapter();
            this.postIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allotedNumberofPostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacantNumberofPostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postdatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Post ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Post Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Department ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Alloted Number of Post";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vacant Number of Post";
            // 
            // btn_insert
            // 
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(103, 360);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(100, 46);
            this.btn_insert.TabIndex = 6;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(255, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_PostName
            // 
            this.txt_PostName.Location = new System.Drawing.Point(363, 116);
            this.txt_PostName.Name = "txt_PostName";
            this.txt_PostName.Size = new System.Drawing.Size(158, 20);
            this.txt_PostName.TabIndex = 9;
            // 
            // txt_AllotedPost
            // 
            this.txt_AllotedPost.Location = new System.Drawing.Point(363, 228);
            this.txt_AllotedPost.Name = "txt_AllotedPost";
            this.txt_AllotedPost.Size = new System.Drawing.Size(158, 20);
            this.txt_AllotedPost.TabIndex = 11;
            // 
            // txt_VacantPost
            // 
            this.txt_VacantPost.Location = new System.Drawing.Point(363, 294);
            this.txt_VacantPost.Name = "txt_VacantPost";
            this.txt_VacantPost.Size = new System.Drawing.Size(158, 20);
            this.txt_VacantPost.TabIndex = 12;
            // 
            // combo_DepartmentID
            // 
            this.combo_DepartmentID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "Department_ID", true));
            this.combo_DepartmentID.FormattingEnabled = true;
            this.combo_DepartmentID.Location = new System.Drawing.Point(361, 176);
            this.combo_DepartmentID.Name = "combo_DepartmentID";
            this.combo_DepartmentID.Size = new System.Drawing.Size(160, 21);
            this.combo_DepartmentID.TabIndex = 14;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.departmentDataSet1;
            // 
            // departmentDataSet1
            // 
            this.departmentDataSet1.DataSetName = "DepartmentDataSet1";
            this.departmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_PostID
            // 
            this.txt_PostID.Location = new System.Drawing.Point(361, 48);
            this.txt_PostID.Name = "txt_PostID";
            this.txt_PostID.Size = new System.Drawing.Size(160, 20);
            this.txt_PostID.TabIndex = 15;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(407, 360);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(130, 46);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // hRMSDataSet
            // 
            this.hRMSDataSet.DataSetName = "HRMSDataSet";
            this.hRMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.postIDDataGridViewTextBoxColumn,
            this.postNameDataGridViewTextBoxColumn,
            this.departmentIDDataGridViewTextBoxColumn,
            this.allotedNumberofPostDataGridViewTextBoxColumn,
            this.vacantNumberofPostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.postBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(579, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // postdataset
            // 
            this.postdataset.DataSetName = "postdataset";
            this.postdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postdatasetBindingSource
            // 
            this.postdatasetBindingSource.DataSource = this.postdataset;
            this.postdatasetBindingSource.Position = 0;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "Post";
            this.postBindingSource.DataSource = this.postdatasetBindingSource;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // postIDDataGridViewTextBoxColumn
            // 
            this.postIDDataGridViewTextBoxColumn.DataPropertyName = "Post_ID";
            this.postIDDataGridViewTextBoxColumn.HeaderText = "Post_ID";
            this.postIDDataGridViewTextBoxColumn.Name = "postIDDataGridViewTextBoxColumn";
            // 
            // postNameDataGridViewTextBoxColumn
            // 
            this.postNameDataGridViewTextBoxColumn.DataPropertyName = "Post_Name";
            this.postNameDataGridViewTextBoxColumn.HeaderText = "Post_Name";
            this.postNameDataGridViewTextBoxColumn.Name = "postNameDataGridViewTextBoxColumn";
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "Department_ID";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "Department_ID";
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            // 
            // allotedNumberofPostDataGridViewTextBoxColumn
            // 
            this.allotedNumberofPostDataGridViewTextBoxColumn.DataPropertyName = "Alloted_Number_of_Post";
            this.allotedNumberofPostDataGridViewTextBoxColumn.HeaderText = "Alloted_Number_of_Post";
            this.allotedNumberofPostDataGridViewTextBoxColumn.Name = "allotedNumberofPostDataGridViewTextBoxColumn";
            // 
            // vacantNumberofPostDataGridViewTextBoxColumn
            // 
            this.vacantNumberofPostDataGridViewTextBoxColumn.DataPropertyName = "Vacant_Number_of_Post";
            this.vacantNumberofPostDataGridViewTextBoxColumn.HeaderText = "Vacant_Number_of_Post";
            this.vacantNumberofPostDataGridViewTextBoxColumn.Name = "vacantNumberofPostDataGridViewTextBoxColumn";
            // 
            // Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 467);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_PostID);
            this.Controls.Add(this.combo_DepartmentID);
            this.Controls.Add(this.txt_VacantPost);
            this.Controls.Add(this.txt_AllotedPost);
            this.Controls.Add(this.txt_PostName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Post";
            this.Text = "Post";
            this.Load += new System.EventHandler(this.Post_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postdatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_PostName;
        private System.Windows.Forms.TextBox txt_AllotedPost;
        private System.Windows.Forms.TextBox txt_VacantPost;
        private System.Windows.Forms.ComboBox combo_DepartmentID;
        private System.Windows.Forms.TextBox txt_PostID;
        private DepartmentDataSet1 departmentDataSet1;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DepartmentDataSet1TableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.Button btn_delete;
        private HRMSDataSet hRMSDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource postdatasetBindingSource;
        private postdataset postdataset;
        private System.Windows.Forms.BindingSource postBindingSource;
        private postdatasetTableAdapters.PostTableAdapter postTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn postIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allotedNumberofPostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacantNumberofPostDataGridViewTextBoxColumn;
    }
}