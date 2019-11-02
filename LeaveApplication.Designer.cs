namespace HRM
{
    partial class LeaveApplication
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
            this.hiddenText = new System.Windows.Forms.TextBox();
            this.DateFrom = new System.Windows.Forms.DateTimePicker();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            this.LeaveaTypeCombo = new System.Windows.Forms.ComboBox();
            this.TotalLeave = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DeleteLeave = new System.Windows.Forms.Button();
            this.ResetLeave = new System.Windows.Forms.Button();
            this.SaveLeave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StaffID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.leaveApplicationGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StafId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leavetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search = new System.Windows.Forms.GroupBox();
            this.SearchBTTn = new System.Windows.Forms.Button();
            this.stfIDtext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaveApplicationGridView)).BeginInit();
            this.Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.groupBox1.Controls.Add(this.hiddenText);
            this.groupBox1.Controls.Add(this.DateFrom);
            this.groupBox1.Controls.Add(this.DateTo);
            this.groupBox1.Controls.Add(this.LeaveaTypeCombo);
            this.groupBox1.Controls.Add(this.TotalLeave);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DeleteLeave);
            this.groupBox1.Controls.Add(this.ResetLeave);
            this.groupBox1.Controls.Add(this.SaveLeave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.StaffID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LeaveApplication";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // hiddenText
            // 
            this.hiddenText.Location = new System.Drawing.Point(504, 34);
            this.hiddenText.Name = "hiddenText";
            this.hiddenText.Size = new System.Drawing.Size(62, 22);
            this.hiddenText.TabIndex = 25;
            this.hiddenText.Visible = false;
            // 
            // DateFrom
            // 
            this.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFrom.Location = new System.Drawing.Point(133, 90);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(287, 22);
            this.DateFrom.TabIndex = 24;
            this.DateFrom.ValueChanged += new System.EventHandler(this.DateFrom_ValueChanged);
            // 
            // DateTo
            // 
            this.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTo.Location = new System.Drawing.Point(133, 119);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(287, 22);
            this.DateTo.TabIndex = 23;
            this.DateTo.ValueChanged += new System.EventHandler(this.DateTo_ValueChanged);
            // 
            // LeaveaTypeCombo
            // 
            this.LeaveaTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LeaveaTypeCombo.FormattingEnabled = true;
            this.LeaveaTypeCombo.Location = new System.Drawing.Point(133, 61);
            this.LeaveaTypeCombo.Name = "LeaveaTypeCombo";
            this.LeaveaTypeCombo.Size = new System.Drawing.Size(287, 24);
            this.LeaveaTypeCombo.TabIndex = 22;
            this.LeaveaTypeCombo.SelectedIndexChanged += new System.EventHandler(this.LeaveaTypeCombo_SelectedIndexChanged);
            // 
            // TotalLeave
            // 
            this.TotalLeave.Location = new System.Drawing.Point(133, 156);
            this.TotalLeave.Name = "TotalLeave";
            this.TotalLeave.ReadOnly = true;
            this.TotalLeave.Size = new System.Drawing.Size(287, 22);
            this.TotalLeave.TabIndex = 20;
            this.TotalLeave.ReadOnlyChanged += new System.EventHandler(this.SaveLeave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Total";
            // 
            // DeleteLeave
            // 
            this.DeleteLeave.Location = new System.Drawing.Point(332, 197);
            this.DeleteLeave.Name = "DeleteLeave";
            this.DeleteLeave.Size = new System.Drawing.Size(75, 23);
            this.DeleteLeave.TabIndex = 18;
            this.DeleteLeave.Text = "Delete";
            this.DeleteLeave.UseVisualStyleBackColor = true;
            this.DeleteLeave.Click += new System.EventHandler(this.DeleteLeave_Click);
            // 
            // ResetLeave
            // 
            this.ResetLeave.Location = new System.Drawing.Point(235, 197);
            this.ResetLeave.Name = "ResetLeave";
            this.ResetLeave.Size = new System.Drawing.Size(75, 23);
            this.ResetLeave.TabIndex = 17;
            this.ResetLeave.Text = "Reset";
            this.ResetLeave.UseVisualStyleBackColor = true;
            // 
            // SaveLeave
            // 
            this.SaveLeave.Location = new System.Drawing.Point(133, 197);
            this.SaveLeave.Name = "SaveLeave";
            this.SaveLeave.Size = new System.Drawing.Size(75, 23);
            this.SaveLeave.TabIndex = 16;
            this.SaveLeave.Text = "Save";
            this.SaveLeave.UseVisualStyleBackColor = true;
            this.SaveLeave.Click += new System.EventHandler(this.SaveLeave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Leave Type";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // StaffID
            // 
            this.StaffID.Location = new System.Drawing.Point(133, 33);
            this.StaffID.Name = "StaffID";
            this.StaffID.Size = new System.Drawing.Size(287, 22);
            this.StaffID.TabIndex = 1;
            this.StaffID.TextChanged += new System.EventHandler(this.StaffID_TextChanged);
            this.StaffID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StaffID_KeyDown);
            this.StaffID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StaffID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // leaveApplicationGridView
            // 
            this.leaveApplicationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaveApplicationGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.StafId,
            this.Leavetype,
            this.From,
            this.To,
            this.totall,
            this.Id});
            this.leaveApplicationGridView.Location = new System.Drawing.Point(12, 256);
            this.leaveApplicationGridView.Name = "leaveApplicationGridView";
            this.leaveApplicationGridView.Size = new System.Drawing.Size(605, 150);
            this.leaveApplicationGridView.TabIndex = 1;
            this.leaveApplicationGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.leaveApplicationGridView_CellDoubleClick);
            // 
            // SL
            // 
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            // 
            // StafId
            // 
            this.StafId.HeaderText = "StafId";
            this.StafId.Name = "StafId";
            // 
            // Leavetype
            // 
            this.Leavetype.HeaderText = "Leavetype";
            this.Leavetype.Name = "Leavetype";
            // 
            // From
            // 
            this.From.HeaderText = "From";
            this.From.Name = "From";
            // 
            // To
            // 
            this.To.HeaderText = "To";
            this.To.Name = "To";
            // 
            // totall
            // 
            this.totall.HeaderText = "totall";
            this.totall.Name = "totall";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Search.Controls.Add(this.SearchBTTn);
            this.Search.Controls.Add(this.stfIDtext);
            this.Search.Controls.Add(this.label2);
            this.Search.Location = new System.Drawing.Point(636, 268);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(281, 118);
            this.Search.TabIndex = 2;
            this.Search.TabStop = false;
            this.Search.Text = "Search";
            // 
            // SearchBTTn
            // 
            this.SearchBTTn.Location = new System.Drawing.Point(99, 66);
            this.SearchBTTn.Name = "SearchBTTn";
            this.SearchBTTn.Size = new System.Drawing.Size(75, 23);
            this.SearchBTTn.TabIndex = 17;
            this.SearchBTTn.Text = "Search";
            this.SearchBTTn.UseVisualStyleBackColor = true;
            this.SearchBTTn.Click += new System.EventHandler(this.SearchBTTn_Click);
            // 
            // stfIDtext
            // 
            this.stfIDtext.Location = new System.Drawing.Point(73, 28);
            this.stfIDtext.Name = "stfIDtext";
            this.stfIDtext.Size = new System.Drawing.Size(193, 20);
            this.stfIDtext.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Staff ID";
            // 
            // LeaveApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 450);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.leaveApplicationGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "LeaveApplication";
            this.Text = "Leave_Application";
            this.Load += new System.EventHandler(this.LeaveApplication_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaveApplicationGridView)).EndInit();
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StaffID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteLeave;
        private System.Windows.Forms.Button ResetLeave;
        private System.Windows.Forms.Button SaveLeave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TotalLeave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DateFrom;
        private System.Windows.Forms.DateTimePicker DateTo;
        private System.Windows.Forms.ComboBox LeaveaTypeCombo;
        private System.Windows.Forms.DataGridView leaveApplicationGridView;
        private System.Windows.Forms.GroupBox Search;
        private System.Windows.Forms.Button SearchBTTn;
        private System.Windows.Forms.TextBox stfIDtext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn StafId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leavetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn totall;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.TextBox hiddenText;
    }
}