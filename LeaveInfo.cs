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
    public partial class LeaveInfo : Form
    {
        public int stfID = 0;
        public LeaveInfo()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SaveLeave_Click(object sender, EventArgs e)
        {
            string query = "";
            if (SttafIdText.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Employee ID");
                SttafIdText.Focus();
                return;
            }

           

            if (CasualLeave.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter The Number");
                CasualLeave.Focus();
                return;
            }

            if (Sickleave.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter The Number");
                Sickleave.Focus();
                return;
            }
            if (MaternityLeave.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Password");
                MaternityLeave.Focus();
                return;
            }
            if (EarnedLeave.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Number");
                EarnedLeave.Focus();
                return;
            }
            query = "SELECT COUNT(*) AS Count FROM Leave_Info WHERE StaffID = " + SttafIdText.Text + "";
            if (stfID == 0)
            {
                if (DbAccess.NumberOfRecords(query) > 0)
                {
                    MessageBox.Show("This username already exists! Please try another ID!");
                    SttafIdText.Focus();
                    return;
                }
            }
            else
            {
                if (DbAccess.NumberOfRecords(query) > 1)
                {
                    MessageBox.Show("This username already exists! Please try another ID!");
                    SttafIdText.Focus();
                    return;
                }
            }
            try
            {
                if (stfID == 0)
                {
                    query = "INSERT INTO Leave_Info(StaffID,CasualLeave,SickLeave,MaternityLeave,EarnedLeave) VALUES(" + Convert.ToInt32(SttafIdText.Text) + ", '" + Convert.ToInt32(CasualLeave.Text) + "',  '" + Convert.ToInt32(Sickleave.Text) + "', '" + Convert.ToInt32(MaternityLeave.Text) + "', '" + Convert.ToInt32(EarnedLeave.Text) + "' )";
                }


                else
                {
                    query = "UPDATE Leave_Info SET  CasualLeave = '" + Convert.ToInt32(CasualLeave.Text) + "', SickLeave = '" + Convert.ToInt32(Sickleave.Text) + "',MaternityLeave= '" + Convert.ToInt32(MaternityLeave.Text) + "',EarnedLeave = '" + Convert.ToInt32(EarnedLeave.Text) + "' WHERE StaffID = " + stfID;
                }

                if (DbAccess.ExecuteToDB(query))
                {
                    if (stfID == 0)
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
            SttafIdText.Text = "";
            CasualLeave.Text = "";
            Sickleave.Text = "";
            MaternityLeave.Text = "";
            EarnedLeave.Text = "";
            stfID = 0;
        }


        private void DeleteLeave_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";
                if (SttafIdText.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter Staff ID");
                    SttafIdText.Focus();
                    return;
                }
                query = "DELETE FROM Leave_Info WHERE StaffID = " + stfID;

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

        private void SttafIdText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && SttafIdText.Text != "")
            {
                e.Handled = true;
                SttafIdText.ReadOnly = true;
                SetValue();
                DeleteLeave.Enabled = true;
            }
        }
        private void SetValue()
        {
            try
            {
                String query = "SELECT * FROM Leave_Info WHERE StaffID = " + Convert.ToInt32(SttafIdText.Text);
                SqlDataReader reader = DbAccess.GetFromDB(query);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {


                        SttafIdText.Text = reader["StaffID"].ToString();
                        CasualLeave.Text = reader["CasualLeave"].ToString();
                        Sickleave.Text = reader["SickLeave"].ToString();
                        MaternityLeave.Text = reader["MaternityLeave"].ToString();
                        EarnedLeave.Text = reader["EarnedLeave"].ToString();


                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

                stfID = Convert.ToInt32(SttafIdText.Text);

                DbAccess.connnection.Close();
            }
        }

        private void SttafIdText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
    

