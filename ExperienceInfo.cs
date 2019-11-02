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
    public partial class ExperienceInfo : Form
    {
        public int stfID = 0;
        public ExperienceInfo()
        {
            InitializeComponent();
        }

        private void expSaveBtn_Click(object sender, EventArgs e)
        {
            string query = "";
            if (stIDTEXT.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Employee ID");
                stIDTEXT.Focus();
                return;
            }

           

            if (CompanyNameText.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Company Name");
                CompanyNameText.Focus();
                return;
            }

            if (Workedas.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Designation!");
                Workedas.Focus();
                return;
            }
            if (expdurnumbering.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Experience Year!");
                expdurnumbering.Focus();
                return;
            }
            if (joiiningText.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Your Joining Date");
                joiiningText.Focus();
                return;
            }
            if (ResignedDate.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Resigned Date");
                ResignedDate.Focus();
                return;
            }
            query = "SELECT COUNT(*) AS Count FROM Experience_Info WHERE StaffID = " + stIDTEXT.Text + "";
            if (stfID == 0)
            {
                if (DbAccess.NumberOfRecords(query) > 0)
                {
                    MessageBox.Show("This username already exists! Please try another ID!");
                    stIDTEXT.Focus();
                    return;
                }
            }
            else
            {
                if (DbAccess.NumberOfRecords(query) > 1)
                {
                    MessageBox.Show("This username already exists! Please try another ID!");
                    stIDTEXT.Focus();
                    return;
                }
            }
            try
            {
                if (stfID == 0)
                {
                    query = "INSERT INTO Experience_Info(StaffID,CompanyName,WorkedAs,ExpDur,JoiningDate,ResignedDate) VALUES(" + Convert.ToInt32(stIDTEXT.Text) + ",  '" + CompanyNameText.Text + "',  '" + Workedas.Text + "', '" + Convert.ToInt32(expdurnumbering.Text) + "', '" + joiiningText.Value.ToString("yyyy/MM/dd") + "', '" + ResignedDate.Value.ToString("yyyy/MM/dd") + "' )";
                }


                else
                {
                    query = "UPDATE Experience_Info SET CompanyName = '" + CompanyNameText.Text + "', WorkedAs = '" + Workedas.Text + "', ExpDur= '" + Convert.ToInt32(expdurnumbering.Text) + "',JoiningDate = '" + joiiningText.Value.ToString("yyyy/MM/dd") + "', ResignedDate = '" + ResignedDate.Value.ToString("yyyy/MM/dd") + "' WHERE StaffID = " + stfID;
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
            stIDTEXT.Text = "";
            CompanyNameText.Text = "";
            Workedas.Text = "";
            expdurnumbering.Text = "";

            joiiningText.Text = "";
            ResignedDate.Text = "";
            
            stfID = 0;
            
        }

        private void Workedas_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExperienceInfo_Load(object sender, EventArgs e)
        {

        }

        private void stIDTEXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && stIDTEXT.Text != "")
            {
                e.Handled = true;
                stIDTEXT.ReadOnly = true;
                SetValue();
                DeleteBTN.Enabled = true;
            }
        }
        private void SetValue()
        {
            try
            {
                String query = "SELECT * FROM Experience_Info WHERE StaffID = " + Convert.ToInt32(stIDTEXT.Text);
                SqlDataReader reader = DbAccess.GetFromDB(query);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {


                        stIDTEXT.Text = reader["StaffID"].ToString();
                       
                        CompanyNameText.Text = reader["CompanyName"].ToString();
                        Workedas.Text = reader["WorkedAs"].ToString();
                        expdurnumbering.Text = reader["ExpDur"].ToString();
                        joiiningText.Text = reader["JoiningDate"].ToString();
                        ResignedDate.Text = reader["ResignedDate"].ToString();


                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

                stfID = Convert.ToInt32(stIDTEXT.Text);

                DbAccess.connnection.Close();
            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";
                if (stIDTEXT.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter Employee ID");
                    stIDTEXT.Focus();
                    return;
                }
                query = "DELETE FROM Experience_Info WHERE StaffID = " + stfID;

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
    }

    }

