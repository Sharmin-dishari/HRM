using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRM
{
 
    public partial class CompanyTrain : Form
    {
        public int stfID = 0;
        public CompanyTrain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveTrain_Click(object sender, EventArgs e)
        {

            string query = "";
            if (comStaffID.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Staff ID");
                comStaffID.Focus();
                return;
            }

            if (CompanyNameText.Text == "")
            {
                MessageBox.Show("Company Name");
                CompanyNameText.Focus();
                return;
            }


            if (TrainingNameText.Text == "")
            {
                MessageBox.Show("Please Enter Training Name");
                TrainingNameText.Focus();
                return;
            }


            if (TrainingInsText.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Training Institute");
                TrainingInsText.Focus();
                return;
            }
            if (DurationText.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Duration Time");
                DurationText.Focus();
                return;
            }
            if (TrainType.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Training type");
                TrainType.Focus();
                return;
            }
            if (traindate.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Training Date");
                traindate.Focus();
                return;
            }
            
            try
            {
                if (Hide.Text == "")
                {
                    query = "INSERT INTO Training_Info(StaffID,Companyname,TrainingName,TrainingInstitute,Duration,TrainingType,TrainingDate) VALUES(" + Convert.ToInt32(comStaffID.Text) + ",  '" + CompanyNameText.Text + "',  '" + TrainingNameText.Text + "', '" + TrainingInsText.Text + "', '" + DurationText.Text + "', '" + TrainType.Text + "', '" + traindate.Value.ToString("yyyy/MM/dd") + "' )";
                }


                else
                {
                    query = "UPDATE Training_Info SET Companyname = '" + CompanyNameText.Text + "',TrainingInstitute = '" + TrainingInsText.Text + "', Duration= '" + DurationText.Text + "',TrainingType = '" + TrainType.Text + "',TrainingDate = '" + traindate.Value.ToString("yyyy/MM/dd") + "' WHERE ID= " + Convert.ToInt32(Hide.Text);
                }

                if (DbAccess.ExecuteToDB(query))
                {
                    if (Hide.Text == "")
                    {
                        MessageBox.Show("Saved Successfully!!!");
                    }
                    else
                    {
                        MessageBox.Show("Update Successfully!!!");
                    }


                }
                else
                {
                    MessageBox.Show("Failed To Save!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error!!!");
            }
            finally
            {
                Reset();
            }

        

    }
        private void Reset()

        {
            comStaffID.Text = "";
            CompanyNameText.Text = "";
            TrainingNameText.Text = "";
            TrainingInsText.Text = "";
            DurationText.Text = "";
            TrainType.Text = "";

            traindate.Value = DateTime.Now.Date;
           

        }

        private void Deletetrain_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";
                if (comStaffID.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter Employee ID");
                    comStaffID.Focus();
                    return;
                }
                query = "DELETE FROM Training_Info WHERE StaffID = " + stfID;

                if (DbAccess.ExecuteToDB(query))
                {
                    if (stfID != 0)
                    {
                        MessageBox.Show("Delete Successfully!!!");
                    }
                    else
                    {
                        MessageBox.Show("Failed To Delete!!!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error!!!");
            }
            finally
            {
                Reset();
            }
        }

        private void SearchButtontrain_Click(object sender, EventArgs e)
        {
            TrainingGridView.Rows.Clear();
            int SL = 1; string s1 = ""; string s2 = ""; string s3 = ""; string s4 = ""; string s5 = ""; string s6 = ""; string s7 = ""; string s8 = ""; string s9 = "";

            if (Searchtrain.Text == "")
            {
                MessageBox.Show("Please Enter Search ID!!!");
                return;
            }

            String query = "SELECT * FROM Training_Info WHERE StaffID = " + Convert.ToInt32(Searchtrain.Text);
            SqlDataReader reader = DbAccess.GetFromDB(query);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    s1 = SL.ToString();
                    s2 = reader["StaffID"].ToString();
                    s3 = reader["Companyname"].ToString();
                    s4 = reader["TrainingName"].ToString();
                    s5 = reader["TrainingInstitute"].ToString();
                    s6 = reader["Duration"].ToString();
                    s7 = reader["TrainingType"].ToString();
                    s8 = reader["TrainingDate"].ToString();
                    s9 = reader["Id"].ToString();
                    TrainingGridView.Rows.Add(s1, s2, s3, s4, s5, s6, s7, s8, s9);
                    SL++;
                }
            }
            DbAccess.connnection.Close();
        }

        private void TrainingGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            comStaffID.Text = TrainingGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            CompanyNameText.Text = TrainingGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            TrainingNameText.Text = TrainingGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            TrainingInsText.Text = TrainingGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            DurationText.Text = TrainingGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            TrainType.Text = TrainingGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            traindate.Value = Convert.ToDateTime(TrainingGridView.Rows[e.RowIndex].Cells[7].Value.ToString());
            Hide.Text = TrainingGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            
        }

        private void DurationText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void comStaffID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
