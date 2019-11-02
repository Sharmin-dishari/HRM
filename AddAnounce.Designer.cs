namespace HRM
{
    partial class AddAnounce
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
            this.hidebox = new System.Windows.Forms.TextBox();
            this.DeleteBtnAdd = new System.Windows.Forms.Button();
            this.AnnonceCombo = new System.Windows.Forms.ComboBox();
            this.AddDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.SAveAdd = new System.Windows.Forms.Button();
            this.AddDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Addsubject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddStafID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridAnnounce = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.GroupBox();
            this.SearchBTtN = new System.Windows.Forms.Button();
            this.SearchStaf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnnounceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnnounce)).BeginInit();
            this.Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox1.Controls.Add(this.hidebox);
            this.groupBox1.Controls.Add(this.DeleteBtnAdd);
            this.groupBox1.Controls.Add(this.AnnonceCombo);
            this.groupBox1.Controls.Add(this.AddDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.SAveAdd);
            this.groupBox1.Controls.Add(this.AddDescription);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Addsubject);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddStafID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 255);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Anounce";
            // 
            // hidebox
            // 
            this.hidebox.Location = new System.Drawing.Point(514, 27);
            this.hidebox.Name = "hidebox";
            this.hidebox.Size = new System.Drawing.Size(100, 22);
            this.hidebox.TabIndex = 18;
            this.hidebox.Visible = false;
            // 
            // DeleteBtnAdd
            // 
            this.DeleteBtnAdd.Location = new System.Drawing.Point(354, 227);
            this.DeleteBtnAdd.Name = "DeleteBtnAdd";
            this.DeleteBtnAdd.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtnAdd.TabIndex = 17;
            this.DeleteBtnAdd.Text = "Delete";
            this.DeleteBtnAdd.UseVisualStyleBackColor = true;
            this.DeleteBtnAdd.Click += new System.EventHandler(this.DeleteBtnAdd_Click);
            // 
            // AnnonceCombo
            // 
            this.AnnonceCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnnonceCombo.FormattingEnabled = true;
            this.AnnonceCombo.Location = new System.Drawing.Point(158, 53);
            this.AnnonceCombo.Name = "AnnonceCombo";
            this.AnnonceCombo.Size = new System.Drawing.Size(291, 24);
            this.AnnonceCombo.TabIndex = 16;
            // 
            // AddDate
            // 
            this.AddDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AddDate.Location = new System.Drawing.Point(158, 83);
            this.AddDate.Name = "AddDate";
            this.AddDate.Size = new System.Drawing.Size(291, 22);
            this.AddDate.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Date";
            // 
            // SAveAdd
            // 
            this.SAveAdd.Location = new System.Drawing.Point(158, 226);
            this.SAveAdd.Name = "SAveAdd";
            this.SAveAdd.Size = new System.Drawing.Size(179, 23);
            this.SAveAdd.TabIndex = 12;
            this.SAveAdd.Text = "Publish Announcement";
            this.SAveAdd.UseVisualStyleBackColor = true;
            this.SAveAdd.Click += new System.EventHandler(this.SAveAdd_Click);
            // 
            // AddDescription
            // 
            this.AddDescription.Location = new System.Drawing.Point(158, 138);
            this.AddDescription.Multiline = true;
            this.AddDescription.Name = "AddDescription";
            this.AddDescription.Size = new System.Drawing.Size(291, 82);
            this.AddDescription.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description";
            // 
            // Addsubject
            // 
            this.Addsubject.Location = new System.Drawing.Point(158, 111);
            this.Addsubject.Name = "Addsubject";
            this.Addsubject.Size = new System.Drawing.Size(291, 22);
            this.Addsubject.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Anouncement Type";
            // 
            // AddStafID
            // 
            this.AddStafID.Location = new System.Drawing.Point(158, 24);
            this.AddStafID.Name = "AddStafID";
            this.AddStafID.Size = new System.Drawing.Size(291, 22);
            this.AddStafID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "StaffID";
            // 
            // dataGridAnnounce
            // 
            this.dataGridAnnounce.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dataGridAnnounce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAnnounce.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.StaffID,
            this.AnnounceType,
            this.Date,
            this.Subject,
            this.Description,
            this.Id});
            this.dataGridAnnounce.Location = new System.Drawing.Point(12, 262);
            this.dataGridAnnounce.Name = "dataGridAnnounce";
            this.dataGridAnnounce.Size = new System.Drawing.Size(726, 155);
            this.dataGridAnnounce.TabIndex = 2;
            this.dataGridAnnounce.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAnnounce_CellDoubleClick);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Search.Controls.Add(this.SearchBTtN);
            this.Search.Controls.Add(this.SearchStaf);
            this.Search.Controls.Add(this.label5);
            this.Search.Location = new System.Drawing.Point(658, 84);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(281, 118);
            this.Search.TabIndex = 3;
            this.Search.TabStop = false;
            this.Search.Text = "Search";
            // 
            // SearchBTtN
            // 
            this.SearchBTtN.Location = new System.Drawing.Point(99, 66);
            this.SearchBTtN.Name = "SearchBTtN";
            this.SearchBTtN.Size = new System.Drawing.Size(75, 23);
            this.SearchBTtN.TabIndex = 17;
            this.SearchBTtN.Text = "Search";
            this.SearchBTtN.UseVisualStyleBackColor = true;
            this.SearchBTtN.Click += new System.EventHandler(this.SearchBTtN_Click);
            // 
            // SearchStaf
            // 
            this.SearchStaf.Location = new System.Drawing.Point(73, 28);
            this.SearchStaf.Name = "SearchStaf";
            this.SearchStaf.Size = new System.Drawing.Size(193, 20);
            this.SearchStaf.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Staff ID";
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
            // AnnounceType
            // 
            this.AnnounceType.HeaderText = "AnnounceType";
            this.AnnounceType.Name = "AnnounceType";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 180;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // AddAnounce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(949, 450);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.dataGridAnnounce);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddAnounce";
            this.Text = "AddAnounce";
            this.Load += new System.EventHandler(this.AddAnounce_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnnounce)).EndInit();
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SAveAdd;
        private System.Windows.Forms.TextBox AddDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Addsubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddStafID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridAnnounce;
        private System.Windows.Forms.DateTimePicker AddDate;
        private System.Windows.Forms.Button DeleteBtnAdd;
        private System.Windows.Forms.ComboBox AnnonceCombo;
        private System.Windows.Forms.GroupBox Search;
        private System.Windows.Forms.Button SearchBTtN;
        private System.Windows.Forms.TextBox SearchStaf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hidebox;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnnounceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}