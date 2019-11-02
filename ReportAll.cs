using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM
{
    public partial class ReportAll : Form
    {
        public ReportAll()
        {
            InitializeComponent();
        }

        private void Reportsearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT StaffName, Department, Designation, JoiningDate, Contact, [Present Address], BasicSalary, Total, Status FROM MasterReportView"; int DepartmentKey = ((KeyValuePair<int, string>)DeportCombo.SelectedItem).Key;
            String DepartmentValue = ((KeyValuePair<int, string>)DeportCombo.SelectedItem).Value;
            string quer = ""; int StatusKey = ((KeyValuePair<int, string>)StatusCombo.SelectedItem).Key;
            String StatusValue = ((KeyValuePair<int, string>)StatusCombo.SelectedItem).Value;

            if (ReportID.Text.Trim() == "" && DepartmentKey < 0 && StatusKey < 0)
            {
                MessageBox.Show("Please Select Atleast One Criteria!!!");
                return;
            }

            if(ReportID.Text.Trim() != "")
            {
                query = query + " WHERE StaffID = " + Convert.ToInt32(ReportID.Text)+"";
            }

            if (DepartmentKey > 0)
            {
                query = query.Contains("WHERE") == true ? query + " AND Department = '" + DepartmentValue + "'" : query + " WHERE Department = '" + DepartmentValue + "'";
            }
            if (StatusKey > 0)
            {
                query = query.Contains("WHERE") == true ? query + " AND Status = '" + StatusValue + "'" : query + " WHERE Status = '" + StatusValue + "'";
            }

            ReportDataGrid.Rows.Clear();
            int SL = 1; string s1 = ""; string s2 = ""; string s3 = ""; string s4 = ""; string s5 = ""; string s6 = ""; string s7 = ""; string s8 = ""; string s9 = ""; string s10 = ""; string s11 = "";

            SqlDataReader reader = DbAccess.GetFromDB(query);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    s1 = SL.ToString();
                    s2 = ReportID.Text.ToString();
                    s3 = reader["StaffName"].ToString();
                    s4 = reader["Department"].ToString();
                    s5 = reader["Designation"].ToString();
                    s6 = reader["JoiningDate"].ToString();
                    s7 = reader["Contact"].ToString();
                    s8 = reader["Present Address"].ToString();
                    s9 = reader["BasicSalary"].ToString();
                    s10 = reader["Total"].ToString();
                    s11 = reader["Status"].ToString();
                    ReportDataGrid.Rows.Add(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11);
                    SL++;
                }
            }
            DbAccess.connnection.Close();

        }
        private void LoadReportcomboox()
        {
            Dictionary<int, string> Dept = new Dictionary<int, string>();
            Dept.Add(1, "Sales");
            Dept.Add(2, "Accounts");
            Dept.Add(3, "Personal");
            Dept.Add(4, "Production");
            Dept.Add(5, "Export");
            Dept.Add(6, "IT");

            DeportCombo.DataSource = new BindingSource(Dept, null);
            DeportCombo.DisplayMember = "Value";
            DeportCombo.ValueMember = "Key";

            Dictionary<int, string> Status = new Dictionary<int, string>();
            Status.Add(1, "Active");
            Status.Add(2, "Inactive");
           

            StatusCombo.DataSource = new BindingSource(Status, null);
            StatusCombo.DisplayMember = "Value";
            StatusCombo.ValueMember = "Key";

            int key = ((KeyValuePair<int, string>)DeportCombo.SelectedItem).Key;
            //string value = ((KeyValuePair)District.SelectedItem).Value;

            int ke = ((KeyValuePair<int, string>)StatusCombo.SelectedItem).Key;
            //string value = ((KeyValuePair)District.SelectedItem).Value;





        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReportDataGrid.Rows.Count < 1)
                {
                    MessageBox.Show("No rows exist to export exddcdwwwel!!!");
                    return;
                }

                if (ReportDataGrid.Rows.Count > 0)
                {

                    Microsoft.Office.Interop.Excel._Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 0; i < ReportDataGrid.Columns.Count; i++)
                    {
                        XcelApp.Cells[1, (i + 1)] = ReportDataGrid.Columns[i].HeaderText;
                    }
                    for (int i = 0; i < ReportDataGrid.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < ReportDataGrid.Columns.Count; j++)
                        {
                            XcelApp.Cells[(i + 2), ((j + 1))] = " " + ReportDataGrid.Rows[i].Cells[j].Value.ToString();
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

        private void ReportAll_Load(object sender, EventArgs e)
        {
            LoadReportcomboox();
        }
    
}
}

