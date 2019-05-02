namespace ProjectB
{
    partial class ManageAssessment
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
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_marks = new System.Windows.Forms.TextBox();
            this.txt_weightage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalWeightageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.assessmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet6 = new ProjectB.ProjectBDataSet6();
            this.assessmentTableAdapter = new ProjectB.ProjectBDataSet6TableAdapters.AssessmentTableAdapter();
            this.cmd_add = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmd_show = new System.Windows.Forms.Button();
            this.cmd_update = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_title
            // 
            this.txt_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_title.Location = new System.Drawing.Point(265, 123);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(187, 20);
            this.txt_title.TabIndex = 1;
            // 
            // txt_marks
            // 
            this.txt_marks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_marks.Location = new System.Drawing.Point(265, 149);
            this.txt_marks.Name = "txt_marks";
            this.txt_marks.Size = new System.Drawing.Size(187, 20);
            this.txt_marks.TabIndex = 2;
            this.txt_marks.TextChanged += new System.EventHandler(this.txt_marks_TextChanged);
            // 
            // txt_weightage
            // 
            this.txt_weightage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_weightage.Location = new System.Drawing.Point(265, 175);
            this.txt_weightage.Name = "txt_weightage";
            this.txt_weightage.Size = new System.Drawing.Size(187, 20);
            this.txt_weightage.TabIndex = 3;
            this.txt_weightage.TextChanged += new System.EventHandler(this.txt_weightage_TextChanged);
            this.txt_weightage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NMBR_ONLY);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Assessment Title";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Marks";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Weightage";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.totalMarksDataGridViewTextBoxColumn,
            this.totalWeightageDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.dataGridView1.DataSource = this.assessmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(605, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            // 
            // totalMarksDataGridViewTextBoxColumn
            // 
            this.totalMarksDataGridViewTextBoxColumn.DataPropertyName = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn.HeaderText = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn.Name = "totalMarksDataGridViewTextBoxColumn";
            // 
            // totalWeightageDataGridViewTextBoxColumn
            // 
            this.totalWeightageDataGridViewTextBoxColumn.DataPropertyName = "TotalWeightage";
            this.totalWeightageDataGridViewTextBoxColumn.HeaderText = "TotalWeightage";
            this.totalWeightageDataGridViewTextBoxColumn.Name = "totalWeightageDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Edit";
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // assessmentBindingSource
            // 
            this.assessmentBindingSource.DataMember = "Assessment";
            this.assessmentBindingSource.DataSource = this.projectBDataSet6;
            // 
            // projectBDataSet6
            // 
            this.projectBDataSet6.DataSetName = "ProjectBDataSet6";
            this.projectBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assessmentTableAdapter
            // 
            this.assessmentTableAdapter.ClearBeforeFill = true;
            // 
            // cmd_add
            // 
            this.cmd_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmd_add.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmd_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmd_add.Location = new System.Drawing.Point(176, 223);
            this.cmd_add.Name = "cmd_add";
            this.cmd_add.Size = new System.Drawing.Size(75, 23);
            this.cmd_add.TabIndex = 9;
            this.cmd_add.Text = "Add";
            this.cmd_add.UseVisualStyleBackColor = false;
            this.cmd_add.Click += new System.EventHandler(this.cmd_add_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmd_show
            // 
            this.cmd_show.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmd_show.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmd_show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmd_show.Location = new System.Drawing.Point(377, 223);
            this.cmd_show.Name = "cmd_show";
            this.cmd_show.Size = new System.Drawing.Size(75, 23);
            this.cmd_show.TabIndex = 10;
            this.cmd_show.Text = "Show";
            this.cmd_show.UseVisualStyleBackColor = false;
            this.cmd_show.Click += new System.EventHandler(this.cmd_show_Click);
            // 
            // cmd_update
            // 
            this.cmd_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmd_update.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmd_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmd_update.Location = new System.Drawing.Point(277, 223);
            this.cmd_update.Name = "cmd_update";
            this.cmd_update.Size = new System.Drawing.Size(75, 23);
            this.cmd_update.TabIndex = 11;
            this.cmd_update.Text = "Update";
            this.cmd_update.UseVisualStyleBackColor = false;
            this.cmd_update.Click += new System.EventHandler(this.cmd_update_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(493, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_back.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_back.Location = new System.Drawing.Point(9, 27);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.54043F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.45956F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_back, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(605, 78);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Assessment";
            // 
            // ManageAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(629, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmd_update);
            this.Controls.Add(this.cmd_show);
            this.Controls.Add(this.cmd_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_weightage);
            this.Controls.Add(this.txt_marks);
            this.Controls.Add(this.txt_title);
            this.Name = "ManageAssessment";
            this.Text = "ManageAssessment";
            this.Load += new System.EventHandler(this.ManageAssessment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_marks;
        private System.Windows.Forms.TextBox txt_weightage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectBDataSet6 projectBDataSet6;
        private System.Windows.Forms.BindingSource assessmentBindingSource;
        private ProjectBDataSet6TableAdapters.AssessmentTableAdapter assessmentTableAdapter;
        private System.Windows.Forms.Button cmd_add;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalWeightageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button cmd_show;
        private System.Windows.Forms.Button cmd_update;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
    }
}