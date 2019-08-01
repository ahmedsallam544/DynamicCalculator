using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Configuration;
namespace AuthService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
                
        public int LoginSuccess(string UserName , string Password) {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=Registration;Integrated Security=SSPI;";
            con.Open();
            // OPen connection from DataBase And Excute Command TO return permisions

            SqlCommand cmd = new SqlCommand("Select Permissions from RegistrationTable WHERE (UserName = @UserName) AND ( Password = @Password)", con);
            cmd.Parameters.Add("@UserName", SqlDbType.Char).Value = UserName ;
            cmd.Parameters.Add("@Password", SqlDbType.Char).Value = Password;

            try
            {
                int permission = Convert.ToInt32(cmd.ExecuteScalar());
                return permission;
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                con.Close();
            }



        }
        // Another Methods Not Used In our Application yet  

            // such as register in DataBase And return all users recorded
        public DataSet SelectUserDetails()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=Registration;Integrated Security=SSPI;";
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from RegistrationTable", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //  UserDetails ds = new UserDetails();
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Close();
            return ds;

        }
        public string InsertUserDetails(UserDetails userInfo)
        {
            string Message;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Registration;Integrated Security=SSPI;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into RegistrationTable(UserName,Password ) values(@UserName,@Password)", con);

            cmd.Parameters.AddWithValue("@UserName", userInfo.UserName);

            cmd.Parameters.AddWithValue("@Password", userInfo.Password);

            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = userInfo.UserName + " Details inserted successfully";

            }
            else {

                Message = userInfo.UserName + " Details not inserted successfully";
            }

            con.Close();
            return Message;
        }

         
    }
}
