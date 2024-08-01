namespace Project
{
    partial class Department
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
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.hRMSDataSet = new Project.HRMSDataSet();
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.departmentDataSet1 = new Project.DepartmentDataSet1();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentDataSet = new Project.DepartmentDataSet();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.departmentTableAdapter = new Project.DepartmentDataSetTableAdapters.DepartmentTableAdapter();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Location = new System.Windows.Forms.TextBox();
            this.departmentTableAdapter1 = new Project.DepartmentDataSet1TableAdapters.DepartmentTableAdapter();
            this.departmentTableAdapter2 = new Project.HRMSDataSetTableAdapters.DepartmentTableAdapter();
            this.fKPostToDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postTableAdapter = new Project.HRMSDataSetTableAdapters.PostTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.departmentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.deptDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deptDataSet1 = new Project.DeptDataSet1();
            this.departmentTableAdapter3 = new Project.DeptDataSet1TableAdapters.DepartmentTableAdapter();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hRMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPostToDepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department Location";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(325, 70);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 3;
            // 
            // hRMSDataSet
            // 
            this.hRMSDataSet.DataSetName = "HRMSDataSet";
            this.hRMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataMember = "Department";
            this.departmentBindingSource1.DataSource = this.departmentDataSet1;
            // 
            // departmentDataSet1
            // 
            this.departmentDataSet1.DataSetName = "DepartmentDataSet1";
            this.departmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.departmentDataSet;
            // 
            // departmentDataSet
            // 
            this.departmentDataSet.DataSetName = "DepartmentDataSet";
            this.departmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_insert
            // 
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(135, 259);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(114, 45);
            this.btn_insert.TabIndex = 6;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(283, 259);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(118, 45);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(325, 126);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 10;
            // 
            // txt_Location
            // 
            this.txt_Location.Location = new System.Drawing.Point(330, 179);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Size = new System.Drawing.Size(100, 20);
            this.txt_Location.TabIndex = 11;
            // 
            // departmentTableAdapter1
            // 
            this.departmentTableAdapter1.ClearBeforeFill = true;
            // 
            // departmentTableAdapter2
            // 
            this.departmentTableAdapter2.ClearBeforeFill = true;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentIDDataGridViewTextBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn,
            this.departmentLocationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.departmentBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(501, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // departmentBindingSource2
            // 
            this.departmentBindingSource2.DataMember = "Department";
            this.departmentBindingSource2.DataSource = this.deptDataSet1BindingSource;
            // 
            // deptDataSet1BindingSource
            // 
            this.deptDataSet1BindingSource.DataSource = this.deptDataSet1;
            this.deptDataSet1BindingSource.Position = 0;
            // 
            // deptDataSet1
            // 
            this.deptDataSet1.DataSetName = "DeptDataSet1";
            this.deptDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter3
            // 
            this.departmentTableAdapter3.ClearBeforeFill = true;
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "Department_ID";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "Department_ID";
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "Department_Name";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "Department_Name";
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            // 
            // departmentLocationDataGridViewTextBoxColumn
            // 
            this.departmentLocationDataGridViewTextBoxColumn.DataPropertyName = "Department_Location";
            this.departmentLocationDataGridViewTextBoxColumn.HeaderText = "Department_Location";
            this.departmentLocationDataGridViewTextBoxColumn.Name = "departmentLocationDataGridViewTextBoxColumn";
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 397);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_Location);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Department";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hRMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPostToDepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_delete;
        private DepartmentDataSet departmentDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DepartmentDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Location;
        private DepartmentDataSet1 departmentDataSet1;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
        private DepartmentDataSet1TableAdapters.DepartmentTableAdapter departmentTableAdapter1;
        private HRMSDataSet hRMSDataSet;
        private HRMSDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter2;
        private System.Windows.Forms.BindingSource fKPostToDepartmentBindingSource;
        private HRMSDataSetTableAdapters.PostTableAdapter postTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource deptDataSet1BindingSource;
        private DeptDataSet1 deptDataSet1;
        private System.Windows.Forms.BindingSource departmentBindingSource2;
        private DeptDataSet1TableAdapters.DepartmentTableAdapter departmentTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentLocationDataGridViewTextBoxColumn;
    }
}