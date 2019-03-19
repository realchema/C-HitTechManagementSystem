using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Tech_ClassLibrary1
{
    [Serializable]
    public class User
    {

        private int password;
        private string secretq;

        public int Password
        {

            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Secretq
        {
            get
            {
                return secretq;
            }
            set
            {
                secretq = value;
            }


        }


        public User()
        {

          
            password = 0;
           
            secretq = "";
        }

        public User(int password, string secretq)
        {
           
            Password = password;
            Secretq = secretq;
        }

        
    }
}
