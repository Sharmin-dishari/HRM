using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HRM
{
    public partial class OfficialInfo : Form
    {
        public int stfID = 0;
        public OfficialInfo()
        {
            InitializeComponent();
        }


        private void OFSaveButton_Click(object sender, EventArgs e)
        {

            string query = ""; int DepartmentKey = ((KeyValuePair<int, string>)DeptcomboBox.SelectedItem).Key;
            String DepartmentValue = ((KeyValuePair<int, string>)DeptcomboBox.SelectedItem).Value;
            String DesignationValue = ((KeyValuePair<int, string>)DesigcomboBox.SelectedItem).Value;
            String BloodValue = ((KeyValuePair<int, string>)BloodcomboBox.SelectedItem).Value;
            String StatusValue = ((KeyValuePair<int, string>)Statuscombo.SelectedItem).Value;
            string que = ""; int DesignationKey = ((KeyValuePair<int, string>)DesigcomboBox.SelectedItem).Key;
            string qu = ""; int BloodKey = ((KeyValuePair<int, string>)BloodcomboBox.SelectedItem).Key;
            string q = ""; int StatusKey = ((KeyValuePair<int, string>)Statuscombo.SelectedItem).Key;

            if (StaftextBox.Text == "")
            {
                query = "SELECT Count(*) AS Count FROM Official_Info";
                int rowsCount = DbAccess.NumberOfRecords(query) + 1;
                stfID = Convert.ToInt32(DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + rowsCount.ToString());
            }
            if (StaffNatext.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Staff Name");
                StaffNatext.Focus();
                return;
            }

            if (DepartmentKey < 1)
            {
                MessageBox.Show("Please Enter Department");
                DeptcomboBox.Focus();
                return;
            }
            if (DesignationKey < 1)
            {
                MessageBox.Show("Please Enter designation");
                DesigcomboBox.Focus();
                return;
            }

            if (EXPText.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Experience");
                EXPText.Focus();
                return;
            }
            if (BloodKey < 1)
            {
                MessageBox.Show("Please Enter BloodGroup");
                BloodcomboBox.Focus();
                return;
            }
            if (joindateTimePicker.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Time");
                joindateTimePicker.Focus();
                return;
            }
            if (NationaText.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Nationality");
                NationaText.Focus();
                return;
            }
            if (StatusKey < 1)
            {
                MessageBox.Show("Please Enter Status");
                Statuscombo.Focus();
                return;
            }
            try
            {
                if (StaftextBox.Text == "")
                {
                    query = "INSERT INTO Official_Info(StaffID,StaffName,Department,Designation,AgeExp,BloodGroup,JoiningDate,Nationality,Status ) VALUES(" + stfID + ", '" + StaffNatext.Text + "',  '" + DepartmentValue + "', '" + DesignationValue + "', " + Convert.ToInt32(EXPText.Text) + ", '" + BloodValue + "' , '" + joindateTimePicker.Value.ToString("yyyy/MM/dd") + "',  '" + NationaText.Text + "',  '" + StatusValue + "' )";
                }
                else
                {
                    query = "UPDATE Official_Info SET StaffName = '" + StaffNatext.Text + "' ,Department = '" + DepartmentValue + "', Designation = '" + DesignationValue + "',  AgeExp= '" + Convert.ToInt32(EXPText.Text)+ "',BloodGroup = '" + BloodValue + "', JoiningDate = '" + joindateTimePicker.Value.ToString("yyyy/MM/dd") + "',Nationality = '" + NationaText.Text + "',Status = '" + StatusValue + "' WHERE StaffID = " + Convert.ToInt32(StaftextBox.Text);
                }

                if (DbAccess.ExecuteToDB(query))
                {
                    if(stfID != 0)
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
        private void LoadCombox()
        {

            Dictionary<int, string> Dept = new Dictionary<int, string>();
            Dept.Add(1, "Marchandising");
            Dept.Add(2, "Sales");
            Dept.Add(3, "Accounts");
            Dept.Add(4, "Finance");
            Dept.Add(5, "Production");
            Dept.Add(6, "Export");
            Dept.Add(7, "IT");
            DeptcomboBox.DataSource = new BindingSource(Dept, null);
            DeptcomboBox.DisplayMember = "Value";
            DeptcomboBox.ValueMember = "Key";

            deparCombo.DataSource = new BindingSource(Dept, null);
            deparCombo.DisplayMember = "Value";
            deparCombo.ValueMember = "Key";

            int key = ((KeyValuePair<int, string>)DeptcomboBox.SelectedItem).Key;
            //string value = ((KeyValuePair)District.SelectedItem).Value;





            Dictionary<int, string> desig = new Dictionary<int, string>();
            desig.Add(1, "GM");
            desig.Add(2, "AGM");
            desig.Add(3, "DGM");
            desig.Add(4, "Chief Executive Officer");
            desig.Add(5, "Chief Financial Officer");
            desig.Add(6, "Chief Technology Officer");
            desig.Add(7, "Chief Marketing Officer");

            DesigcomboBox.DataSource = new BindingSource(desig, null);
            DesigcomboBox.DisplayMember = "Value";
            DesigcomboBox.ValueMember = "Key";

            int ke = ((KeyValuePair<int, string>)DesigcomboBox.SelectedItem).Key;
            //string value = ((KeyValuePair)District.SelectedItem).Value;




            Dictionary<int, string> blood = new Dictionary<int, string>();
            blood.Add(1, "A+");
            blood.Add(2, "O+");
            blood.Add(3, "AB+");
            blood.Add(4, "O-");
            blood.Add(5, "A-");

            BloodcomboBox.DataSource = new BindingSource(blood, null);
            BloodcomboBox.DisplayMember = "Value";
            BloodcomboBox.ValueMember = "Key";

            int k = ((KeyValuePair<int, string>)BloodcomboBox.SelectedItem).Key;
            //string value = ((KeyValuePair)District.SelectedItem).Value;

            Dictionary<int, string> Status = new Dictionary<int, string>();
            Status.Add(1, "Active");
            Status.Add(2, "Inactive");


            Statuscombo.DataSource = new BindingSource(Status, null);
            Statuscombo.DisplayMember = "Value";
            Statuscombo.ValueMember = "Key";

            int kw = ((KeyValuePair<int, string>)BloodcomboBox.SelectedItem).Key;
        }



        private void Reset()

        {
            StaftextBox.Text = "";
            StaffNatext.Text = "";
            EXPText.Text = "";
            joindateTimePicker.Value = DateTime.Now.Date;
            NationaText.Text = "";
            DeptcomboBox.SelectedIndex = 0;
            DesigcomboBox.SelectedIndex = 0;
            BloodcomboBox.SelectedIndex = 0;
            Statuscombo.SelectedIndex = 0;
            OfficialDataGridView.Rows.Clear();
            sdtext.Text = "";

            //DeptcomboBox.DataSource = null;
            //DeptcomboBox.Items.Clear();
            //DesigcomboBox.DataSource = null;
            //DesigcomboBox.Items.Clear();
            //BloodcomboBox.DataSource = null;
            //BloodcomboBox.Items.Clear();
        }
        private void OFResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void OfficialInfo_Load(object sender, EventArgs e)
        {
            LoadCombox();
           
        }

        private void srcBtn_Click(object sender, EventArgs e)
        {
            OfficialDataGridView.Rows.Clear();
            int SL = 1; string s1 = ""; string s2 = ""; string s3 = ""; string s4 = ""; string s5 = ""; string s6 = ""; string s7 = ""; string s8 = ""; string s9 = ""; string s10 = "";
            String DeptValue = ((KeyValuePair<int, string>)deparCombo.SelectedItem).Value;
            int DeptKey = ((KeyValuePair<int, string>)deparCombo.SelectedItem).Key;
            String query = "SELECT * FROM Official_Info WHERE Department = '" + DeptValue + "'";
            
            if (sdtext.Text != "")
            {
                query = query + " AND StaffID = " + Convert.ToInt32(sdtext.Text);
            }
            SqlDataReader reader = DbAccess.GetFromDB(query);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    s1 = SL.ToString();
                    s2 = reader["StaffID"].ToString();
                    s3 = reader["StaffName"].ToString();
                    s4 = reader["Department"].ToString();
                    s5 = reader["Designation"].ToString();
                    s6 = reader["AgeExp"].ToString();
                    s7 = reader["BloodGroup"].ToString();
                    s8 = reader["JoiningDate"].ToString();
                    s9 = reader["Nationality"].ToString();
                    s10 = reader["Status"].ToString();
                    OfficialDataGridView.Rows.Add(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10);
                    SL++;
                }
            }
            DbAccess.connnection.Close();
        }
        
    

            private void OFdeletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";
                if (sdtext.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter Employee ID");
                    sdtext.Focus();
                    return;
                }
                query = "DELETE FROM Official_Info WHERE EmpID = " + StaffID;

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void OfficialDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StaftextBox.Text = OfficialDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            StaffNatext.Text = OfficialDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            DeptcomboBox.SelectedIndex = DeptcomboBox.FindStringExact(OfficialDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            DesigcomboBox.SelectedIndex = DesigcomboBox.FindStringExact(OfficialDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
            EXPText.Text = OfficialDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            BloodcomboBox.SelectedIndex = BloodcomboBox.FindStringExact(OfficialDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString());
            joindateTimePicker.Value = Convert.ToDateTime(OfficialDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString());
            NationaText.Text = OfficialDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            Statuscombo.SelectedIndex = Statuscombo.FindStringExact(OfficialDataGridView.Rows[e.RowIndex].Cells[9].Value.ToString());

        }
    }
}




