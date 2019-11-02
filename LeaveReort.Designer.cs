namespace HRM
{
    partial class LeaveReort
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Leavetycombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LeavereportBTN = new System.Windows.Forms.Button();
            this.YearCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LeaStaffID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LeaveReportGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLeave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveInhand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveReportGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.ExportBtn);
            this.groupBox1.Controls.Add(this.Leavetycombo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LeavereportBTN);
            this.groupBox1.Controls.Add(this.YearCombo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LeaStaffID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 214);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leave Report";
            // 
            // Leavetycombo
            // 
            this.Leavetycombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Leavetycombo.FormattingEnabled = true;
            this.Leavetycombo.Location = new System.Drawing.Point(127, 117);
            this.Leavetycombo.Name = "Leavetycombo";
            this.Leavetycombo.Size = new System.Drawing.Size(206, 24);
            this.Leavetycombo.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Leave Type";
            // 
            // LeavereportBTN
            // 
            this.LeavereportBTN.Location = new System.Drawing.Point(171, 166);
            this.LeavereportBTN.Name = "LeavereportBTN";
            this.LeavereportBTN.Size = new System.Drawing.Size(75, 23);
            this.LeavereportBTN.TabIndex = 6;
            this.LeavereportBTN.Text = "Search";
            this.LeavereportBTN.UseVisualStyleBackColor = true;
            this.LeavereportBTN.Click += new System.EventHandler(this.LeavereportBTN_Click);
            // 
            // YearCombo
            // 
            this.YearCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearCombo.FormattingEnabled = true;
            this.YearCombo.Location = new System.Drawing.Point(127, 71);
            this.YearCombo.Name = "YearCombo";
            this.YearCombo.Size = new System.Drawing.Size(206, 24);
            this.YearCombo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Year";
            // 
            // LeaStaffID
            // 
            this.LeaStaffID.Location = new System.Drawing.Point(127, 31);
            this.LeaStaffID.Margin = new System.Windows.Forms.Padding(4);
            this.LeaStaffID.Name = "LeaStaffID";
            this.LeaStaffID.Size = new System.Drawing.Size(206, 22);
            this.LeaStaffID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Staff ID";
            // 
            // LeaveReportGridView
            // 
            this.LeaveReportGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LeaveReportGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.StaffID,
            this.StaffName,
            this.Department,
            this.Year,
            this.TotalLeave,
            this.LeaveTaken,
            this.LeaveInhand});
            this.LeaveReportGridView.Location = new System.Drawing.Point(12, 232);
            this.LeaveReportGridView.Name = "LeaveReportGridView";
            this.LeaveReportGridView.Size = new System.Drawing.Size(756, 150);
            this.LeaveReportGridView.TabIndex = 2;
            // 
            // SL
            // 
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
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
            // 
            // Department
            // 
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // TotalLeave
            // 
            this.TotalLeave.HeaderText = "TotalLeave";
            this.TotalLeave.Name = "TotalLeave";
            // 
            // LeaveTaken
            // 
            this.LeaveTaken.HeaderText = "LeaveTaken";
            this.LeaveTaken.Name = "LeaveTaken";
            // 
            // LeaveInhand
            // 
            this.LeaveInhand.HeaderText = "LeaveInHand";
            this.LeaveInhand.Name = "LeaveInhand";
            // 
            // ExportBtn
            // 
            this.ExportBtn.Location = new System.Drawing.Point(291, 166);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(75, 23);
            this.ExportBtn.TabIndex = 28;
            this.ExportBtn.Text = "button1";
            this.ExportBtn.UseVisualStyleBackColor = true;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // LeaveReort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LeaveReportGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "LeaveReort";
            this.Text = "LeaveReort";
            this.Load += new System.EventHandler(this.LeaveReort_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveReportGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LeaStaffID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LeavereportBTN;
        private System.Windows.Forms.ComboBox YearCombo;
        private System.Windows.Forms.DataGridView LeaveReportGridView;
        private System.Windows.Forms.ComboBox Leavetycombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalLeave;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveTaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveInhand;
        private System.Windows.Forms.Button ExportBtn;
    }
}