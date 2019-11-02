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
    public partial class AttendanceReport : Form
    {
        public AttendanceReport()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (SearchStaffID.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Staff ID");
                SearchStaffID.Focus();
                return;
            }
            if (Datefrom.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Date From ID");
                Datefrom.Focus();
                return;
            }
            if (dateto.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Date To ID");
                dateto.Focus();
                return;
            }

            AttenDanceGRID.Rows.Clear();
            int SL = 1; string s1 = ""; string s2 = ""; string s3 = ""; string s4 = ""; string s5 = ""; string s6 = ""; string s7 = ""; string s8 = ""; string s9 = ""; string s10 = ""; string s11 = "";

            string query = "SELECT * FROM AttendanceReportView WHERE StaffID = " + Convert.ToInt32(SearchStaffID.Text) + " AND Date BETWEEN '" +Datefrom.Value.ToString("yyyy/MM/dd")+ "' AND '" + dateto.Value.ToString("yyyy/MM/dd") + "'";

            SqlDataReader reader = DbAccess.GetFromDB(query);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    s1 = SL.ToString();
                    s2 = SearchStaffID.Text.ToString();
                    s3 = reader["StaffName"].ToString();
                    s4 = reader["Department"].ToString();
                    s5 = reader["Date"].ToString();
                    s6 = reader["InTime"].ToString();
                    s7 = reader["OutTime"].ToString();
                    s8 = reader["Status"].ToString();
                 
                    AttenDanceGRID.Rows.Add(s1, s2, s3, s4, s5, s6, s7, s8);
                    SL++;
                }
            }
            DbAccess.connnection.Close();

        }
        private void Reset()

        {
            SearchStaffID.Text = "";
            Datefrom.Value = DateTime.Now.Date;
            dateto.Value = DateTime.Now.Date;
            AttenDanceGRID.Rows.Clear();
            
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (AttenDanceGRID.Rows.Count < 1)
                {
                    MessageBox.Show("No rows exist to export exddcdwwwel!!!");
                    return;
                }

                if (AttenDanceGRID.Rows.Count > 0)
                {

                    Microsoft.Office.Interop.Excel._Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 0; i < AttenDanceGRID.Columns.Count; i++)
                    {
                        XcelApp.Cells[1, (i + 1)] = AttenDanceGRID.Columns[i].HeaderText;
                    }
                    for (int i = 0; i < AttenDanceGRID.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < AttenDanceGRID.Columns.Count; j++)
                        {
                            XcelApp.Cells[(i + 2), ((j + 1))] = " " + AttenDanceGRID.Rows[i].Cells[j].Value.ToString();
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

        private void SearchStaffID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Datefrom_ValueChanged(object sender, EventArgs e)
        {
            if (Datefrom.Value > dateto.Value)
            {
                MessageBox.Show("From Date Can not be greater tha TO date!!!");
                Datefrom.Value = dateto.Value;
            }
            
        }
    }
}
