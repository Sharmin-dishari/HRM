using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRM
{

    public partial class Password : Form
    {
        public int EmployeeID = 0;

        public Password()
        {

            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)

        {
            string query = "";
            if (EmpIdtextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Employee ID");
                EmpIdtextBox.Focus();
                return;
            }

            if (userNametextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter UserName");
                userNametextBox.Focus();
                return;
            }

            if (passwordtextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Password");
                passwordtextBox.Focus();
                return;
            }

            if (confirmpasswordtextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Confirm Passowrd");
                confirmpasswordtextBox.Focus();
                return;
            }

            if (passwordtextBox.Text != confirmpasswordtextBox.Text)
            {
                MessageBox.Show("Password does not match with Confirm Passowrd");
                passwordtextBox.Focus();
                confirmpasswordtextBox.Focus();
                return;
            }

            query = "SELECT COUNT(*) FROM Employee_Info WHERE UserName = '" + userNametextBox.Text + "'";

            if (EmployeeID == 0)
            {
                if (DbAccess.NumberOfRecords(query) > 0)
                {
                    MessageBox.Show("This username already exists! Please try another username!");
                    userNametextBox.Focus();
                    return;
                }
            }
            else
            {
                if (DbAccess.NumberOfRecords(query) > 1)
                {
                    MessageBox.Show("This username already exists! Please try another username!");
                    userNametextBox.Focus();
                    return;
                }
            }

            try
            {
                if (EmployeeID == 0)
                {
                    query = "INSERT INTO Employee_Info(EmpID,UserName,Password) VALUES(" + EmpIdtextBox.Text + ", '" + userNametextBox.Text + "', '" + passwordtextBox.Text + "')";
                }
                else
                {
                    query = "UPDATE Employee_Info SET Password = '" + passwordtextBox.Text + "' WHERE EmpID = " + EmployeeID;
                }

                if (DbAccess.ExecuteToDB(query))
                {
                    if (EmployeeID == 0)
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";
                if (EmpIdtextBox.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter Employee ID");
                    EmpIdtextBox.Focus();
                    return;
                }
                query = "DELETE FROM Employee_Info WHERE EmpID = " + EmployeeID;

                if (DbAccess.ExecuteToDB(query))
                {
                    if (EmployeeID != 0)
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


        private void ResetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void EmpIdtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && EmpIdtextBox.Text != "")
            {
                e.Handled = true;
                userNametextBox.ReadOnly = true;
                SetValue();
                deleteButton.Enabled = true;
            }
        }

        private void SetValue()
        {
            try
            {
                String query = "SELECT * FROM Employee_Info WHERE EmpID = " + Convert.ToInt32(EmpIdtextBox.Text);
                SqlDataReader reader = DbAccess.GetFromDB(query);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        userNametextBox.Text = reader["UserName"].ToString();
                        passwordtextBox.Text = reader["Password"].ToString();
                        confirmpasswordtextBox.Text = passwordtextBox.Text;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                EmployeeID = Convert.ToInt32(EmpIdtextBox.Text);
                DbAccess.connnection.Close();
            }
        }

        private void Reset()
        {
            EmpIdtextBox.Text = "";
            userNametextBox.Text = "";
            passwordtextBox.Text = "";
            confirmpasswordtextBox.Text = "";
            userNametextBox.ReadOnly = false;
            EmployeeID = 0;
            deleteButton.Enabled = false;
        }

        private void EmpIdtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Password_Load(object sender, EventArgs e)
        {
            deleteButton.Enabled = false;
        }
    }
}
