using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;



namespace HRM
{
    public class DbAccess
    {
        public static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();

        public static SqlCommand cmd; public static SqlDataReader reader;
        public static SqlConnection connnection = new SqlConnection(connectionString);


        public static bool recordExist(string sSQL)
        {
            
            SqlCommand cm = new SqlCommand();
            SqlConnection cn = new SqlConnection(connectionString);

            try
            {
                cn.Open();
                cm.Connection = cn;
                cm.CommandText = sSQL;

                SqlDataReader reader;
                reader = cm.ExecuteReader();

                if (reader.Read())
                { return true; }
                else { return false; }
            }
            catch (System.Exception e)
            {
                MessageBox.Show("" + e.ToString());
                return false;
            }
            finally
            {
                cn.Close();                
            }

        }

        public static Boolean ExecuteToDB(string sSQL)
        {
            Boolean Result = false;
            SqlCommand cm = new SqlCommand();
            SqlConnection cn = new SqlConnection(connectionString);

            try
            {
                cn.Open();
                cm.Connection = cn;
                cm.CommandText = sSQL;
                Result = cm.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (System.Exception e)
            {
                MessageBox.Show("" + e.ToString());
                return false;
            }
            finally
            {
                cn.Close();
            }
            return Result;
        }

        public static SqlDataReader GetFromDB(string sSQL)
        {
            try
            {
                connnection.Open();
                cmd = new SqlCommand(sSQL, connnection);
                reader = cmd.ExecuteReader();
            }
            catch (System.Exception e)
            {
                MessageBox.Show("" + e.ToString());
                return reader;
            }
            return reader;
        }

        public static int NumberOfRecords(string sSQL)
        {
            SqlDataReader reader = null; int count = 0;
            SqlCommand cm = new SqlCommand();
            SqlConnection cn = new SqlConnection(connectionString);

            try
            {
                cn.Open();
                cm.Connection = cn;
                cm.CommandText = sSQL;
                reader = cm.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        count = Convert.ToInt32(reader["Count"]);
                    }
                    else
                    {
                        count = 0;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show("" + e.ToString());
                return 0;
            }
            finally
            {
                cn.Close();
            }
            return count;
        }

        public static bool IsDate(string sdate)
        {
            DateTime dt;
            bool isDate = true;
            try
            {
                dt = DateTime.Parse(sdate);
            }
            catch
            {
                isDate = false;
            }
            return isDate;
        }
        public static bool CheckDouble(string Sstring)
        {
            bool NumberCheck = false;
            double CheckDouble = 0;

            try
            {
                NumberCheck = double.TryParse(Sstring, out CheckDouble);
            }
            catch
            {
                NumberCheck = false;
            }
            return NumberCheck;
        }

        public int MaxRecord(string sSQL)
        {
            string connectionStr = DbAccess.connectionString;
            SqlCommand cm = new SqlCommand();
            SqlConnection cn = new SqlConnection(connectionStr);
            int mr = 0;
            try
            {
                cn.Open();
                cm.Connection = cn;
                cm.CommandText = sSQL;
                SqlDataReader reader;
                reader = cm.ExecuteReader();
                while (reader.Read())
                {
                    mr = Convert.ToInt32(reader[0].ToString());
                }

                //SqlDataAdapter ADAP = new SqlDataAdapter(sSQL, cn);
                //DataSet DS = new DataSet();
                //ADAP.Fill(DS, sTable);
                //mr = Convert.ToInt32(DS.Tables[sTable].Rows[0].ItemArray.GetValue(0).ToString());
            }
            catch (System.Exception e)
            {
                MessageBox.Show("" + e.ToString());
            }
            finally
            {
                cn.Close();
            }
            return mr;
        }

    }
}
