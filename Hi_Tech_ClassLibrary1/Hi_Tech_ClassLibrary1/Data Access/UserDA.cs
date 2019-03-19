using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Tech_ClassLibrary1.Data_Access
{
    public class UserDA
    {
        public static string filepathuser = @"..\..\bin\Debug\userdata.txt";
        public static void Writetofileuser(List<User> listofuser)

        {
            using (StreamWriter wirter = File.CreateText(filepathuser))
            {

                foreach (User element in listofuser)
                {
                    wirter.WriteLine(element.Password + "|" +
                                    element.Secretq);


                }
                wirter.Close();
            }

        }

        public static void Readfromfileuser(List<User> listofuser)
        {

            StreamReader reader = new StreamReader(filepathuser);
            string line = reader.ReadLine();

            while (line != null)
            {
                User nuser = new User();
                string[] field = line.Split('|');

                nuser.Password = Convert.ToInt32( field[0]);
                nuser.Secretq = field[1];



            }
            reader.Close();
        }


    }
}
