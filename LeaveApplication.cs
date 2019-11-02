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
    public partial class LeaveApplication : Form
    {
        public int stfID = 0;
        public LeaveApplication()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public Boolean IsValid(int TypeKey, string TypeValue, int totalLeave)
        {
            string query = "SELECT * FROM Leave_Info WHERE StaffID = " + Convert.ToInt32(StaffID.Text);
            int SickLeave = 0; int CasualLeave = 0; int MaternityLeave = 0; int EarnedLeave = 0;
            SqlDataReader reader = DbAccess.GetFromDB(query);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    SickLeave = Convert.ToInt32(reader["SickLeave"]);
                    CasualLeave = Convert.ToInt32(reader["CasualLeave"]);
                    MaternityLeave = Convert.ToInt32(reader["MaternityLeave"]);
                    EarnedLeave = Convert.ToInt32(reader["EarnedLeave"]);
                }
            }
            DbAccess.connnection.Close();
            if (TypeKey == 1)
            {
                if (DbAccess.recordExist("SELECT* FROM LeaveApply_Info WHERE StaffID = " + Convert.ToInt32(StaffID.Text) + " AND year(DateFrom) = '" + (int)DateTime.Now.Year + "' AND Type = '" + TypeValue + "'"))
                {
                    query = "SELECT SUM(Total) AS UsedLeave FROM LeaveApply_Info WHERE StaffID = " + Convert.ToInt32(StaffID.Text) + " AND year(DateFrom) = '" + (int)DateTime.Now.Year + "' AND Type = '" + TypeValue + "'";
                    reader = DbAccess.GetFromDB(query);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (totalLeave > (SickLeave - Convert.ToInt32(reader["UsedLeave"])))
                            {
                                DbAccess.connnection.Close();
                                return false;
                            }
                        }
                    }
                }
                else
                {
                    query = "SELECT SickLeave FROM Leave_Info WHERE StaffID = " + Convert.ToInt32(StaffID.Text);
                    reader = DbAccess.GetFromDB(query);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (totalLeave > Convert.ToInt32(reader["SickLeave"]))
                            {
                                DbAccess.connnection.Close();
                                return false;
                            }
                        }
                    }
                }
            }
            if (TypeKey == 2)
            {
                if (DbAccess.recordExist("SELECT* FROM LeaveApply_Info WHERE StaffID = " + Convert.ToInt32(StaffID.Text) + " AND year(DateFrom) = '" + (int)DateTime.Now.Year + "' AND Type = '" + TypeValue + "'"))
                {
                    query = "SELECT SUM(Total) AS UsedLeave FROM LeaveApply_Info WHERE StaffID = " + Convert.ToInt32(StaffID.Text) + " AND year(DateFrom) = '" + (int)DateTime.Now.Year + "' AND Type = '" + TypeValue + "'";
                    reader = DbAccess.GetFromDB(query);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (totalLeave > (CasualLeave - Convert.ToInt32(reader["UsedLeave"])))
                            {
                                DbAccess.connnection.Close();
                                return false;
                            }
                        }
                    }
                }
                else
                {
                    query = "SELECT CasualLeave FROM Leave_Info WHERE StaffID = " + Convert.ToInt32(StaffID.Text);
                    reader = DbAccess.GetFromDB(query);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (totalLeave > Convert.ToInt32(reader["CasualLeave"]))
                            {
                                DbAccess.connnection.Close();
                                return false;
                            }
                        }
                    }
                }
            }
            if (TypeKey == 3)
            {
                if (DbAccess.recordExist("SELECT* FROM LeaveApply_Info WHERE StaffID = " + Convert.ToInt32(StaffID.Text) + " AND year(DateFrom) = '" + (int)DateTime.Now.Year + "' AND Type = '" + TypeValue + "'"))
                {
                    query = "SELECT SUM(Total) AS UsedLeave FROM LeaveApply_Info WHERE StaffID = " + Convert.ToInt32(StaffID.Text) + " AND year(DateFrom) = '" + (int)DateTime.Now.Year + "' AND Type = '" + TypeValue + "'";
                    reader = DbAccess.GetFromDB(query);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (totalLeave > (MaternityLeave - Convert.ToInt32(reader["UsedLeave"])))
                            {
                                DbAccess.connnection.Close();
                                return false;
                            }
                        }
                    }
                }
                else
                {
                    query = "SELECT MaternityLeave FROM Leave_Info WHERE StaffID = " + Convert.ToInt32(StaffID.Text);
                    reader = DbAccess.GetFromDB(query);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (totalLeave > Convert.ToInt32(reader["MaternityLeave"]))
                            {
                                DbAccess.connnection.Close();
                                return false;
                            }
                        }
                    }
                }
            }
            if (TypeKey == 4)
            {
                if (DbAccess.recordExist("SELECT* FROM LeaveApply_Info WHERE StaffID = " + Convert.ToInt32(StaffID.Text) + " AND year(DateFrom) = '" + (int)DateTime.Now.Year + "' AND Type = '" + TypeValue + "'"))
                {
                    query = "SELECT SUM(Total) AS UsedLeave FROM LeaveApply_Info WHERE StaffID = " + Convert.ToInt32(StaffID.Text) + " AND year(DateFrom) = '" + (int)DateTime.Now.Year + "' AND Type = '" + TypeValue + "'";
                    reader = DbAccess.GetFromDB(query);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (totalLeave > (EarnedLeave - Convert.ToInt32(reader["UsedLeave"])))
                            {
                                DbAccess.connnection.Close();
                                return false;
                            }
                        }
                    }
                }
                else
                {
                    query = "SELECT EarnedLeave FROM Leave_Info WHERE StaffID = " + Convert.ToInt32(StaffID.Text);
                    reader = DbAccess.GetFromDB(query);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (totalLeave > Convert.ToInt32(reader["EarnedLeave"]))
                            {
                                DbAccess.connnection.Close();
                                return false;
                            }
                        }
                    }
                }
            }
            DbAccess.connnection.Close();
            return true;
        }

        private void LeaveApplication_Load(object sender, EventArgs e)
        {
            Loadtypecomboox();
        }

        private void SaveLeave_Click(object sender, EventArgs e)
        {
            string query = ""; int TypeKey = ((KeyValuePair<int, string>)LeaveaTypeCombo.SelectedItem).Key;
            String TypeValue = ((KeyValuePair<int, string>)LeaveaTypeCombo.SelectedItem).Value;

            if (StaffID.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Staff ID");
                StaffID.Focus();
                return;
            }

            if (TypeKey < 1)
            {
                MessageBox.Show("Please Enter Leave Type");
                LeaveaTypeCombo.Focus();
                return;
            }
            if (DateFrom.Text == "")
            {
                MessageBox.Show("Please Enter Date From");
                DateFrom.Focus();
                return;
            }

            if (DateTo.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Date To");
                DateTo.Focus();
                return;
            }

            if (TotalLeave.Text.Trim() == "")
            {
                TotalLeave.Focus();
                return;
            }
            else
            {
                if (!IsValid(TypeKey, TypeValue, Convert.ToInt32(TotalLeave.Text)))
                {
                    MessageBox.Show("You can not apply for more than ur assigned leave!!!");
                    return;
                }
            }

            try
            {
                if (hiddenText.Text == "")
                {
                    query = "INSERT INTO LeaveApply_Info(StaffID,Type,Datefrom,DateTo,Total) VALUES(" + Convert.ToInt32(StaffID.Text) + ",  '" + TypeValue + "',  '" + DateFrom.Value.ToString("yyyy/MM/dd") + "', '" + DateTo.Value.ToString("yyyy/MM/dd") + "', '" + TotalLeave.Text + "' )";
                }

                else
                {
                    query = "UPDATE LeaveApply_Info SET Type = '" + TypeValue + "',  Datefrom= '" + DateFrom.Value.ToString("yyyy/MM/dd") + "',DateTo = '" + DateTo.Value.ToString("yyyy/MM/dd") + "', Total = '" + TotalLeave.Text + "' WHERE Id = " + Convert.ToInt32(hiddenText.Text);
                }

                if (DbAccess.ExecuteToDB(query))
                {
                    if (hiddenText.Text == "")
                    {
                        MessageBox.Show("Saved Successfully!!!");
                    }
                    else
                    {
                        MessageBox.Show("Updated Successfully!!!");
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
            hiddenText.Text = "";
            StaffID.Text = "";
            stfIDtext.Text = "";
            LeaveaTypeCombo.SelectedIndex = 0;
            DateFrom.Value = DateTime.Now.Date;
            DateTo.Value = DateTime.Now.Date;
            TotalLeave.Text = "";

        }
        private void Loadtypecomboox()
        {
            Dictionary<int, string> Type = new Dictionary<int, string>();
            Type.Add(1, "Sick Leave");
            Type.Add(2, "Casual Leave");
            Type.Add(3, "Maternity Leave");
            Type.Add(4, "Earned Leave");

            LeaveaTypeCombo.DataSource = new BindingSource(Type, null);
            LeaveaTypeCombo.DisplayMember = "Value";
            LeaveaTypeCombo.ValueMember = "Key";

            int key = ((KeyValuePair<int, string>)LeaveaTypeCombo.SelectedItem).Key;
            //string value = ((KeyValuePair)District.SelectedItem).Value;




        }




        private void StaffID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LeaveaTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DateFrom_ValueChanged(object sender, EventArgs e)
        {
            if (DateFrom.Value > DateTo.Value)
            {
                MessageBox.Show("From Date Can not be greater tha TO date!!!");
                DateFrom.Value = DateTo.Value;
            }
            else
            {
                TotalLeave.Text = ((DateTo.Value - DateFrom.Value).Days).ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DeleteLeave_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";
                if (StaffID.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter Employee ID");
                    StaffID.Focus();
                    return;
                }
                query = "DELETE FROM LeaveApply_Info WHERE StaffID = " + stfID;

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

        private void StaffID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && StaffID.Text != "")
            {
                e.Handled = true;
                StaffID.ReadOnly = true;
                SetValue();
                DeleteLeave.Enabled = true;
            }
        }
        private void SetValue()
        {
            try
            {
                String query = "SELECT * FROM LeaveApply_Info WHERE StaffID = " + Convert.ToInt32(StaffID.Text);
                SqlDataReader reader = DbAccess.GetFromDB(query);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        StaffID.Text = reader["StaffID"].ToString();
                        LeaveaTypeCombo.Text = reader["Type"].ToString();
                        DateFrom.Text = reader["Datefrom"].ToString();
                        DateTo.Text = reader["DateTo"].ToString();
                        TotalLeave.Text = reader["Total"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

                stfID = Convert.ToInt32(StaffID.Text);
                DbAccess.connnection.Close();
            }
        }

        private void SearchBTTn_Click(object sender, EventArgs e)
        {
            leaveApplicationGridView.Rows.Clear();
            int SL = 1; string s1 = ""; string s2 = ""; string s3 = ""; string s4 = ""; string s5 = ""; string s6 = ""; string s7 = "";

            if (stfIDtext.Text == "")
            {
                MessageBox.Show("Please Enter Search ID!!!");
                return;
            }

            String query = "SELECT * FROM LeaveApply_Info WHERE StaffID = " + Convert.ToInt32(stfIDtext.Text);
            SqlDataReader reader = DbAccess.GetFromDB(query);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    s1 = SL.ToString();
                    s2 = reader["StaffID"].ToString();
                    s3 = reader["Type"].ToString();
                    s4 = reader["Datefrom"].ToString();
                    s5 = reader["DateTo"].ToString();
                    s6 = reader["Total"].ToString();
                    s7 = reader["Id"].ToString();
                    leaveApplicationGridView.Rows.Add(s1, s2, s3, s4, s5, s6, s7);
                    SL++;
                }
            }
            DbAccess.connnection.Close();
        }

        private void leaveApplicationGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StaffID.Text = leaveApplicationGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            LeaveaTypeCombo.SelectedIndex = LeaveaTypeCombo.FindStringExact(leaveApplicationGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            DateFrom.Value = Convert.ToDateTime(leaveApplicationGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            DateTo.Value = Convert.ToDateTime(leaveApplicationGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
            TotalLeave.Text = leaveApplicationGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            hiddenText.Text = leaveApplicationGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void DateTo_ValueChanged(object sender, EventArgs e)
        {
            if (DateFrom.Value > DateTo.Value)
            {
                MessageBox.Show("From Date Can not be greater tha TO date!!!");
                DateFrom.Value = DateTo.Value;
            }
            else
            {
                TotalLeave.Text = ((DateTo.Value - DateFrom.Value).Days).ToString();
            }

        }

        private void StaffID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
