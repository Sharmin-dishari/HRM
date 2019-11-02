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
    public partial class EducationInfo : Form
    {
        public int stfID = 0;
        public EducationInfo()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void eduSaveButton_Click(object sender, EventArgs e)
        {
            string query = ""; int studyKey = ((KeyValuePair<int, string>)studyCombo.SelectedItem).Key;
            String studyValue = ((KeyValuePair<int, string>)studyCombo.SelectedItem).Value;
            string quer = ""; int BoardKey = ((KeyValuePair<int, string>)BoardCombo.SelectedItem).Key;
            String BoardValue = ((KeyValuePair<int, string>)BoardCombo.SelectedItem).Value;
            if (stIText.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Staff ID");
                stIText.Focus();
                return;
            }

            
            if (studyKey < 1)
            {
                MessageBox.Show("Please Enter Studylevel");
                studyCombo.Focus();
                return;
            }
            if (NameofInstitutetext.Text == "")
            {
                MessageBox.Show("Please Enter Name Of Institute");
                NameofInstitutetext.Focus();
                return;
            }
            if (BoardKey < 1)
            {
                MessageBox.Show("Please Enter Your Board");
                BoardCombo.Focus();
                return;
            }

            if (Yeartext.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Your passing year");
                Yeartext.Focus();
                return;
            }
            if (CGPAtext.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Your CGPA");
                CGPAtext.Focus();
                return;
            }
            query = "SELECT COUNT(*) AS Count FROM Educational_Info WHERE StaffID = " + stIText.Text + "";
            if (stfID == 0)
            {
                if (DbAccess.NumberOfRecords(query) > 0)
                {
                    MessageBox.Show("This username already exists! Please try another ID!");
                    stIText.Focus();
                    return;
                }
            }
            else
            {
                if (DbAccess.NumberOfRecords(query) > 1)
                {
                    MessageBox.Show("This username already exists! Please try another ID!");
                    stIText.Focus();
                    return;
                }
            }
            try
            {
                if (stfID == 0)
                {
                    query = "INSERT INTO Educational_Info(StaffID,SudyLevel,NameOfIns,Board,PassingYear,CGPA) VALUES(" + Convert.ToInt32(stIText.Text) + ",  '" + studyValue + "',  '" + NameofInstitutetext.Text + "', '" + BoardValue + "', '" + Yeartext.Text + "', '" + CGPAtext.Text + "' )";
                }


                else
                {
                    query = "UPDATE Educational_Info SET SudyLevel = '" + studyValue + "', NameOfIns = '" + NameofInstitutetext.Text + "',  Board= '" + BoardValue + "',PassingYear = '" + Yeartext.Text + "', CGPA = '" + CGPAtext.Text +"' WHERE StaffID = " + stfID;
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
        private void stIText_TextChanged(object sender, EventArgs e)
        {

        }

        private void EducationInfo_Load(object sender, EventArgs e)
        {
            Loadcomboox();
        }
        private void Reset()

        {
            stIText.Text = "";
            
            NameofInstitutetext.Text = "";
            BoardCombo.SelectedIndex = 0;
            studyCombo.SelectedIndex = 0;
            Yeartext.Text = "";
            CGPAtext.Text = "";

        }
        private void Loadcomboox()
        {
            Dictionary<int, string> SD = new Dictionary<int, string>();
            SD.Add(1, "SSC");
            SD.Add(2, "HSC");
            SD.Add(3, "Post Graduate");
            SD.Add(4, "Graduate");

            studyCombo.DataSource = new BindingSource(SD, null);
            studyCombo.DisplayMember = "Value";
            studyCombo.ValueMember = "Key";

            int key = ((KeyValuePair<int, string>)studyCombo.SelectedItem).Key;
            //string value = ((KeyValuePair)District.SelectedItem).Value;





            Dictionary<int, string> Board = new Dictionary<int, string>();
            Board.Add(1, "Dhaka");
            Board.Add(2, "Cumilla");
            Board.Add(3, "Khulna");
            Board.Add(4, "Chattogram");
            Board.Add(5, "Gazipur");

            BoardCombo.DataSource = new BindingSource(Board, null);
            BoardCombo.DisplayMember = "Value";
            BoardCombo.ValueMember = "Key";

            int ke = ((KeyValuePair<int, string>)BoardCombo.SelectedItem).Key;
            //string value = ((KeyValuePair)District.SelectedItem).Value;
        }

        private void edudeletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";
                if (stIText.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter Employee ID");
                    stIText.Focus();
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

        private void stIText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && stIText.Text != "")
            {
                e.Handled = true;
                stIText.ReadOnly = true;
                SetValue();
                edudeletebtn.Enabled = true;
            }
        }
            private void SetValue()
            {
                try
                {
                    String query = "SELECT * FROM Educational_Info WHERE StaffID = " + Convert.ToInt32(stIText.Text);
                    SqlDataReader reader = DbAccess.GetFromDB(query);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                           

                        stIText.Text = reader["StaffID"].ToString();
                      
                        studyCombo.Text = reader["SudyLevel"].ToString();
                        NameofInstitutetext.Text = reader["NameOfIns"].ToString();
                        BoardCombo.Text = reader["Board"].ToString();
                        Yeartext.Text = reader["PassingYear"].ToString();
                        CGPAtext.Text = reader["CGPA"].ToString();
                           

                        }
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {

                    stfID = Convert.ToInt32(stIText.Text);

                    DbAccess.connnection.Close();
                }
            }

        private void Yeartext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void CGPAtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void stIText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
