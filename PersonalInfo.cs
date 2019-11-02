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
    public partial class PersonalInfo : Form
    {
        public int stfID = 0;
        public PersonalInfo()
        {
            InitializeComponent();
        }

        private void PersonalInfo_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }

        private void SavePersonal_Click(object sender, EventArgs e)
        {
            string query = ""; int DistrictKey = ((KeyValuePair<int, string>)District.SelectedItem).Key;
            string que = ""; int ThanaKey = ((KeyValuePair<int, string>)Thana.SelectedItem).Key;
            string qu = ""; int MarriedKey = ((KeyValuePair<int, string>)MarriedCombox.SelectedItem).Key;
            String DistrictValue = ((KeyValuePair<int, string>)District.SelectedItem).Value;
            String ThanaValue = ((KeyValuePair<int, string>)Thana.SelectedItem).Value;
            String MarriedValue = ((KeyValuePair<int, string>)MarriedCombox.SelectedItem).Value;
            if (StaffIDtextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Staff ID");
                StaffIDtextBox.Focus();
                return;
            }

            if (ContacttextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Contact Number");
                ContacttextBox.Focus();
                return;
            }
            if (DOB.Text == "")
            {
                MessageBox.Show("Please Enter Date of Birth");
                DOB.Focus();
                return;
            }
            if (DistrictKey < 1)
            {
                MessageBox.Show("Please Enter District");
                District.Focus();
                return;
            }
            if (ThanaKey < 1)
            {
                MessageBox.Show("Please Enter Thana");
                District.Focus();
                return;
            }

            if (PostCodetextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Post Code");
                PostCodetextBox.Focus();
                return;
            }
            if (VillagetextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Village Name");
                VillagetextBox.Focus();
                return;
            }
            if (PresentAddresstextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Present Address");
                PresentAddresstextBox.Focus();
                return;
            }
            if (PermanentadresstextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Permanent Address");
                PermanentadresstextBox.Focus();
                return;
            }
            if (MarriedKey < 1)
            {
                MessageBox.Show("Please Enter Marital Status");
                District.Focus();
                return;
            }

            if (FathersNametextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Father's name");
                FathersNametextBox.Focus();
                return;
            }
            if (MothersNametextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Mother's Name");
                MothersNametextBox.Focus();
                return;
            }
            if (ParentsAddresstextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Present Address");
                ParentsAddresstextBox.Focus();
                return;
            }

            query = "SELECT COUNT(*) AS Count FROM Personal_Info WHERE StaffID = " + StaffIDtextBox.Text + "";
            if (stfID == 0)
            {
                if (DbAccess.NumberOfRecords(query) > 0)
                {
                    MessageBox.Show("This Username already exists! Please try another ID!");
                    StaffIDtextBox.Focus();
                    return;
                }
            }
            else
            {
                if (DbAccess.NumberOfRecords(query) > 1)
                {
                    MessageBox.Show("Update Not Successfully Done!");
                    StaffIDtextBox.Focus();
                    return;
                }
            }

            try
            {
                if (stfID == 0)
                {
                    query = "INSERT INTO Personal_Info(StaffID,Contact,[Date of Birth],District,Thana,[Post Code],Village,[Present Address],[Permanent Address],[Marital Status],[Father's  Name],[Mother's Name],[Parent's Address]) VALUES(" + Convert.ToInt32(StaffIDtextBox.Text) + ",  '" + ContacttextBox.Text + "', '" + DOB.Value.ToString("yyyy/MM/dd") + "', '" + DistrictValue + "', '" + ThanaValue + "', '" + PostCodetextBox.Text + "', '" + VillagetextBox.Text + "', '" + PresentAddresstextBox.Text + "', '" + PermanentadresstextBox.Text + "', '" + MarriedValue + "', '" + FathersNametextBox.Text + "', '" + MothersNametextBox.Text + "', '" + ParentsAddresstextBox.Text + "')";
                }
               

                 else
                {
                    query = "UPDATE Personal_Info SET  Contact = '" + ContacttextBox.Text + "', [Date of Birth] = '" + DOB.Text + "',  District= '" + District.Text + "', Thana = '" + Thana.Text + "', [Post Code] = '" + PostCodetextBox.Text + "', Village = '" + VillagetextBox.Text + "',[Present Address] = '" + PresentAddresstextBox.Text + "', [Permanent Address] = '" + PermanentadresstextBox.Text + "', [Marital Status] = '" + MarriedValue + "',[Father's  Name] = '" + FathersNametextBox.Text + "', [Mother's Name]= '" + MothersNametextBox.Text + "',[Parent's Address] = '" + ParentsAddresstextBox.Text + "' WHERE StaffID = " + stfID;
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

        private void DeletePersonal_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";
                if (StaffIDtextBox.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter Staff ID");
                    StaffIDtextBox.Focus();
                    return;
                }
               
                query = "DELETE FROM Personal_Info WHERE StaffID = " + stfID;

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

        private void District_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Thana_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LoadCombo()
        {

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Dhaka");
            dict.Add(2, "Khulna");
            dict.Add(3, "Chattogram");
            dict.Add(4, "Cumilla");
            dict.Add(5, "Barishal");
            dict.Add(6, "Noakhali");
            dict.Add(7, "Gazipur");
            District.DataSource = new BindingSource(dict, null);
            District.DisplayMember = "Value";
            District.ValueMember = "Key";

            int key = ((KeyValuePair<int, string>)District.SelectedItem).Key;
            //string value = ((KeyValuePair)District.SelectedItem).Value;





            Dictionary<int, string> thana = new Dictionary<int, string>();
            thana.Add(1, "Azampur");
            thana.Add(2, "Dhanmondi");
            thana.Add(3, "Gulshan");
            thana.Add(4, "Motijheel");
            thana.Add(5, "Uttara");
            thana.Add(6, "Badda");
            thana.Add(7, "Ramna");
            thana.Add(8, "Jatrabari");
            thana.Add(9, "Rampura");
            thana.Add(10, "Shahbag");
            thana.Add(11, "Khilgaon");
            thana.Add(12, "Mohammadpur");
            thana.Add(13, "Mirpur");

            Thana.DataSource = new BindingSource(thana, null);
            Thana.DisplayMember = "Value";
            Thana.ValueMember = "Key";

            int ke = ((KeyValuePair<int, string>)Thana.SelectedItem).Key;
            //string value = ((KeyValuePair)District.SelectedItem).Value;
           

            Dictionary<int, string> Status = new Dictionary<int, string>();
            Status.Add(1, "Married");
            Status.Add(2, "Unmarried");

            MarriedCombox.DataSource = new BindingSource(Status, null);
            MarriedCombox.DisplayMember = "Value";
            MarriedCombox.ValueMember = "Key";

            int k = ((KeyValuePair<int, string>)MarriedCombox.SelectedItem).Key;
            //string value = ((KeyValuePair)District.SelectedItem).Value;

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void StaffIDtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && StaffIDtextBox.Text != "")
            {
                e.Handled = true;
                
            }
        }



        private void Reset()
        {
            StaffIDtextBox.Text = "";
 
            ContacttextBox.Text = "";
            DOB.Text = "";
            VillagetextBox.Text = "";

            PostCodetextBox.Text = "";
            PresentAddresstextBox.Text = "";
            PermanentadresstextBox.Text = "";
            MarriedCombox.Text = "";
            FathersNametextBox.Text = "";
            MothersNametextBox.Text = "";
            ParentsAddresstextBox.Text = "";
            stfID = 0;
            District.DataSource = null;
            District.Items.Clear();
            Thana.DataSource = null;
            Thana.Items.Clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void StaffIDtext_Click(object sender, EventArgs e)
        {

        }

        private void StafIDText_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void StaffIDtextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && StaffIDtextBox.Text != "")
            {
                e.Handled = true;
                StaffIDtextBox.ReadOnly = true;
                SetValue();
                DeletePersonal.Enabled = true;
            }
        }

        private void SetValue()
        {
            try
            {
                String query = "SELECT * FROM Personal_Info WHERE StaffID = " + Convert.ToInt32(StaffIDtextBox.Text);
                SqlDataReader reader = DbAccess.GetFromDB(query);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        
                        ContacttextBox.Text = reader["Contact"].ToString();
                        DOB.Text = reader["Date of Birth"].ToString();
                        District.Text = reader["District"].ToString();
                        Thana.Text = reader["Thana"].ToString();
                        PostCodetextBox.Text = reader["Post Code"].ToString();
                        VillagetextBox.Text = reader["Village"].ToString();
                        PresentAddresstextBox.Text = reader["Present Address"].ToString();
                        PermanentadresstextBox.Text = reader["Permanent Address"].ToString();
                        MarriedCombox.Text = reader["Marital Status"].ToString();
                        FathersNametextBox.Text = reader["Father's  Name"].ToString();
                        MothersNametextBox.Text = reader["Mother's Name"].ToString();
                        ParentsAddresstextBox.Text = reader["Parent's Address"].ToString();

                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

                stfID = Convert.ToInt32(StaffIDtextBox.Text);

                DbAccess.connnection.Close();
            }
        }

        private void PostCodetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void ContacttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
        
   


    


