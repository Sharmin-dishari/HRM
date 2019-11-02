namespace HRM
{
    partial class PersonalInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.ContacttextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resetbtn = new System.Windows.Forms.Button();
            this.Thana = new System.Windows.Forms.ComboBox();
            this.District = new System.Windows.Forms.ComboBox();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.StaffIDtextBox = new System.Windows.Forms.TextBox();
            this.StaffID = new System.Windows.Forms.Label();
            this.PermanentadresstextBox = new System.Windows.Forms.TextBox();
            this.DeletePersonal = new System.Windows.Forms.Button();
            this.SavePersonal = new System.Windows.Forms.Button();
            this.ParentsAddresstextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.MothersNametextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.FathersNametextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PresentAddresstextBox = new System.Windows.Forms.TextBox();
            this.VillagetextBox = new System.Windows.Forms.TextBox();
            this.PostCodetextBox = new System.Windows.Forms.TextBox();
            this.MarriedCombox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contact";
            // 
            // ContacttextBox
            // 
            this.ContacttextBox.Location = new System.Drawing.Point(139, 61);
            this.ContacttextBox.Name = "ContacttextBox";
            this.ContacttextBox.Size = new System.Drawing.Size(264, 22);
            this.ContacttextBox.TabIndex = 5;
            this.ContacttextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContacttextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date Of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "District";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Thana";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Post Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Village";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Present Address";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox1.Controls.Add(this.MarriedCombox);
            this.groupBox1.Controls.Add(this.resetbtn);
            this.groupBox1.Controls.Add(this.Thana);
            this.groupBox1.Controls.Add(this.District);
            this.groupBox1.Controls.Add(this.DOB);
            this.groupBox1.Controls.Add(this.StaffIDtextBox);
            this.groupBox1.Controls.Add(this.StaffID);
            this.groupBox1.Controls.Add(this.PermanentadresstextBox);
            this.groupBox1.Controls.Add(this.DeletePersonal);
            this.groupBox1.Controls.Add(this.SavePersonal);
            this.groupBox1.Controls.Add(this.ParentsAddresstextBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.MothersNametextBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.FathersNametextBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.PresentAddresstextBox);
            this.groupBox1.Controls.Add(this.VillagetextBox);
            this.groupBox1.Controls.Add(this.PostCodetextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ContacttextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 445);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PersonalInfo";
            // 
            // resetbtn
            // 
            this.resetbtn.Location = new System.Drawing.Point(233, 403);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(75, 23);
            this.resetbtn.TabIndex = 42;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // Thana
            // 
            this.Thana.DropDownHeight = 80;
            this.Thana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Thana.FormattingEnabled = true;
            this.Thana.IntegralHeight = false;
            this.Thana.Location = new System.Drawing.Point(139, 145);
            this.Thana.Name = "Thana";
            this.Thana.Size = new System.Drawing.Size(264, 24);
            this.Thana.TabIndex = 41;
            this.Thana.SelectedIndexChanged += new System.EventHandler(this.Thana_SelectedIndexChanged);
            // 
            // District
            // 
            this.District.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.District.FormattingEnabled = true;
            this.District.Location = new System.Drawing.Point(139, 115);
            this.District.Name = "District";
            this.District.Size = new System.Drawing.Size(264, 24);
            this.District.TabIndex = 40;
            // 
            // DOB
            // 
            this.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOB.Location = new System.Drawing.Point(139, 87);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(264, 22);
            this.DOB.TabIndex = 38;
            this.DOB.Value = new System.DateTime(2019, 7, 22, 0, 0, 0, 0);
            this.DOB.ValueChanged += new System.EventHandler(this.DOB_ValueChanged);
            // 
            // StaffIDtextBox
            // 
            this.StaffIDtextBox.Location = new System.Drawing.Point(139, 33);
            this.StaffIDtextBox.Name = "StaffIDtextBox";
            this.StaffIDtextBox.Size = new System.Drawing.Size(264, 22);
            this.StaffIDtextBox.TabIndex = 37;
            this.StaffIDtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StaffIDtextBox_KeyDown_1);
            // 
            // StaffID
            // 
            this.StaffID.AutoSize = true;
            this.StaffID.Location = new System.Drawing.Point(6, 36);
            this.StaffID.Name = "StaffID";
            this.StaffID.Size = new System.Drawing.Size(58, 16);
            this.StaffID.TabIndex = 36;
            this.StaffID.Text = "Staff ID";
            // 
            // PermanentadresstextBox
            // 
            this.PermanentadresstextBox.Location = new System.Drawing.Point(139, 249);
            this.PermanentadresstextBox.Multiline = true;
            this.PermanentadresstextBox.Name = "PermanentadresstextBox";
            this.PermanentadresstextBox.Size = new System.Drawing.Size(264, 23);
            this.PermanentadresstextBox.TabIndex = 35;
            // 
            // DeletePersonal
            // 
            this.DeletePersonal.Location = new System.Drawing.Point(328, 403);
            this.DeletePersonal.Name = "DeletePersonal";
            this.DeletePersonal.Size = new System.Drawing.Size(75, 23);
            this.DeletePersonal.TabIndex = 34;
            this.DeletePersonal.Text = "Delete";
            this.DeletePersonal.UseVisualStyleBackColor = true;
            this.DeletePersonal.Click += new System.EventHandler(this.DeletePersonal_Click);
            // 
            // SavePersonal
            // 
            this.SavePersonal.Location = new System.Drawing.Point(139, 403);
            this.SavePersonal.Name = "SavePersonal";
            this.SavePersonal.Size = new System.Drawing.Size(75, 23);
            this.SavePersonal.TabIndex = 33;
            this.SavePersonal.Text = "Save";
            this.SavePersonal.UseVisualStyleBackColor = true;
            this.SavePersonal.Click += new System.EventHandler(this.SavePersonal_Click);
            // 
            // ParentsAddresstextBox
            // 
            this.ParentsAddresstextBox.Location = new System.Drawing.Point(139, 368);
            this.ParentsAddresstextBox.Name = "ParentsAddresstextBox";
            this.ParentsAddresstextBox.Size = new System.Drawing.Size(264, 22);
            this.ParentsAddresstextBox.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 374);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 16);
            this.label13.TabIndex = 31;
            this.label13.Text = "Parent\'s Address";
            // 
            // MothersNametextBox
            // 
            this.MothersNametextBox.Location = new System.Drawing.Point(139, 340);
            this.MothersNametextBox.Name = "MothersNametextBox";
            this.MothersNametextBox.Size = new System.Drawing.Size(264, 22);
            this.MothersNametextBox.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 346);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "Mother\'s Name";
            // 
            // FathersNametextBox
            // 
            this.FathersNametextBox.Location = new System.Drawing.Point(139, 308);
            this.FathersNametextBox.Name = "FathersNametextBox";
            this.FathersNametextBox.Size = new System.Drawing.Size(264, 22);
            this.FathersNametextBox.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Father\'s Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Marital Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "PermanentAddress";
            // 
            // PresentAddresstextBox
            // 
            this.PresentAddresstextBox.Location = new System.Drawing.Point(139, 224);
            this.PresentAddresstextBox.Name = "PresentAddresstextBox";
            this.PresentAddresstextBox.Size = new System.Drawing.Size(264, 22);
            this.PresentAddresstextBox.TabIndex = 22;
            // 
            // VillagetextBox
            // 
            this.VillagetextBox.Location = new System.Drawing.Point(139, 198);
            this.VillagetextBox.Name = "VillagetextBox";
            this.VillagetextBox.Size = new System.Drawing.Size(264, 22);
            this.VillagetextBox.TabIndex = 21;
            // 
            // PostCodetextBox
            // 
            this.PostCodetextBox.Location = new System.Drawing.Point(139, 172);
            this.PostCodetextBox.Name = "PostCodetextBox";
            this.PostCodetextBox.Size = new System.Drawing.Size(264, 22);
            this.PostCodetextBox.TabIndex = 20;
            this.PostCodetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PostCodetextBox_KeyPress);
            // 
            // MarriedCombox
            // 
            this.MarriedCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MarriedCombox.FormattingEnabled = true;
            this.MarriedCombox.Location = new System.Drawing.Point(139, 278);
            this.MarriedCombox.Name = "MarriedCombox";
            this.MarriedCombox.Size = new System.Drawing.Size(264, 24);
            this.MarriedCombox.TabIndex = 43;
            // 
            // PersonalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "PersonalInfo";
            this.Text = "PersonalInfo";
            this.Load += new System.EventHandler(this.PersonalInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ContacttextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PresentAddresstextBox;
        private System.Windows.Forms.TextBox VillagetextBox;
        private System.Windows.Forms.TextBox PostCodetextBox;
        private System.Windows.Forms.Button DeletePersonal;
        private System.Windows.Forms.TextBox ParentsAddresstextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox MothersNametextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox FathersNametextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PermanentadresstextBox;
        private System.Windows.Forms.TextBox StaffIDtextBox;
        private System.Windows.Forms.Label StaffID;
        private System.Windows.Forms.DateTimePicker DOB;
        private System.Windows.Forms.ComboBox Thana;
        private System.Windows.Forms.ComboBox District;
        private System.Windows.Forms.Button SavePersonal;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.ComboBox MarriedCombox;
    }
}