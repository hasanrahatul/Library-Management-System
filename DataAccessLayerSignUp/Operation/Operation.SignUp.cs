using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccessLayerSignUp.Entities;
using System.Configuration;

namespace DataAccessLayerSignUp.Operation
{
    public class OperationSignUp
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["LibraryDBConnection"].ConnectionString);
        public int SignUp(EntitiesSignUp e)
        {
            
            connection.Open();
            SqlCommand command = new SqlCommand("insert into SignUpTable(FirstName, LastName, Username, Password, ConfirmPassword, Email, Gender) values('" + e.FirstName + "', '" + e.LastName + "', '" + e.Username + "', '" + e.Password+ "','" + e.ConfirmPassword + "','" + e.Email + "','" + e.Gender + "')", connection);
            int flag = command.ExecuteNonQuery();
            connection.Close();
            return flag;
        }
            
    }
}
