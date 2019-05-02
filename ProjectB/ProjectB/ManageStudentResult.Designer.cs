namespace ProjectB
{
    partial class ManageStudentResult
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
            this.cbx_studentId = new System.Windows.Forms.ComboBox();
            this.cbx_componentId = new System.Windows.Forms.ComboBox();
            this.dtp_evaluationDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.studentResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet9 = new ProjectB.ProjectBDataSet9();
            this.studentResultTableAdapter = new ProjectB.ProjectBDataSet9TableAdapters.StudentResultTableAdapter();
            this.btn_back = new System.Windows.Forms.Button();
            this.cbx_assessmentTitle = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_rubricmeasurementlevel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_rubric = new System.Windows.Forms.ComboBox();
            this.cbx_id = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ObtainedMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_studentId
            // 
            this.cbx_studentId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx_studentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_studentId.FormattingEnabled = true;
            this.cbx_studentId.Location = new System.Drawing.Point(313, 98);
            this.cbx_studentId.Name = "cbx_studentId";
            this.cbx_studentId.Size = new System.Drawing.Size(200, 21);
            this.cbx_studentId.TabIndex = 0;
            // 
            // cbx_componentId
            // 
            this.cbx_componentId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx_componentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_componentId.FormattingEnabled = true;
            this.cbx_componentId.Location = new System.Drawing.Point(313, 152);
            this.cbx_componentId.Name = "cbx_componentId";
            this.cbx_componentId.Size = new System.Drawing.Size(200, 21);
            this.cbx_componentId.TabIndex = 1;
            this.cbx_componentId.SelectedIndexChanged += new System.EventHandler(this.cbx_componentId_SelectedIndexChanged);
            // 
            // dtp_evaluationDate
            // 
            this.dtp_evaluationDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_evaluationDate.Location = new System.Drawing.Point(313, 259);
            this.dtp_evaluationDate.Name = "dtp_evaluationDate";
            this.dtp_evaluationDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_evaluationDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student Id";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Assessment Component Id";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rubric Measurement Level";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Evaluation Date";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_add.Location = new System.Drawing.Point(542, 152);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // studentResultBindingSource
            // 
            this.studentResultBindingSource.DataMember = "StudentResult";
            this.studentResultBindingSource.DataSource = this.projectBDataSet9;
            // 
            // projectBDataSet9
            // 
            this.projectBDataSet9.DataSetName = "ProjectBDataSet9";
            this.projectBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentResultTableAdapter
            // 
            this.studentResultTableAdapter.ClearBeforeFill = true;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_back.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_back.Location = new System.Drawing.Point(542, 182);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // cbx_assessmentTitle
            // 
            this.cbx_assessmentTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx_assessmentTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_assessmentTitle.FormattingEnabled = true;
            this.cbx_assessmentTitle.Location = new System.Drawing.Point(313, 125);
            this.cbx_assessmentTitle.Name = "cbx_assessmentTitle";
            this.cbx_assessmentTitle.Size = new System.Drawing.Size(200, 21);
            this.cbx_assessmentTitle.TabIndex = 11;
            this.cbx_assessmentTitle.SelectedIndexChanged += new System.EventHandler(this.cbx_assessmentTitle_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Assessment Title";
            // 
            // cbx_rubricmeasurementlevel
            // 
            this.cbx_rubricmeasurementlevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx_rubricmeasurementlevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_rubricmeasurementlevel.FormattingEnabled = true;
            this.cbx_rubricmeasurementlevel.Location = new System.Drawing.Point(313, 204);
            this.cbx_rubricmeasurementlevel.Name = "cbx_rubricmeasurementlevel";
            this.cbx_rubricmeasurementlevel.Size = new System.Drawing.Size(200, 21);
            this.cbx_rubricmeasurementlevel.TabIndex = 13;
            this.cbx_rubricmeasurementlevel.SelectedIndexChanged += new System.EventHandler(this.cbx_rubricmeasurementlevel_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Rubric Details";
            // 
            // cbx_rubric
            // 
            this.cbx_rubric.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx_rubric.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_rubric.FormattingEnabled = true;
            this.cbx_rubric.Location = new System.Drawing.Point(313, 179);
            this.cbx_rubric.Name = "cbx_rubric";
            this.cbx_rubric.Size = new System.Drawing.Size(200, 21);
            this.cbx_rubric.TabIndex = 15;
            this.cbx_rubric.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbx_id
            // 
            this.cbx_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_id.FormattingEnabled = true;
            this.cbx_id.Location = new System.Drawing.Point(313, 233);
            this.cbx_id.Name = "cbx_id";
            this.cbx_id.Size = new System.Drawing.Size(200, 21);
            this.cbx_id.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Rubric Level Id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ObtainedMarks,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(12, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(716, 150);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ObtainedMarks
            // 
            this.ObtainedMarks.DataPropertyName = "ObtainedMarks";
            this.ObtainedMarks.HeaderText = "ObtainedMarks";
            this.ObtainedMarks.Name = "ObtainedMarks";
            this.ObtainedMarks.ToolTipText = "ObtainedMarks";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(542, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.54043F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.45956F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(716, 78);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(242, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "Manage Student Result";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Location = new System.Drawing.Point(19, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ManageStudentResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(740, 453);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbx_id);
            this.Controls.Add(this.cbx_rubric);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbx_rubricmeasurementlevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbx_assessmentTitle);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_evaluationDate);
            this.Controls.Add(this.cbx_componentId);
            this.Controls.Add(this.cbx_studentId);
            this.Name = "ManageStudentResult";
            this.Text = "ManageStudentResult";
            this.Load += new System.EventHandler(this.ManageStudentResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_studentId;
        private System.Windows.Forms.ComboBox cbx_componentId;
        private System.Windows.Forms.DateTimePicker dtp_evaluationDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_add;
        private ProjectBDataSet9 projectBDataSet9;
        private System.Windows.Forms.BindingSource studentResultBindingSource;
        private ProjectBDataSet9TableAdapters.StudentResultTableAdapter studentResultTableAdapter;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox cbx_assessmentTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_rubricmeasurementlevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_rubric;
        private System.Windows.Forms.ComboBox cbx_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObtainedMarks;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
    }
}