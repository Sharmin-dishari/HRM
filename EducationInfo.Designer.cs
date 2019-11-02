namespace HRM
{
    partial class EducationInfo
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
            this.BoardCombo = new System.Windows.Forms.ComboBox();
            this.studyCombo = new System.Windows.Forms.ComboBox();
            this.stIText = new System.Windows.Forms.TextBox();
            this.IdText = new System.Windows.Forms.Label();
            this.edudeletebtn = new System.Windows.Forms.Button();
            this.eduResetBtn = new System.Windows.Forms.Button();
            this.eduSaveButton = new System.Windows.Forms.Button();
            this.CGPAtext = new System.Windows.Forms.TextBox();
            this.CGPAlebel = new System.Windows.Forms.Label();
            this.Yeartext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameofInstitutetext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox1.Controls.Add(this.BoardCombo);
            this.groupBox1.Controls.Add(this.studyCombo);
            this.groupBox1.Controls.Add(this.stIText);
            this.groupBox1.Controls.Add(this.IdText);
            this.groupBox1.Controls.Add(this.edudeletebtn);
            this.groupBox1.Controls.Add(this.eduResetBtn);
            this.groupBox1.Controls.Add(this.eduSaveButton);
            this.groupBox1.Controls.Add(this.CGPAtext);
            this.groupBox1.Controls.Add(this.CGPAlebel);
            this.groupBox1.Controls.Add(this.Yeartext);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NameofInstitutetext);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 443);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EducationalInfo";
            // 
            // BoardCombo
            // 
            this.BoardCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoardCombo.FormattingEnabled = true;
            this.BoardCombo.Location = new System.Drawing.Point(155, 156);
            this.BoardCombo.Name = "BoardCombo";
            this.BoardCombo.Size = new System.Drawing.Size(308, 24);
            this.BoardCombo.TabIndex = 19;
            // 
            // studyCombo
            // 
            this.studyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studyCombo.FormattingEnabled = true;
            this.studyCombo.Location = new System.Drawing.Point(154, 90);
            this.studyCombo.Name = "studyCombo";
            this.studyCombo.Size = new System.Drawing.Size(309, 24);
            this.studyCombo.TabIndex = 18;
            // 
            // stIText
            // 
            this.stIText.Location = new System.Drawing.Point(155, 52);
            this.stIText.Name = "stIText";
            this.stIText.Size = new System.Drawing.Size(308, 22);
            this.stIText.TabIndex = 17;
            this.stIText.TextChanged += new System.EventHandler(this.stIText_TextChanged);
            this.stIText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stIText_KeyDown);
            this.stIText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stIText_KeyPress);
            // 
            // IdText
            // 
            this.IdText.AutoSize = true;
            this.IdText.Location = new System.Drawing.Point(24, 55);
            this.IdText.Name = "IdText";
            this.IdText.Size = new System.Drawing.Size(58, 16);
            this.IdText.TabIndex = 16;
            this.IdText.Text = "Staff ID";
            // 
            // edudeletebtn
            // 
            this.edudeletebtn.Location = new System.Drawing.Point(374, 291);
            this.edudeletebtn.Name = "edudeletebtn";
            this.edudeletebtn.Size = new System.Drawing.Size(75, 23);
            this.edudeletebtn.TabIndex = 1;
            this.edudeletebtn.Text = "Delete";
            this.edudeletebtn.UseVisualStyleBackColor = true;
            this.edudeletebtn.Click += new System.EventHandler(this.edudeletebtn_Click);
            // 
            // eduResetBtn
            // 
            this.eduResetBtn.Location = new System.Drawing.Point(269, 291);
            this.eduResetBtn.Name = "eduResetBtn";
            this.eduResetBtn.Size = new System.Drawing.Size(75, 23);
            this.eduResetBtn.TabIndex = 15;
            this.eduResetBtn.Text = "Reset";
            this.eduResetBtn.UseVisualStyleBackColor = true;
            // 
            // eduSaveButton
            // 
            this.eduSaveButton.Location = new System.Drawing.Point(155, 291);
            this.eduSaveButton.Name = "eduSaveButton";
            this.eduSaveButton.Size = new System.Drawing.Size(75, 23);
            this.eduSaveButton.TabIndex = 14;
            this.eduSaveButton.Text = "Save";
            this.eduSaveButton.UseVisualStyleBackColor = true;
            this.eduSaveButton.Click += new System.EventHandler(this.eduSaveButton_Click);
            // 
            // CGPAtext
            // 
            this.CGPAtext.Location = new System.Drawing.Point(154, 235);
            this.CGPAtext.Name = "CGPAtext";
            this.CGPAtext.Size = new System.Drawing.Size(308, 22);
            this.CGPAtext.TabIndex = 13;
            this.CGPAtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CGPAtext_KeyPress);
            // 
            // CGPAlebel
            // 
            this.CGPAlebel.AutoSize = true;
            this.CGPAlebel.Location = new System.Drawing.Point(24, 235);
            this.CGPAlebel.Name = "CGPAlebel";
            this.CGPAlebel.Size = new System.Drawing.Size(110, 16);
            this.CGPAlebel.TabIndex = 12;
            this.CGPAlebel.Text = "CGPA/Division";
            // 
            // Yeartext
            // 
            this.Yeartext.Location = new System.Drawing.Point(154, 195);
            this.Yeartext.Name = "Yeartext";
            this.Yeartext.Size = new System.Drawing.Size(309, 22);
            this.Yeartext.TabIndex = 9;
            this.Yeartext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Yeartext_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Passing Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Board";
            // 
            // NameofInstitutetext
            // 
            this.NameofInstitutetext.Location = new System.Drawing.Point(154, 125);
            this.NameofInstitutetext.Name = "NameofInstitutetext";
            this.NameofInstitutetext.Size = new System.Drawing.Size(309, 22);
            this.NameofInstitutetext.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name Of Institute";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Study level";
            // 
            // EducationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "EducationInfo";
            this.Text = "EducationInfo";
            this.Load += new System.EventHandler(this.EducationInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Yeartext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameofInstitutetext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CGPAtext;
        private System.Windows.Forms.Label CGPAlebel;
        private System.Windows.Forms.Button edudeletebtn;
        private System.Windows.Forms.Button eduResetBtn;
        private System.Windows.Forms.Button eduSaveButton;
        private System.Windows.Forms.TextBox stIText;
        private System.Windows.Forms.Label IdText;
        private System.Windows.Forms.ComboBox BoardCombo;
        private System.Windows.Forms.ComboBox studyCombo;
    }
}