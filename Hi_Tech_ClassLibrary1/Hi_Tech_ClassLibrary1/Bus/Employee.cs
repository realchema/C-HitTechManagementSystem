using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Hi_Tech_ClassLibrary1
{
   
    public enum EnumStatus { Undefined, Active, Inactive }
    [Serializable]
    public class Employee : User
    {
        private int employeeid;
        private string username;
        private string lastname;
        private string jobtitle;
        private string address;
        private Int64 phone;
        private string email;
        private Image pictureprofile;
        private EnumStatus status;


        public int Employeeid
        {
            get
            {
                return employeeid;
            }

            set
            {
                employeeid = value;
            }
        }

        public string Username
        {
            get
            {

                return username;
            }

            set
            {

                username = value;
            }

        }

        public string Lastname
        {
            get
            {
                return lastname;

            }

            set
            {

                lastname = value;
            }

        }

        public string Jobtitle
        {
            get
            {
                return jobtitle;
            }
            set
            {
                jobtitle = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }

        }
        public Int64 Phone
        {
            get
            {

                return phone;
            }
            set
            {
                phone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public Image Pictureprofile
        {

            get
            {
                return pictureprofile;

            }
            set
            {
                pictureprofile = value;
            }
        }

        public EnumStatus Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public Employee()
        {
            employeeid = 0000;
            Username = "";
            Lastname = "";
            jobtitle = "";
            address = "";
            phone = 0000000000;
            email = "";
            status = EnumStatus.Undefined;

        }

        public Employee(string jobtitle, string address, int phone, string email,
            int employeeid, int password, string username, string lastname, EnumStatus status, string secretq) : base(password, secretq)

        {
            Employeeid = employeeid;
            Username = username;
            Lastname = lastname;
            Jobtitle = jobtitle;
            Address = address;
            Phone = phone;
            Email = email;
            Status = status;

        }
    }
}

