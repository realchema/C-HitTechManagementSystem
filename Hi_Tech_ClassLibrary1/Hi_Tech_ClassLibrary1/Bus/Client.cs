using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Tech_ClassLibrary1
{
    public class Client
    {
        public string cname;
        public string caddress;
        public string ccity;
        public string cpcode;
        public int cphone;
        public int cfax;
        public double climit;

        private string Cname
        {
            get { return cname; }
            set { value = cname; }
        }

        private string Caddress
        {
            get { return caddress; }
            set { value = caddress; }

        }

        private string Ccity
        {

            get { return ccity; }
            set { value = ccity; }
        }

        private string Cpcode

        {
            get { return cpcode; }
            set { value = cpcode; }

        }

        private int Cphone
        {

            get { return cphone; }
            set { value = cphone; }

        }


        private int Cfax
        {
            get { return cfax; }
            set { value = cfax; }


        }

        private double Climit
        {
            get { return climit; }
            set { value = climit; }

        }

        public Client()
        {
            cname = "";
            caddress = "";
            ccity = "";
            cpcode = "";
            cphone = 0000000000;
            cfax = 00000000000;
            climit = 00.00;
        }

        public Client(string cname, string caddress, string ccity,
                string cpcode, int cphone, int cfax, double climit)

        {
            cname = Cname;
            caddress = Caddress;
            ccity = Ccity;
            cpcode = Cpcode;
            cphone = Cphone;
            cfax = Cfax;
            climit = Climit;
        }
    }
}
