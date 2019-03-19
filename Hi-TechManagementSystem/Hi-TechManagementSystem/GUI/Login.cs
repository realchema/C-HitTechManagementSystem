using Hi_Tech_ClassLibrary1;
using Hi_Tech_ClassLibrary1.Data_Access;
using Hi_TechManagementSystem.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hi_TechManagementSystem
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        List<Employee> listofemployee = new List<Employee>();
       
         
        public Login()
        {
            InitializeComponent();
            fillcombobox();
        }
        public void fillcombobox()
        {

            EmployeeDA.BinaryReader(listofemployee);

            foreach (Employee element in listofemployee)
            {
                if (element.Password != 0)
                {
                    flatComboBoxLogin.Items.Add(element.Employeeid);
                }
            }
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            
            EmployeeDA.BinaryReader(listofemployee);
            this.Hide();
            MIS_Manager nmis = new MIS_Manager();
            nmis.Show();

        }

        private void flatComboBoxLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool found = false;
            Employee nemployee = new Employee();
            foreach (Employee element in listofemployee)
            {
                if (element.Employeeid ==Convert.ToInt32( flatComboBoxLogin.Text) )
                {
                    found = true;
                    nemployee = element;
                }
            }
            if (found)
            {


                pictureBox1.Image = nemployee.Pictureprofile;


            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
