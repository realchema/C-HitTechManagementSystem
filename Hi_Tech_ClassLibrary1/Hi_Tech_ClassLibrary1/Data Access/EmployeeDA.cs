using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_ClassLibrary1.Bus;

namespace Hi_Tech_ClassLibrary1.Data_Access
{
    [Serializable]
    public class EmployeeDA
    {

        public static string filepathemployee = @"..\..\bin\Debug\userdata1.ser";

        public static void Binarywriter(List<Employee> listofemployee)
        {


            FileStream fs = new FileStream(filepathemployee, FileMode.Create, FileAccess.Write);
            BinaryFormatter bin = new BinaryFormatter();

            foreach (Employee aemployee in listofemployee)
            {

                bin.Serialize(fs, aemployee);
            }
            fs.Close();

        }

        public static void BinaryReader(List<Employee> listofemployee)
        {

            if (File.Exists(filepathemployee))
            {
                FileStream fs = new FileStream(filepathemployee, FileMode.Open, FileAccess.Read);
                BinaryFormatter bin = new BinaryFormatter();
                while (fs.Position < fs.Length)
                {
                    Employee aemployee = new Employee();
                    aemployee = (Employee)bin.Deserialize(fs);

                    listofemployee.Add(aemployee);
                }
                fs.Close();
            }


        }
    }
}
