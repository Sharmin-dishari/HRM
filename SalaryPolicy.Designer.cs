namespace HRM
{
    partial class SalaryPolicy
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
            this.StaaFText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ResetSabtn = new System.Windows.Forms.Button();
            this.DeletebtN = new System.Windows.Forms.Button();
            this.ReSavebtn = new System.Windows.Forms.Button();
            this.totalAllow = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FoodbillText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MobileBill = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MedicalText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TransportText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BasicSalaryText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox1.Controls.Add(this.StaaFText);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ResetSabtn);
            this.groupBox1.Controls.Add(this.DeletebtN);
            this.groupBox1.Controls.Add(this.ReSavebtn);
            this.groupBox1.Controls.Add(this.totalAllow);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.FoodbillText);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.MobileBill);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.MedicalText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TransportText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BasicSalaryText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 452);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salary policy";
            // 
            // StaaFText
            // 
            this.StaaFText.Location = new System.Drawing.Point(159, 50);
            this.StaaFText.Multiline = true;
            this.StaaFText.Name = "StaaFText";
            this.StaaFText.Size = new System.Drawing.Size(249, 26);
            this.StaaFText.TabIndex = 26;
            this.StaaFText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StaaFText_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Staff ID";
            // 
            // ResetSabtn
            // 
            this.ResetSabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetSabtn.Location = new System.Drawing.Point(335, 286);
            this.ResetSabtn.Name = "ResetSabtn";
            this.ResetSabtn.Size = new System.Drawing.Size(75, 23);
            this.ResetSabtn.TabIndex = 24;
            this.ResetSabtn.Text = "Reset";
            this.ResetSabtn.UseVisualStyleBackColor = true;
            // 
            // DeletebtN
            // 
            this.DeletebtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletebtN.Location = new System.Drawing.Point(241, 286);
            this.DeletebtN.Name = "DeletebtN";
            this.DeletebtN.Size = new System.Drawing.Size(75, 23);
            this.DeletebtN.TabIndex = 23;
            this.DeletebtN.Text = "Delete";
            this.DeletebtN.UseVisualStyleBackColor = true;
            this.DeletebtN.Click += new System.EventHandler(this.DeletebtN_Click);
            // 
            // ReSavebtn
            // 
            this.ReSavebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReSavebtn.Location = new System.Drawing.Point(160, 286);
            this.ReSavebtn.Name = "ReSavebtn";
            this.ReSavebtn.Size = new System.Drawing.Size(75, 23);
            this.ReSavebtn.TabIndex = 22;
            this.ReSavebtn.Text = "Save";
            this.ReSavebtn.UseVisualStyleBackColor = true;
            this.ReSavebtn.Click += new System.EventHandler(this.ReSavebtn_Click);
            // 
            // totalAllow
            // 
            this.totalAllow.Location = new System.Drawing.Point(160, 232);
            this.totalAllow.Multiline = true;
            this.totalAllow.Name = "totalAllow";
            this.totalAllow.ReadOnly = true;
            this.totalAllow.Size = new System.Drawing.Size(250, 22);
            this.totalAllow.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Total Allowance";
            // 
            // FoodbillText
            // 
            this.FoodbillText.Location = new System.Drawing.Point(160, 198);
            this.FoodbillText.Multiline = true;
            this.FoodbillText.Name = "FoodbillText";
            this.FoodbillText.Size = new System.Drawing.Size(250, 22);
            this.FoodbillText.TabIndex = 17;
            this.FoodbillText.TextChanged += new System.EventHandler(this.FoodbillText_TextChanged);
            this.FoodbillText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FoodbillText_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Food";
            // 
            // MobileBill
            // 
            this.MobileBill.Location = new System.Drawing.Point(159, 171);
            this.MobileBill.Multiline = true;
            this.MobileBill.Name = "MobileBill";
            this.MobileBill.Size = new System.Drawing.Size(250, 21);
            this.MobileBill.TabIndex = 15;
            this.MobileBill.TextChanged += new System.EventHandler(this.MobileBill_TextChanged);
            this.MobileBill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MobileBill_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mobile Bill";
            // 
            // MedicalText
            // 
            this.MedicalText.Location = new System.Drawing.Point(159, 144);
            this.MedicalText.Multiline = true;
            this.MedicalText.Name = "MedicalText";
            this.MedicalText.Size = new System.Drawing.Size(250, 21);
            this.MedicalText.TabIndex = 11;
            this.MedicalText.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.MedicalText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MedicalText_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Medical";
            // 
            // TransportText
            // 
            this.TransportText.Location = new System.Drawing.Point(160, 116);
            this.TransportText.Multiline = true;
            this.TransportText.Name = "TransportText";
            this.TransportText.Size = new System.Drawing.Size(250, 22);
            this.TransportText.TabIndex = 9;
            this.TransportText.TextChanged += new System.EventHandler(this.TransportText_TextChanged);
            this.TransportText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TransportText_KeyDown);
            this.TransportText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TransportText_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Transport";
            // 
            // BasicSalaryText
            // 
            this.BasicSalaryText.Location = new System.Drawing.Point(160, 88);
            this.BasicSalaryText.Multiline = true;
            this.BasicSalaryText.Name = "BasicSalaryText";
            this.BasicSalaryText.Size = new System.Drawing.Size(249, 22);
            this.BasicSalaryText.TabIndex = 7;
            this.BasicSalaryText.TextChanged += new System.EventHandler(this.BasicSalaryText_TextChanged);
            this.BasicSalaryText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BasicSalaryText_KeyDown);
            this.BasicSalaryText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BasicSalaryText_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Basic Salary";
            // 
            // SalaryPolicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "SalaryPolicy";
            this.Text = "SalaryPolicy";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox totalAllow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FoodbillText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MobileBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MedicalText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TransportText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BasicSalaryText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ResetSabtn;
        private System.Windows.Forms.Button DeletebtN;
        private System.Windows.Forms.Button ReSavebtn;
        private System.Windows.Forms.TextBox StaaFText;
        private System.Windows.Forms.Label label10;
    }
}