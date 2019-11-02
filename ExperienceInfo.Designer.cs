namespace HRM
{
    partial class ExperienceInfo
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
            this.expdurnumbering = new System.Windows.Forms.NumericUpDown();
            this.Resbtnn = new System.Windows.Forms.Button();
            this.ResignedDate = new System.Windows.Forms.DateTimePicker();
            this.joiiningText = new System.Windows.Forms.DateTimePicker();
            this.stIDTEXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.expSaveBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Workedas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CompanyNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expdurnumbering)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.expdurnumbering);
            this.groupBox1.Controls.Add(this.Resbtnn);
            this.groupBox1.Controls.Add(this.ResignedDate);
            this.groupBox1.Controls.Add(this.joiiningText);
            this.groupBox1.Controls.Add(this.stIDTEXT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DeleteBTN);
            this.groupBox1.Controls.Add(this.expSaveBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Workedas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CompanyNameText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 444);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ExperienceInfo";
            // 
            // expdurnumbering
            // 
            this.expdurnumbering.Location = new System.Drawing.Point(173, 130);
            this.expdurnumbering.Name = "expdurnumbering";
            this.expdurnumbering.Size = new System.Drawing.Size(308, 22);
            this.expdurnumbering.TabIndex = 24;
            // 
            // Resbtnn
            // 
            this.Resbtnn.Location = new System.Drawing.Point(273, 234);
            this.Resbtnn.Name = "Resbtnn";
            this.Resbtnn.Size = new System.Drawing.Size(75, 23);
            this.Resbtnn.TabIndex = 23;
            this.Resbtnn.Text = "Reset";
            this.Resbtnn.UseVisualStyleBackColor = true;
            // 
            // ResignedDate
            // 
            this.ResignedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ResignedDate.Location = new System.Drawing.Point(173, 196);
            this.ResignedDate.Name = "ResignedDate";
            this.ResignedDate.Size = new System.Drawing.Size(308, 22);
            this.ResignedDate.TabIndex = 22;
            // 
            // joiiningText
            // 
            this.joiiningText.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.joiiningText.Location = new System.Drawing.Point(173, 164);
            this.joiiningText.Name = "joiiningText";
            this.joiiningText.Size = new System.Drawing.Size(308, 22);
            this.joiiningText.TabIndex = 21;
            // 
            // stIDTEXT
            // 
            this.stIDTEXT.Location = new System.Drawing.Point(173, 46);
            this.stIDTEXT.Name = "stIDTEXT";
            this.stIDTEXT.Size = new System.Drawing.Size(308, 22);
            this.stIDTEXT.TabIndex = 20;
            this.stIDTEXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stIDTEXT_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Staff ID";
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(377, 234);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(75, 23);
            this.DeleteBTN.TabIndex = 17;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // expSaveBtn
            // 
            this.expSaveBtn.Location = new System.Drawing.Point(173, 234);
            this.expSaveBtn.Name = "expSaveBtn";
            this.expSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.expSaveBtn.TabIndex = 16;
            this.expSaveBtn.Text = "Save";
            this.expSaveBtn.UseVisualStyleBackColor = true;
            this.expSaveBtn.Click += new System.EventHandler(this.expSaveBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Resigned Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Joining Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Experience  Duration";
            // 
            // Workedas
            // 
            this.Workedas.Location = new System.Drawing.Point(173, 102);
            this.Workedas.Name = "Workedas";
            this.Workedas.Size = new System.Drawing.Size(308, 22);
            this.Workedas.TabIndex = 9;
            this.Workedas.TextChanged += new System.EventHandler(this.Workedas_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Worked As";
            // 
            // CompanyNameText
            // 
            this.CompanyNameText.Location = new System.Drawing.Point(173, 74);
            this.CompanyNameText.Name = "CompanyNameText";
            this.CompanyNameText.Size = new System.Drawing.Size(308, 22);
            this.CompanyNameText.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Company Name";
            // 
            // ExperienceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExperienceInfo";
            this.Text = "ExperienceInfo";
            this.Load += new System.EventHandler(this.ExperienceInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expdurnumbering)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button expSaveBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Workedas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CompanyNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stIDTEXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker ResignedDate;
        private System.Windows.Forms.DateTimePicker joiiningText;
        private System.Windows.Forms.NumericUpDown expdurnumbering;
        private System.Windows.Forms.Button Resbtnn;
    }
}