namespace HRM
{
    partial class CompanyTrain
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
            this.TrainingGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingInstitute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comStaffID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CompanyNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TrainingInsText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DurationText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TrainType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveTrain = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.traindate = new System.Windows.Forms.DateTimePicker();
            this.Hide = new System.Windows.Forms.TextBox();
            this.Deletetrain = new System.Windows.Forms.Button();
            this.TrainingNameText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.GroupBox();
            this.SearchButtontrain = new System.Windows.Forms.Button();
            this.Searchtrain = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrainingGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrainingGridView
            // 
            this.TrainingGridView.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.TrainingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrainingGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.StaffID,
            this.CompanyName,
            this.TrainingName,
            this.TrainingInstitute,
            this.Duration,
            this.TrainingType,
            this.TrainingDate,
            this.id});
            this.TrainingGridView.Location = new System.Drawing.Point(12, 288);
            this.TrainingGridView.Name = "TrainingGridView";
            this.TrainingGridView.Size = new System.Drawing.Size(844, 150);
            this.TrainingGridView.TabIndex = 1;
            this.TrainingGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TrainingGridView_CellDoubleClick);
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
            // CompanyName
            // 
            this.CompanyName.HeaderText = "CompanyName";
            this.CompanyName.Name = "CompanyName";
            // 
            // TrainingName
            // 
            this.TrainingName.HeaderText = "TrainingName";
            this.TrainingName.Name = "TrainingName";
            // 
            // TrainingInstitute
            // 
            this.TrainingInstitute.HeaderText = "TrainingInstitute";
            this.TrainingInstitute.Name = "TrainingInstitute";
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            // 
            // TrainingType
            // 
            this.TrainingType.HeaderText = "TrainingType";
            this.TrainingType.Name = "TrainingType";
            // 
            // TrainingDate
            // 
            this.TrainingDate.HeaderText = "TrainingDate";
            this.TrainingDate.Name = "TrainingDate";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff ID";
            // 
            // comStaffID
            // 
            this.comStaffID.Location = new System.Drawing.Point(141, 24);
            this.comStaffID.Name = "comStaffID";
            this.comStaffID.Size = new System.Drawing.Size(255, 22);
            this.comStaffID.TabIndex = 1;
            this.comStaffID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.comStaffID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comStaffID_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Company Name";
            // 
            // CompanyNameText
            // 
            this.CompanyNameText.Location = new System.Drawing.Point(141, 50);
            this.CompanyNameText.Name = "CompanyNameText";
            this.CompanyNameText.Size = new System.Drawing.Size(255, 22);
            this.CompanyNameText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trainng Institute";
            // 
            // TrainingInsText
            // 
            this.TrainingInsText.Location = new System.Drawing.Point(141, 110);
            this.TrainingInsText.Name = "TrainingInsText";
            this.TrainingInsText.Size = new System.Drawing.Size(255, 22);
            this.TrainingInsText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Duration";
            // 
            // DurationText
            // 
            this.DurationText.Location = new System.Drawing.Point(141, 138);
            this.DurationText.Name = "DurationText";
            this.DurationText.Size = new System.Drawing.Size(255, 22);
            this.DurationText.TabIndex = 7;
            this.DurationText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DurationText_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Training Type";
            // 
            // TrainType
            // 
            this.TrainType.Location = new System.Drawing.Point(141, 163);
            this.TrainType.Name = "TrainType";
            this.TrainType.Size = new System.Drawing.Size(255, 22);
            this.TrainType.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Training Date";
            // 
            // SaveTrain
            // 
            this.SaveTrain.Location = new System.Drawing.Point(154, 222);
            this.SaveTrain.Name = "SaveTrain";
            this.SaveTrain.Size = new System.Drawing.Size(139, 23);
            this.SaveTrain.TabIndex = 12;
            this.SaveTrain.Text = "Add Training info";
            this.SaveTrain.UseVisualStyleBackColor = true;
            this.SaveTrain.Click += new System.EventHandler(this.SaveTrain_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.traindate);
            this.groupBox1.Controls.Add(this.Hide);
            this.groupBox1.Controls.Add(this.Deletetrain);
            this.groupBox1.Controls.Add(this.TrainingNameText);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.SaveTrain);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TrainType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DurationText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TrainingInsText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CompanyNameText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comStaffID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training Info";
            // 
            // traindate
            // 
            this.traindate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.traindate.Location = new System.Drawing.Point(141, 189);
            this.traindate.Name = "traindate";
            this.traindate.Size = new System.Drawing.Size(255, 22);
            this.traindate.TabIndex = 17;
            // 
            // Hide
            // 
            this.Hide.Location = new System.Drawing.Point(478, 27);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(100, 22);
            this.Hide.TabIndex = 16;
            this.Hide.Visible = false;
            // 
            // Deletetrain
            // 
            this.Deletetrain.Location = new System.Drawing.Point(324, 223);
            this.Deletetrain.Name = "Deletetrain";
            this.Deletetrain.Size = new System.Drawing.Size(75, 23);
            this.Deletetrain.TabIndex = 15;
            this.Deletetrain.Text = "Delete";
            this.Deletetrain.UseVisualStyleBackColor = true;
            this.Deletetrain.Click += new System.EventHandler(this.Deletetrain_Click);
            // 
            // TrainingNameText
            // 
            this.TrainingNameText.Location = new System.Drawing.Point(141, 82);
            this.TrainingNameText.Name = "TrainingNameText";
            this.TrainingNameText.Size = new System.Drawing.Size(255, 22);
            this.TrainingNameText.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Training Name";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Search.Controls.Add(this.SearchButtontrain);
            this.Search.Controls.Add(this.Searchtrain);
            this.Search.Controls.Add(this.label8);
            this.Search.Location = new System.Drawing.Point(646, 56);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(281, 118);
            this.Search.TabIndex = 4;
            this.Search.TabStop = false;
            this.Search.Text = "Search";
            // 
            // SearchButtontrain
            // 
            this.SearchButtontrain.Location = new System.Drawing.Point(99, 66);
            this.SearchButtontrain.Name = "SearchButtontrain";
            this.SearchButtontrain.Size = new System.Drawing.Size(75, 23);
            this.SearchButtontrain.TabIndex = 17;
            this.SearchButtontrain.Text = "Search";
            this.SearchButtontrain.UseVisualStyleBackColor = true;
            this.SearchButtontrain.Click += new System.EventHandler(this.SearchButtontrain_Click);
            // 
            // Searchtrain
            // 
            this.Searchtrain.Location = new System.Drawing.Point(73, 28);
            this.Searchtrain.Name = "Searchtrain";
            this.Searchtrain.Size = new System.Drawing.Size(193, 20);
            this.Searchtrain.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Staff ID";
            // 
            // CompanyTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.TrainingGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "CompanyTrain";
            this.Text = "CompanyTrain";
            ((System.ComponentModel.ISupportInitialize)(this.TrainingGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView TrainingGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox comStaffID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CompanyNameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TrainingInsText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DurationText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TrainType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SaveTrain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TrainingNameText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingInstitute;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Button Deletetrain;
        private System.Windows.Forms.GroupBox Search;
        private System.Windows.Forms.Button SearchButtontrain;
        private System.Windows.Forms.TextBox Searchtrain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Hide;
        private System.Windows.Forms.DateTimePicker traindate;
    }
}