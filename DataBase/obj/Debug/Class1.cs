using ATTENDANCE_MANAGEMENT_SYSTEM_REQUIREMENT;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sql_
{
    public class Class1
    {
        public string connStr;
        SqlConnection cnn;
        SqlCommand sqlCommand;
        public Class1()
        {
            // connStr = "Data Source =.; Initial Catalog = ishani; Integrated Security = True";
            connStr = ConfigurationSettings.AppSettings["sql"];

            cnn = new SqlConnection(connStr);

            cnn.Open();

        }
        public void DataBind()
        {
            try
            {
                sqlCommand = new SqlCommand("Select * from Admin", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlCommand;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                Admin.DataSource = bsource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //public Boolean valid(String email, String password)
        //{

        //    string query = "select * from dbo.log where email = '" + email + "' and password= '" + password + "'";
        //    sqlCommand = new SqlCommand(query, cnn);

        //    SqlDataReader DataReader;
        //    Boolean validate = false;
        //    DataReader = sqlCommand.ExecuteReader();
        //    if (DataReader.Read())
        //    {
        //        validate = true;
        //    }
        //    cnn.Close();
        //    return validate;
        //}

        //public Boolean CreateCust(string fname, string lname, string mname, string gender, DateTime doj, DateTime dob, string age, string address, string adhar)
        //{
        //    if (cnn.State == System.Data.ConnectionState.Open)
        //    {

        //        sqlCommand = new SqlCommand("AddCustomer", cnn);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("firstname", fname);
        //        sqlCommand.Parameters.AddWithValue("lastname", lname);
        //        sqlCommand.Parameters.AddWithValue("middlename", mname);
        //        sqlCommand.Parameters.AddWithValue("gender", gender);
        //        sqlCommand.Parameters.AddWithValue("dateofjoining", Convert.ToDateTime(doj));
        //        sqlCommand.Parameters.AddWithValue("dob", Convert.ToDateTime(dob));
        //        sqlCommand.Parameters.AddWithValue("age", Convert.ToInt32(age));
        //        sqlCommand.Parameters.AddWithValue("address", address);
        //        sqlCommand.Parameters.AddWithValue("adhar", adhar);

        //        sqlCommand.ExecuteNonQuery();

        //        cnn.Close();
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

    }
}
