using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayerSignUp.Entities
{
   public class EntitiesSignUp
    {
        private string firstName;
        private string lastName;
        private string userame;
        private string password;
        private string confirmPassword;
        private string email;
        private string gender;

        public string FirstName
        {
            set;
            get;
        }
        public string LastName
        {
            set;
            get;
        }
        public string Username
        {
            set;
            get;
        }
        public string Password
        {
            set;
            get;
        }
        public string ConfirmPassword
        {
            set;
            get;
        }
        public string Email
        {
            set;
            get;
        }
        public string Gender
        {
            set;
            get;
        }

    }
}
