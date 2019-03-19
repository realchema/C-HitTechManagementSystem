using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hi_TechManagementSystem.GUI
{
    public partial class Logout : MetroFramework.Forms.MetroForm
    {
        public Logout()
        {
            InitializeComponent();
        }

        private void flatButtonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MIS_Manager nmis = new MIS_Manager();
            nmis.Show();
        }

        private void flatButtonYes_Click(object sender, EventArgs e)
        {
            this.Close();
           
            Login nlogin = new Login();
            nlogin.Show();
            
        }
    }
}
