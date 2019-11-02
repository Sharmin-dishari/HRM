using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM
{
    public partial class LeaveReort : Form
    {
        public LeaveReort()
        {
            InitializeComponent();
        }

        private void LeavereportBTN_Click(object sender, EventArgs e)
        {
            string query = ""; int YearKey = ((KeyValuePair<int, string>)YearCombo.SelectedItem).Key;
            String YearValue = ((KeyValuePair<int, string>)YearCombo.SelectedItem).Value;
            string quer = ""; int LeaveKey = ((KeyValuePair<int, string>)Leavetycombo.SelectedItem).Key;
            String LeaveValue = ((KeyValuePair<int, string>)Leavetycombo.SelectedItem).Value;

            if (LeaStaffID.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Staff ID");
                LeaStaffID.Focus();
                return;
            }

            if (YearKey < 0)
            {
                MessageBox.Show("Please Enter Year");
                YearCombo.Focus();
                return;
            }
            if (LeaveKey < 0)
            {
                MessageBox.Show("Please Enter Leave Type");
                Leavetycombo.Focus();
                return;
            }
            LeaveReportGridView.Rows.Clear();
            string colName = LeaveValue.Replace(" ", string.Empty);
            int SL = 1; string s1 = ""; string s2 = ""; string s3 = ""; string s4 = ""; string s5 = ""; string s6 = ""; string s7 = ""; string s8 = ""; string s9 = "";
            query = "SELECT StaffName, "+colName+", Department, Status, SUM(Total) AS TotalLeave FROM LeaveReportView WHERE StaffID = " + Convert.ToInt32(LeaStaffID.Text)+"AND Type = '"+ LeaveValue + "' AND year(DateFrom) = '"+ YearValue + "' group by StaffName, Department, Status, "+ colName;
            SqlDataReader reader = DbAccess.GetFromDB(query);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    s1 = SL.ToString();
                    s2 = LeaStaffID.Text.ToString();
                    s3 = reader["StaffName"].ToString();
                    s4 = reader["Department"].ToString();
                    s5 = YearValue;
                    s6 = reader[colName].ToString();
                    s7 = reader["TotalLeave"].ToString();
                    s8 = (Convert.ToInt32(s6) - Convert.ToInt32(s7)).ToString();
                    s9 = reader["Status"].ToString();
                    LeaveReportGridView.Rows.Add(s1, s2, s3, s4, s5, s6, s7, s8, s9);
                    SL++;
                }
            }
            DbAccess.connnection.Close();
        }
        private void LoadLeaveReportcomboox()
        {
            Dictionary<int, string> Year = new Dictionary<int, string>();
            Year.Add(1, "2019");
            Year.Add(2, "2018");
            Year.Add(3, "2017");
            Year.Add(4, "2016");

            YearCombo.DataSource = new BindingSource(Year, null);
            YearCombo.DisplayMember = "Value";
            YearCombo.ValueMember = "Key";

            Dictionary<int, string> Leave = new Dictionary<int, string>();
            Leave.Add(1, "Sick Leave");
            Leave.Add(2, "Casual Leave");
            Leave.Add(3, "Maternity Leave");
            Leave.Add(4, "Earned Leave");

            Leavetycombo.DataSource = new BindingSource(Leave, null);
            Leavetycombo.DisplayMember = "Value";
            Leavetycombo.ValueMember = "Key";

            int key = ((KeyValuePair<int, string>)Leavetycombo.SelectedItem).Key;
            //string value = ((KeyValuePair)District.SelectedItem).Value;

            int ke = ((KeyValuePair<int, string>)YearCombo.SelectedItem).Key;
            //string value = ((KeyValuePair)District.SelectedItem).Value;





        }

        private void LeaveReort_Load(object sender, EventArgs e)
        {
            LoadLeaveReportcomboox();
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (LeaveReportGridView.Rows.Count < 1)
                {
                    MessageBox.Show("No rows exist to export exddcdwwwel!!!");
                    return;
                }

                if (LeaveReportGridView.Rows.Count > 0)
                {

                    Microsoft.Office.Interop.Excel._Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 0; i < LeaveReportGridView.Columns.Count; i++)
                    {
                        XcelApp.Cells[1, (i + 1)] = LeaveReportGridView.Columns[i].HeaderText;
                    }
                    for (int i = 0; i < LeaveReportGridView.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < LeaveReportGridView.Columns.Count; j++)
                        {
                            XcelApp.Cells[(i + 2), ((j + 1))] = " " + LeaveReportGridView.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    XcelApp.Columns.AutoFit();
                    XcelApp.Rows.AutoFit();
                    XcelApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
        }
    }
}
