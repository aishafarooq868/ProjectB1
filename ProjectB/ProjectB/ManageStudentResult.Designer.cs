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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbx_studentId = new System.Windows.Forms.ComboBox();
            this.cbx_componentId = new System.Windows.Forms.ComboBox();
            this.dtp_evaluationDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assessmentComponentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubricMeasurementIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObtainedMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_studentId
            // 
            this.cbx_studentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_studentId.FormattingEnabled = true;
            this.cbx_studentId.Location = new System.Drawing.Point(189, 24);
            this.cbx_studentId.Name = "cbx_studentId";
            this.cbx_studentId.Size = new System.Drawing.Size(200, 21);
            this.cbx_studentId.TabIndex = 0;
            // 
            // cbx_componentId
            // 
            this.cbx_componentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_componentId.FormattingEnabled = true;
            this.cbx_componentId.Location = new System.Drawing.Point(189, 78);
            this.cbx_componentId.Name = "cbx_componentId";
            this.cbx_componentId.Size = new System.Drawing.Size(200, 21);
            this.cbx_componentId.TabIndex = 1;
            this.cbx_componentId.SelectedIndexChanged += new System.EventHandler(this.cbx_componentId_SelectedIndexChanged);
            // 
            // dtp_evaluationDate
            // 
            this.dtp_evaluationDate.Location = new System.Drawing.Point(189, 186);
            this.dtp_evaluationDate.Name = "dtp_evaluationDate";
            this.dtp_evaluationDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_evaluationDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Assessment Component Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rubric Measurement Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Evaluation Date";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(428, 24);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.assessmentComponentIdDataGridViewTextBoxColumn,
            this.rubricMeasurementIdDataGridViewTextBoxColumn,
            this.evaluationDateDataGridViewTextBoxColumn,
            this.ObtainedMarks,
            this.Edit,
            this.Delete});
            this.dataGridView1.DataSource = this.studentResultBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(12, 237);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(761, 127);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            // 
            // assessmentComponentIdDataGridViewTextBoxColumn
            // 
            this.assessmentComponentIdDataGridViewTextBoxColumn.DataPropertyName = "AssessmentComponentId";
            this.assessmentComponentIdDataGridViewTextBoxColumn.HeaderText = "AssessmentComponentId";
            this.assessmentComponentIdDataGridViewTextBoxColumn.Name = "assessmentComponentIdDataGridViewTextBoxColumn";
            // 
            // rubricMeasurementIdDataGridViewTextBoxColumn
            // 
            this.rubricMeasurementIdDataGridViewTextBoxColumn.DataPropertyName = "RubricMeasurementId";
            this.rubricMeasurementIdDataGridViewTextBoxColumn.HeaderText = "RubricMeasurementId";
            this.rubricMeasurementIdDataGridViewTextBoxColumn.Name = "rubricMeasurementIdDataGridViewTextBoxColumn";
            // 
            // evaluationDateDataGridViewTextBoxColumn
            // 
            this.evaluationDateDataGridViewTextBoxColumn.DataPropertyName = "EvaluationDate";
            this.evaluationDateDataGridViewTextBoxColumn.HeaderText = "EvaluationDate";
            this.evaluationDateDataGridViewTextBoxColumn.Name = "evaluationDateDataGridViewTextBoxColumn";
            // 
            // ObtainedMarks
            // 
            this.ObtainedMarks.DataPropertyName = "ObtainedMarks";
            this.ObtainedMarks.HeaderText = "ObtainedMarks";
            this.ObtainedMarks.Name = "ObtainedMarks";
            this.ObtainedMarks.ToolTipText = "ObtainedMarks";
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
            this.btn_back.Location = new System.Drawing.Point(428, 54);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // cbx_assessmentTitle
            // 
            this.cbx_assessmentTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_assessmentTitle.FormattingEnabled = true;
            this.cbx_assessmentTitle.Location = new System.Drawing.Point(189, 51);
            this.cbx_assessmentTitle.Name = "cbx_assessmentTitle";
            this.cbx_assessmentTitle.Size = new System.Drawing.Size(200, 21);
            this.cbx_assessmentTitle.TabIndex = 11;
            this.cbx_assessmentTitle.SelectedIndexChanged += new System.EventHandler(this.cbx_assessmentTitle_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Assessment Title";
            // 
            // cbx_rubricmeasurementlevel
            // 
            this.cbx_rubricmeasurementlevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_rubricmeasurementlevel.FormattingEnabled = true;
            this.cbx_rubricmeasurementlevel.Location = new System.Drawing.Point(189, 130);
            this.cbx_rubricmeasurementlevel.Name = "cbx_rubricmeasurementlevel";
            this.cbx_rubricmeasurementlevel.Size = new System.Drawing.Size(200, 21);
            this.cbx_rubricmeasurementlevel.TabIndex = 13;
            this.cbx_rubricmeasurementlevel.SelectedIndexChanged += new System.EventHandler(this.cbx_rubricmeasurementlevel_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Rubric Details";
            // 
            // cbx_rubric
            // 
            this.cbx_rubric.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_rubric.FormattingEnabled = true;
            this.cbx_rubric.Location = new System.Drawing.Point(189, 105);
            this.cbx_rubric.Name = "cbx_rubric";
            this.cbx_rubric.Size = new System.Drawing.Size(200, 21);
            this.cbx_rubric.TabIndex = 15;
            this.cbx_rubric.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbx_id
            // 
            this.cbx_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_id.FormattingEnabled = true;
            this.cbx_id.Location = new System.Drawing.Point(189, 160);
            this.cbx_id.Name = "cbx_id";
            this.cbx_id.Size = new System.Drawing.Size(200, 21);
            this.cbx_id.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Rubric Level Id";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(521, 24);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // ManageStudentResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 376);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbx_id);
            this.Controls.Add(this.cbx_rubric);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbx_rubricmeasurementlevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbx_assessmentTitle);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet9)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectBDataSet9 projectBDataSet9;
        private System.Windows.Forms.BindingSource studentResultBindingSource;
        private ProjectBDataSet9TableAdapters.StudentResultTableAdapter studentResultTableAdapter;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox cbx_assessmentTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_rubricmeasurementlevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_rubric;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessmentComponentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubricMeasurementIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObtainedMarks;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.ComboBox cbx_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_update;
    }
}