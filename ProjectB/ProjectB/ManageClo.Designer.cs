namespace ProjectB
{
    partial class ManageClo
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet3 = new ProjectB.ProjectBDataSet3();
            this.cloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet1 = new ProjectB.ProjectBDataSet1();
            this.cloTableAdapter = new ProjectB.ProjectBDataSet1TableAdapters.CloTableAdapter();
            this.cloTableAdapter1 = new ProjectB.ProjectBDataSet3TableAdapters.CloTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(307, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NAME_ONLY);
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.isname);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(307, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(534, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Location = new System.Drawing.Point(5, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 8;
            this.button3.Text = "Back to Home";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.nameDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.dateUpdatedDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.dataGridView1.DataSource = this.cloBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(9, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 205);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            // 
            // dateUpdatedDataGridViewTextBoxColumn
            // 
            this.dateUpdatedDataGridViewTextBoxColumn.DataPropertyName = "DateUpdated";
            this.dateUpdatedDataGridViewTextBoxColumn.HeaderText = "DateUpdated";
            this.dateUpdatedDataGridViewTextBoxColumn.Name = "dateUpdatedDataGridViewTextBoxColumn";
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
            // cloBindingSource1
            // 
            this.cloBindingSource1.DataMember = "Clo";
            this.cloBindingSource1.DataSource = this.projectBDataSet3;
            // 
            // projectBDataSet3
            // 
            this.projectBDataSet3.DataSetName = "ProjectBDataSet3";
            this.projectBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cloBindingSource
            // 
            this.cloBindingSource.DataMember = "Clo";
            this.cloBindingSource.DataSource = this.projectBDataSet1;
            // 
            // projectBDataSet1
            // 
            this.projectBDataSet1.DataSetName = "ProjectBDataSet1";
            this.projectBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cloTableAdapter
            // 
            this.cloTableAdapter.ClearBeforeFill = true;
            // 
            // cloTableAdapter1
            // 
            this.cloTableAdapter1.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(424, 223);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 27);
            this.button4.TabIndex = 10;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 145);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(304, 20);
            this.textBox2.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.24846F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.75154F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(775, 100);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Manage Clo\'s(Add, Update And Delete)";
            // 
            // ManageClo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 496);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "ManageClo";
            this.Text = "ManageClo";
            this.Load += new System.EventHandler(this.ManageClo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectBDataSet1 projectBDataSet1;
        private System.Windows.Forms.BindingSource cloBindingSource;
        private ProjectBDataSet1TableAdapters.CloTableAdapter cloTableAdapter;
        private ProjectBDataSet3 projectBDataSet3;
        private System.Windows.Forms.BindingSource cloBindingSource1;
        private ProjectBDataSet3TableAdapters.CloTableAdapter cloTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
    }
}