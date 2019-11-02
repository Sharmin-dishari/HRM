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
    public partial class AddAnounce : Form
    {
        public int stfID = 0;
        public AddAnounce()
        {
            InitializeComponent();
        }

        private void SAveAdd_Click(object sender, EventArgs e)
        {
            string query = ""; int AnnonceKey = ((KeyValuePair<int, string>)AnnonceCombo.SelectedItem).Key;
            String AnnounceValue = ((KeyValuePair<int, string>)AnnonceCombo.SelectedItem).Value;

            if (AddStafID.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Staff ID");
                AddStafID.Focus();
                return;
            }

            if (AnnonceKey < 1)
            {
                MessageBox.Show("Please Enter Announce Type");
                AnnonceCombo.Focus();
                return;
            }
            if (AddDate.Text == "")
            {
                MessageBox.Show("Please Enter Announce Date");
                AddDate.Focus();
                return;
            }
         

            if (Addsubject.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Subject");
                Addsubject.Focus();
                return;
            }
            if (AddDescription.Text.Trim() == "")
            {
                MessageBox.Show("Please  Add Description ");
                AddDescription.Focus();
                return;
            }
           
            try
            {
                if (hidebox.Text == "")
                {
                    query = "INSERT INTO Announcement_Info(StaffID,AnnounceType,Date,Subject,Description) VALUES(" + Convert.ToInt32(AddStafID.Text) + ",  '" + AnnounceValue + "',  '" + AddDate.Value.ToString("yyyy/MM/dd") + "', '" + Addsubject.Text + "', '" + AddDescription.Text + "' )";
                }


                else
                {
                    query = "UPDATE Announcement_Info SET AnnounceType = '" + AnnounceValue + "', Date = '" + AddDate.Text + "', Subject= '" + Addsubject.Text + "',Description = '" + Addsubject.Text +  "' WHERE Id = " + Convert.ToInt32(hidebox.Text);
                }

                if (DbAccess.ExecuteToDB(query))
                {
                    if (hidebox.Text == "")
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
            hidebox.Text = "";
            AddStafID.Text = "";
            AnnonceCombo.SelectedIndex = 0;
            AddDate.Value = DateTime.Now.Date;
            Addsubject.Text = "";
            AddDescription.Text = "";

        }
        private void LoadSubcomboox()
        {
            Dictionary<int, string> SB = new Dictionary<int, string>();
            SB.Add(1, "Common");
            SB.Add(2, "Departmental");
            SB.Add(3, "Event");
            SB.Add(4, "Meeting");
            SB.Add(5, "Notice");

            AnnonceCombo.DataSource = new BindingSource(SB, null);
            AnnonceCombo.DisplayMember = "Value";
            AnnonceCombo.ValueMember = "Key";

            int key = ((KeyValuePair<int, string>)AnnonceCombo.SelectedItem).Key;
            //string value = ((KeyValuePair)District.SelectedItem).Value;




        }

        private void DeleteBtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";
                if (AddStafID.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter Employee ID");
                    AddStafID.Focus();
                    return;
                }
                query = "DELETE FROM Educational_Info WHERE StaffID = " + stfID;

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

        private void AddAnounce_Load(object sender, EventArgs e)
        {
            LoadSubcomboox();
        }

        private void SearchBTtN_Click(object sender, EventArgs e)
        {
            dataGridAnnounce.Rows.Clear();
            int SL = 1; string s1 = ""; string s2 = ""; string s3 = ""; string s4 = ""; string s5 = ""; string s6 = ""; string s7 = "";

            if (SearchStaf.Text == "")
            {
                MessageBox.Show("Please Enter Search ID!!!");
                return;
            }

            String query = "SELECT * FROM Announcement_Info WHERE StaffID = " + Convert.ToInt32(SearchStaf.Text);
            SqlDataReader reader = DbAccess.GetFromDB(query);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    s1 = SL.ToString();
                    s2 = reader["StaffID"].ToString();
                    s3 = reader["AnnounceType"].ToString();
                    s4 = reader["Date"].ToString();
                    s5 = reader["Subject"].ToString();
                    s6 = reader["Description"].ToString();
                    s7 = reader["Id"].ToString();
                    dataGridAnnounce.Rows.Add(s1, s2, s3, s4, s5, s6, s7);
                    SL++;
                }
            }
            DbAccess.connnection.Close();
        }

        private void dataGridAnnounce_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddStafID.Text = dataGridAnnounce.Rows[e.RowIndex].Cells[1].Value.ToString();
            AnnonceCombo.SelectedIndex = AnnonceCombo.FindStringExact(dataGridAnnounce.Rows[e.RowIndex].Cells[2].Value.ToString());
            AddDate.Value = Convert.ToDateTime(dataGridAnnounce.Rows[e.RowIndex].Cells[3].Value.ToString());
            Addsubject.Text = dataGridAnnounce.Rows[e.RowIndex].Cells[4].Value.ToString();
            AddDescription.Text = dataGridAnnounce.Rows[e.RowIndex].Cells[5].Value.ToString();
            hidebox.Text = dataGridAnnounce.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
    
}
