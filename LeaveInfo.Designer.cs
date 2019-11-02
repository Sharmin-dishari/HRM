namespace HRM
{
    partial class LeaveInfo
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
            this.EarnedLeave = new System.Windows.Forms.NumericUpDown();
            this.MaternityLeave = new System.Windows.Forms.NumericUpDown();
            this.Sickleave = new System.Windows.Forms.NumericUpDown();
            this.CasualLeave = new System.Windows.Forms.NumericUpDown();
            this.DeleteLeave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ResetLeave = new System.Windows.Forms.Button();
            this.SaveLeave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SttafIdText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EarnedLeave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaternityLeave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sickleave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CasualLeave)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.EarnedLeave);
            this.groupBox1.Controls.Add(this.MaternityLeave);
            this.groupBox1.Controls.Add(this.Sickleave);
            this.groupBox1.Controls.Add(this.CasualLeave);
            this.groupBox1.Controls.Add(this.DeleteLeave);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ResetLeave);
            this.groupBox1.Controls.Add(this.SaveLeave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SttafIdText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(51, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(685, 400);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LeaveEntry";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // EarnedLeave
            // 
            this.EarnedLeave.Location = new System.Drawing.Point(152, 187);
            this.EarnedLeave.Name = "EarnedLeave";
            this.EarnedLeave.Size = new System.Drawing.Size(282, 22);
            this.EarnedLeave.TabIndex = 34;
            // 
            // MaternityLeave
            // 
            this.MaternityLeave.Location = new System.Drawing.Point(152, 157);
            this.MaternityLeave.Name = "MaternityLeave";
            this.MaternityLeave.Size = new System.Drawing.Size(282, 22);
            this.MaternityLeave.TabIndex = 33;
            // 
            // Sickleave
            // 
            this.Sickleave.Location = new System.Drawing.Point(152, 123);
            this.Sickleave.Name = "Sickleave";
            this.Sickleave.Size = new System.Drawing.Size(282, 22);
            this.Sickleave.TabIndex = 32;
            // 
            // CasualLeave
            // 
            this.CasualLeave.Location = new System.Drawing.Point(152, 95);
            this.CasualLeave.Name = "CasualLeave";
            this.CasualLeave.Size = new System.Drawing.Size(282, 22);
            this.CasualLeave.TabIndex = 31;
            // 
            // DeleteLeave
            // 
            this.DeleteLeave.Location = new System.Drawing.Point(344, 231);
            this.DeleteLeave.Name = "DeleteLeave";
            this.DeleteLeave.Size = new System.Drawing.Size(90, 23);
            this.DeleteLeave.TabIndex = 30;
            this.DeleteLeave.Text = "Delete";
            this.DeleteLeave.UseVisualStyleBackColor = true;
            this.DeleteLeave.Click += new System.EventHandler(this.DeleteLeave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Earned Leave";
            // 
            // ResetLeave
            // 
            this.ResetLeave.Location = new System.Drawing.Point(248, 231);
            this.ResetLeave.Name = "ResetLeave";
            this.ResetLeave.Size = new System.Drawing.Size(90, 23);
            this.ResetLeave.TabIndex = 27;
            this.ResetLeave.Text = "Reset";
            this.ResetLeave.UseVisualStyleBackColor = true;
            // 
            // SaveLeave
            // 
            this.SaveLeave.Location = new System.Drawing.Point(152, 231);
            this.SaveLeave.Name = "SaveLeave";
            this.SaveLeave.Size = new System.Drawing.Size(90, 23);
            this.SaveLeave.TabIndex = 24;
            this.SaveLeave.Text = "Save";
            this.SaveLeave.UseVisualStyleBackColor = true;
            this.SaveLeave.Click += new System.EventHandler(this.SaveLeave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Maternity Leave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sick leave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Casual Leave";
            // 
            // SttafIdText
            // 
            this.SttafIdText.Location = new System.Drawing.Point(152, 56);
            this.SttafIdText.Margin = new System.Windows.Forms.Padding(4);
            this.SttafIdText.Name = "SttafIdText";
            this.SttafIdText.Size = new System.Drawing.Size(281, 22);
            this.SttafIdText.TabIndex = 1;
            this.SttafIdText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SttafIdText_KeyDown);
            this.SttafIdText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SttafIdText_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff ID";
            // 
            // LeaveInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "LeaveInfo";
            this.Text = "LeaveInfo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EarnedLeave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaternityLeave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sickleave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CasualLeave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SttafIdText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveLeave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteLeave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ResetLeave;
        private System.Windows.Forms.NumericUpDown EarnedLeave;
        private System.Windows.Forms.NumericUpDown MaternityLeave;
        private System.Windows.Forms.NumericUpDown Sickleave;
        private System.Windows.Forms.NumericUpDown CasualLeave;
    }
}