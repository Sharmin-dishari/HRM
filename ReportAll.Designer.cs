namespace HRM
{
    partial class ReportAll
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Reportsearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ReportID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ReportDataGrid = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoiningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BasicSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.StatusCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DeportCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSalmon;
            this.groupBox2.Controls.Add(this.StatusCombo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.DeportCombo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ExportBtn);
            this.groupBox2.Controls.Add(this.Reportsearch);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.ReportID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 200);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Maser Report";
            // 
            // Reportsearch
            // 
            this.Reportsearch.Location = new System.Drawing.Point(124, 144);
            this.Reportsearch.Name = "Reportsearch";
            this.Reportsearch.Size = new System.Drawing.Size(75, 23);
            this.Reportsearch.TabIndex = 23;
            this.Reportsearch.Text = "Search";
            this.Reportsearch.UseVisualStyleBackColor = true;
            this.Reportsearch.Click += new System.EventHandler(this.Reportsearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 21;
            // 
            // ReportID
            // 
            this.ReportID.Location = new System.Drawing.Point(106, 37);
            this.ReportID.Name = "ReportID";
            this.ReportID.Size = new System.Drawing.Size(273, 20);
            this.ReportID.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 19;
            this.label9.Tag = "ID";
            this.label9.Text = "Staff ID";
            // 
            // ReportDataGrid
            // 
            this.ReportDataGrid.BackgroundColor = System.Drawing.Color.Aqua;
            this.ReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.StaffID,
            this.StaffName,
            this.Department,
            this.Designation,
            this.JoiningDate,
            this.Contact,
            this.Address,
            this.BasicSalary,
            this.TotalSalary,
            this.Status});
            this.ReportDataGrid.Location = new System.Drawing.Point(12, 244);
            this.ReportDataGrid.Name = "ReportDataGrid";
            this.ReportDataGrid.Size = new System.Drawing.Size(958, 150);
            this.ReportDataGrid.TabIndex = 5;
            // 
            // SL
            // 
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            this.SL.Width = 50;
            // 
            // StaffID
            // 
            this.StaffID.HeaderText = "StaffID";
            this.StaffID.Name = "StaffID";
            // 
            // StaffName
            // 
            this.StaffName.HeaderText = "StaffName";
            this.StaffName.Name = "StaffName";
            this.StaffName.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            // 
            // Designation
            // 
            this.Designation.HeaderText = "Designation";
            this.Designation.Name = "Designation";
            // 
            // JoiningDate
            // 
            this.JoiningDate.HeaderText = "JoiningDate";
            this.JoiningDate.Name = "JoiningDate";
            this.JoiningDate.ReadOnly = true;
            // 
            // Contact
            // 
            this.Contact.HeaderText = "Contact";
            this.Contact.Name = "Contact";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.Width = 220;
            // 
            // BasicSalary
            // 
            this.BasicSalary.HeaderText = "BasicSalary";
            this.BasicSalary.Name = "BasicSalary";
            // 
            // TotalSalary
            // 
            this.TotalSalary.HeaderText = "TotalSalary";
            this.TotalSalary.Name = "TotalSalary";
            this.TotalSalary.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // ExportBtn
            // 
            this.ExportBtn.Location = new System.Drawing.Point(237, 144);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(75, 23);
            this.ExportBtn.TabIndex = 24;
            this.ExportBtn.Text = "Excel";
            this.ExportBtn.UseVisualStyleBackColor = true;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // StatusCombo
            // 
            this.StatusCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusCombo.FormattingEnabled = true;
            this.StatusCombo.Location = new System.Drawing.Point(106, 111);
            this.StatusCombo.Name = "StatusCombo";
            this.StatusCombo.Size = new System.Drawing.Size(273, 21);
            this.StatusCombo.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Status";
            // 
            // DeportCombo
            // 
            this.DeportCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeportCombo.FormattingEnabled = true;
            this.DeportCombo.Location = new System.Drawing.Point(106, 73);
            this.DeportCombo.Name = "DeportCombo";
            this.DeportCombo.Size = new System.Drawing.Size(273, 21);
            this.DeportCombo.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Department";
            // 
            // ReportAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 450);
            this.Controls.Add(this.ReportDataGrid);
            this.Controls.Add(this.groupBox2);
            this.Name = "ReportAll";
            this.Text = "RepoertAll";
            this.Load += new System.EventHandler(this.ReportAll_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Reportsearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ReportID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView ReportDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoiningDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn BasicSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.ComboBox StatusCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DeportCombo;
        private System.Windows.Forms.Label label2;
    }
}