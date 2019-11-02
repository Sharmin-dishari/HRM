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
    public partial class SalaryPolicy : Form
    {

        public int stfID = 0;
        public SalaryPolicy()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double BasicSalary = BasicSalaryText.Text == "" ? 0.0 : Convert.ToDouble(BasicSalaryText.Text);
            double Transport = TransportText.Text == "" ? 0.0 : Convert.ToDouble(TransportText.Text);
            double Medical = MedicalText.Text == "" ? 0.0 : Convert.ToDouble(MedicalText.Text);
            double Mobile = MobileBill.Text == "" ? 0 : Convert.ToDouble(MobileBill.Text);
            double Food = FoodbillText.Text == "" ? 0 : Convert.ToDouble(FoodbillText.Text);

            if (BasicSalary != 0.0 && Transport != 0.0 && Medical != 0.0 && Mobile != 0.0 && Food != 0.0)
            {
                totalAllow.Text = (BasicSalary + (BasicSalary * (Transport / 100.0)) + (BasicSalary * (Medical / 100.0)) + (BasicSalary * (Mobile / 100.0)) + (BasicSalary * (Food / 100.0))).ToString();
            }
            else
            {
                totalAllow.Text = "";
            }
        }

        private void ReSavebtn_Click(object sender, EventArgs e)
        {
            string query = "";
            if (StaaFText.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Employee ID");
                StaaFText.Focus();
                return;
            }



            if (BasicSalaryText.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Password");
                BasicSalaryText.Focus();
                return;
            }

            if (TransportText.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Transport Parcentage");
                TransportText.Focus();
                return;
            }
            if (MedicalText.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Medicalbill Percentage");
                MedicalText.Focus();
                return;
            }
            if (MobileBill.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter MobileBill Percentage");
                MobileBill.Focus();
                return;
            }
            if (FoodbillText.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter FoodBil Percentage");
                FoodbillText.Focus();
                return;
            }

            if (totalAllow.Text.Trim() == "")
            {
                
                totalAllow.Focus();
                return;
            }

            query = "SELECT COUNT(*) AS Count FROM Salary_Info WHERE StaffID = " + StaaFText.Text + "";
            if (stfID == 0)
            {
                if (DbAccess.NumberOfRecords(query) > 0)
                {
                    MessageBox.Show("This username already exists! Please try another ID!");
                    StaaFText.Focus();
                    return;
                }
            }
            else
            {
                if (DbAccess.NumberOfRecords(query) > 1)
                {
                    MessageBox.Show("This username already exists! Please try another ID!");
                    StaaFText.Focus();
                    return;
                }
            }
            try
            {
                if (stfID == 0)
                {
                    query = "INSERT INTO Salary_Info(StaffID,BasicSalary,Transport,Medical,MobileBill,Food,Total) VALUES(" + Convert.ToInt32(StaaFText.Text) + ",  '" + BasicSalaryText.Text + "',  '" + TransportText.Text + "', '" + MedicalText.Text + "', '" + MobileBill.Text + "', '" + FoodbillText.Text + "', '" + totalAllow.Text + "' )";
                }


                else
                {
                    query = "UPDATE Salary_Info SET  BasicSalary = '" + BasicSalaryText.Text + "', Transport = '" + TransportText.Text + "', Medical= '" + MedicalText.Text + "',MobileBill = '" + MobileBill.Text + "', Food = '" + FoodbillText.Text + "',  Total = '" + totalAllow.Text + "' WHERE StaffID = " + stfID;
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
            StaaFText.Text = "";

            BasicSalaryText.Text = "";
            TransportText.Text = "";
            MedicalText.Text = "";

            MobileBill.Text = "";
            FoodbillText.Text = "";
            totalAllow.Text = "";

            stfID = 0;
        }

        private void DeletebtN_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";
                if (StaaFText.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter Staff ID");
                    StaaFText.Focus();
                    return;
                }
                query = "DELETE FROM Salary_Info WHERE StaffID = " + stfID;

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



        private void StaaFText_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && StaaFText.Text != "")
            {
                e.Handled = true;
                StaaFText.ReadOnly = true;
                SetValue();
                DeletebtN.Enabled = true;
            }
        }



        private void SetValue()
        {
            try
            {
                String query = "SELECT * FROM Salary_Info WHERE StaffID = " + Convert.ToInt32(StaaFText.Text);
                SqlDataReader reader = DbAccess.GetFromDB(query);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {


                        StaaFText.Text = reader["StaffID"].ToString();

                        BasicSalaryText.Text = reader["BasicSalary"].ToString();
                        TransportText.Text = reader["Transport"].ToString();
                        MedicalText.Text = reader["Medical"].ToString();
                        MobileBill.Text = reader["MobileBill"].ToString();
                        FoodbillText.Text = reader["Food"].ToString();
                        totalAllow.Text = reader["Total"].ToString();


                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

                stfID = Convert.ToInt32(StaaFText.Text);

                DbAccess.connnection.Close();
            }
        }

        private void BasicSalaryText_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void BasicSalaryText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TransportText_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TransportText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BasicSalaryText_TextChanged(object sender, EventArgs e)
        {
            double BasicSalary = BasicSalaryText.Text == "" ? 0.0 : Convert.ToDouble(BasicSalaryText.Text);
            double Transport = TransportText.Text == "" ? 0.0 : Convert.ToDouble(TransportText.Text);
            double Medical = MedicalText.Text == "" ? 0.0 : Convert.ToDouble(MedicalText.Text);
            double Mobile = MobileBill.Text == "" ? 0 : Convert.ToDouble(MobileBill.Text);
            double Food = FoodbillText.Text == "" ? 0 : Convert.ToDouble(FoodbillText.Text);

            if (BasicSalary != 0.0 && Transport != 0.0 && Medical != 0.0 && Mobile != 0.0 && Food != 0.0)
            {
                totalAllow.Text = (BasicSalary + (BasicSalary * (Transport / 100.0)) + (BasicSalary * (Medical / 100.0)) + (BasicSalary * (Mobile / 100.0)) + (BasicSalary * (Food / 100.0))).ToString();
            }
            else
            {
                totalAllow.Text = "";
            }
        }

        private void TransportText_TextChanged(object sender, EventArgs e)
        {
            double BasicSalary = BasicSalaryText.Text == "" ? 0.0 : Convert.ToDouble(BasicSalaryText.Text);
            double Transport = TransportText.Text == "" ? 0.0 : Convert.ToDouble(TransportText.Text);
            double Medical = MedicalText.Text == "" ? 0.0 : Convert.ToDouble(MedicalText.Text);
            double Mobile = MobileBill.Text == "" ? 0 : Convert.ToDouble(MobileBill.Text);
            double Food = FoodbillText.Text == "" ? 0 : Convert.ToDouble(FoodbillText.Text);

            if (BasicSalary != 0.0 && Transport != 0.0 && Medical != 0.0 && Mobile != 0.0 && Food != 0.0)
            {
                totalAllow.Text = (BasicSalary + (BasicSalary * (Transport / 100.0)) + (BasicSalary * (Medical / 100.0)) + (BasicSalary * (Mobile / 100.0)) + (BasicSalary * (Food / 100.0))).ToString();
            }
            else
            {
                totalAllow.Text = "";
            }
        }

        private void MobileBill_TextChanged(object sender, EventArgs e)
        {
            double BasicSalary = BasicSalaryText.Text == "" ? 0.0 : Convert.ToDouble(BasicSalaryText.Text);
            double Transport = TransportText.Text == "" ? 0.0 : Convert.ToDouble(TransportText.Text);
            double Medical = MedicalText.Text == "" ? 0.0 : Convert.ToDouble(MedicalText.Text);
            double Mobile = MobileBill.Text == "" ? 0 : Convert.ToDouble(MobileBill.Text);
            double Food = FoodbillText.Text == "" ? 0 : Convert.ToDouble(FoodbillText.Text);

            if (BasicSalary != 0.0 && Transport != 0.0 && Medical != 0.0 && Mobile != 0.0 && Food != 0.0)
            {
                totalAllow.Text = (BasicSalary + (BasicSalary * (Transport / 100.0)) + (BasicSalary * (Medical / 100.0)) + (BasicSalary * (Mobile / 100.0)) + (BasicSalary * (Food / 100.0))).ToString();
            }
            else
            {
                totalAllow.Text = "";
            }
        }

        private void FoodbillText_TextChanged(object sender, EventArgs e)
        {
            double BasicSalary = BasicSalaryText.Text == "" ? 0.0 : Convert.ToDouble(BasicSalaryText.Text);
            double Transport = TransportText.Text == "" ? 0.0 : Convert.ToDouble(TransportText.Text);
            double Medical = MedicalText.Text == "" ? 0.0 : Convert.ToDouble(MedicalText.Text);
            double Mobile = MobileBill.Text == "" ? 0 : Convert.ToDouble(MobileBill.Text);
            double Food = FoodbillText.Text == "" ? 0 : Convert.ToDouble(FoodbillText.Text);

            if (BasicSalary != 0.0 && Transport != 0.0 && Medical != 0.0 && Mobile != 0.0 && Food != 0.0)
            {
                totalAllow.Text = (BasicSalary + (BasicSalary * (Transport / 100.0)) + (BasicSalary * (Medical / 100.0)) + (BasicSalary * (Mobile / 100.0)) + (BasicSalary * (Food / 100.0))).ToString();
            }
            else
            {
                totalAllow.Text = "";
            }
        }

        private void MedicalText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void MobileBill_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void FoodbillText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}





