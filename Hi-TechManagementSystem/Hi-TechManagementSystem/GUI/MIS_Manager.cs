
using Hi_Tech_ClassLibrary1;
using Hi_Tech_ClassLibrary1.Data_Access;
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
    public partial class MIS_Manager : MetroFramework.Forms.MetroForm
    {
        public MIS_Manager()
        {
            InitializeComponent();

            metroListViewemployee.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            metroListViewemployee.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            metroListViewusers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            metroListViewusers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            groupBoxEmployee.Visible = false;
            groupBoxuser.Visible = false;
            PopulateCombobox();
            
        }

        

        List<Employee> listofemployee = new List<Employee>();
        List<User> listofuser = new List<User>();
        int index, index2;
        Bitmap newBitmap;
        Image file;

        public void AddEmployee()
        {
            Employee nemployee = new Employee();
            nemployee.Employeeid = Convert.ToInt32( flatTextBoxempid.Text);
            nemployee.Username = flatTextBoxempname.Text;
            nemployee.Lastname = flatTextBoxemplast.Text;
            nemployee.Jobtitle = flatComboBoxempjobtitle.Text;
            nemployee.Address = flatTextBoxempaddress.Text;
            nemployee.Phone = Convert.ToInt64(flatTextBoxempphone.Text);
            nemployee.Email = flatTextBoxempemail.Text;
            nemployee.Status = (EnumStatus)flatComboBoxempstatus.SelectedIndex;
            nemployee.Pictureprofile = pictureBoxemp.Image;
            listofemployee.Add(nemployee);

            EmployeeDA.Binarywriter(listofemployee);

            MessageBox.Show("a new user has been added");
        }
        public void AddUser()
        {

            int comboboxindex = flatComboBoxuser.SelectedIndex;
            foreach(Employee element in listofemployee)
            {
                
                listofemployee[comboboxindex].Employeeid = Convert.ToInt32( flatComboBoxuser.Text);
                listofemployee[comboboxindex].Password= Convert.ToInt32(flatTextBoxpasssword.Text);
            }
            

            

            
            
        }
        public void AddtoListUsers()
        {
            
            foreach (Employee element in listofemployee)
            {
                if (element.Password != 0)
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(element.Employeeid));
                    item.SubItems.Add(Convert.ToString(element.Password));
                    metroListViewusers.Items.Add(item);
                }
            }
        }
        

        public void AddToListEmployee()
        {

            foreach (Employee element in listofemployee)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(element.Employeeid));
                item.SubItems.Add(element.Username);
                item.SubItems.Add(element.Lastname);
                item.SubItems.Add(element.Jobtitle);
                item.SubItems.Add(element.Address);
                item.SubItems.Add(Convert.ToString( element.Phone));
                item.SubItems.Add(element.Email);
                item.SubItems.Add(Convert.ToString(element.Status));
                metroListViewemployee.Items.Add(item);
                
            }
            
        }
        public void Cleanfields()
        {
            pictureBoxemp.Image = pictureBoxemp.InitialImage;
            flatTextBoxempid.Text = "Employee ID";
            flatTextBoxempname.Text = "First Name";
            flatTextBoxemplast.Text = "Last Name";
            flatComboBoxempjobtitle.Text = null;
            flatTextBoxempaddress.Text = "Address";
            flatTextBoxempphone.Text = "Phone";
            flatTextBoxempemail.Text = "Email";
            flatComboBoxempstatus.Text = null;
            flatComboBoxuser.Text = null;
            flatTextBoxpasssword.Text = "Password";
            pictureBoxuser.Image = pictureBoxuser.InitialImage;
            labelJobTitle.Text = "Unknown";
            labelLastName.Text = "Unknown";
            labelEmpName.Text = "Unknown";
            

        }
        public void PopulateCombobox()
        {
            flatComboBoxempjobtitle.Items.Add("MIS Manager");
            flatComboBoxempjobtitle.Items.Add("Sales Manager");
            flatComboBoxempjobtitle.Items.Add("Inventory Controller");
            flatComboBoxempjobtitle.Items.Add("Order Clerks");

            
        }
        public void PopulateComboboxUser()
        {

            foreach (Employee element in listofemployee)
            {
                flatComboBoxuser.Items.Add(element.Employeeid);
            }
        }
        

        private void MIS_Manager_Load(object sender, EventArgs e)
        {
            EmployeeDA.BinaryReader(listofemployee);
            AddtoListUsers();
            AddToListEmployee();
            metroListViewemployee.FullRowSelect = true;
            foreach (EnumStatus element in Enum.GetValues(typeof(EnumStatus)))
            {
                flatComboBoxempstatus.Items.Add(element);
            }
            foreach (Employee element in listofemployee)
            {
              flatComboBoxuser.Items.Add(element.Employeeid);
            }

        }

        private void buttonloguot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logout nlogout = new Logout();
            nlogout.Show();
        }

        private void metroTileUserAdd_Click(object sender, EventArgs e)
        {

            
            groupBoxuser.Visible = true;
            flatButtonUserEdit.Visible = false;
            flatButtonconfirmuser.Visible = true;
         

            Cleanfields();
        }

        private void metroTileEmpAdd_Click(object sender, EventArgs e)
        {
            
            groupBoxEmployee.Visible = true;
            flatButtonedit.Visible = false;
            Cleanfields();
        }

        private void buttonhome_Click(object sender, EventArgs e)
        {
            groupBoxEmployee.Visible = false;
            groupBoxuser.Visible = false;
        }

        private void flatButtonempConfirm_Click(object sender, EventArgs e)
        {
            AddEmployee();
            AddToListEmployee();
            Cleanfields();
        }

        private void metroTileEmpEdit_Click(object sender, EventArgs e)
        {
            
            if (metroListViewemployee.SelectedIndices.Count >= 1)
            {
               
                
                    groupBoxEmployee.Visible = true;
                     flatButtonedit.Visible = true;
                foreach (Employee element in listofemployee)
                    {
                        flatTextBoxempid.Text = Convert.ToString(listofemployee[index].Employeeid);
                        flatTextBoxempname.Text = listofemployee[index].Username;
                        flatTextBoxemplast.Text = listofemployee[index].Lastname;
                        flatComboBoxempjobtitle.Text = listofemployee[index].Jobtitle;
                        flatTextBoxempaddress.Text = listofemployee[index].Address;
                        flatTextBoxempphone.Text = Convert.ToString(listofemployee[index].Phone);
                        flatTextBoxempemail.Text = listofemployee[index].Email;
                        pictureBoxemp.Image = listofemployee[index].Pictureprofile;
                        flatComboBoxempstatus.Text = Convert.ToString( listofemployee[index].Status);
                      }     
                }
            else
            {
                MessageBox.Show("You have to select a employee From the list");
            }
        }

        private void metroListViewemployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            index = metroListViewemployee.FocusedItem.Index;
        }

        private void flatButtonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                file = Image.FromFile(openFileDialog1.FileName);
                newBitmap = new Bitmap(openFileDialog1.FileName);
                pictureBoxemp.Image = file;
            }
        }

        private void flatComboBoxempjobtitle_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void metroTileEmpList_Click(object sender, EventArgs e)
        {
           
            metroListViewemployee.Items.Clear();
            AddToListEmployee();
           
        }

        private void groupBoxEmployee_Enter(object sender, EventArgs e)
        {

        }

       

        private void metroTileempDelete_Click(object sender, EventArgs e)
        { 

            if (metroListViewemployee.SelectedIndices.Count >= 1)
            {
                string textlv = metroListViewemployee.SelectedItems[index].Text;
                if (MessageBox.Show("Are you sure you want to delete employee " + textlv + "", ""
                                    , MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    listofemployee.RemoveAt(index);
                    //EmployeeDA.Binarywriter(listofemployee);
                    MessageBox.Show("a employee has been removed");
                    Cleanfields();
                }
               
            }
            else
            {
                MessageBox.Show("You have to select a employee from the list");
            }
            
        }

        private void flatComboBoxuser_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool found = false;
            Employee nemployee = new Employee();
            foreach (Employee element in listofemployee)
            {
                if (Convert.ToString( element.Employeeid) == flatComboBoxuser.Text)
                {
                    found = true;
                    nemployee = element;
                }
            }
            if (found)
            {


                pictureBoxuser.Image = nemployee.Pictureprofile;
                labelEmpName.Text = nemployee.Username;
                labelLastName.Text = nemployee.Lastname;
                labelJobTitle.Text = nemployee.Jobtitle;



            }
        }

        private void flatButtonedit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to edit the employee ", ""
                                    , MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (Employee element in listofemployee)
                {
                    listofemployee[index].Employeeid = Convert.ToInt32(flatTextBoxempid.Text);
                    listofemployee[index].Username = flatTextBoxempname.Text;
                    listofemployee[index].Lastname = flatTextBoxemplast.Text;
                    listofemployee[index].Jobtitle = flatComboBoxempjobtitle.Text;
                    listofemployee[index].Phone = Convert.ToInt64(flatTextBoxempphone.Text);
                    listofemployee[index].Email = flatTextBoxempemail.Text;
                    listofemployee[index].Pictureprofile = pictureBoxemp.Image;
                    listofemployee[index].Status = (EnumStatus)flatComboBoxempstatus.SelectedIndex;
                    EmployeeDA.Binarywriter(listofemployee);
                }
                Cleanfields();
            }
        }

        private void flatButtonconfirmuser_Click(object sender, EventArgs e)
        {
            AddUser();
            Cleanfields();
            AddtoListUsers();
        }

        private void metroTileUserEdit_Click(object sender, EventArgs e)
        {
            if (metroListViewusers.SelectedIndices.Count >= 1)
            {
                groupBoxuser.Visible = true;
                flatButtonconfirmuser.Visible = false;
                flatButtonUserEdit.Visible = true;

                foreach (Employee element in listofemployee)
                {
                    flatComboBoxuser.Text =Convert.ToString( listofemployee[index].Employeeid);
                    flatTextBoxpasssword.Text = Convert.ToString(listofemployee[index].Password);                
                }
            }
            else
            {
                MessageBox.Show("You have to select a user From the list");
            }
        }

        private void metroTileUserList_Click(object sender, EventArgs e)
        {
            metroListViewusers.Items.Clear();
            AddtoListUsers();

        }

        private void metroTileUserDelete_Click(object sender, EventArgs e)
        {
            if (metroListViewusers.SelectedIndices.Count >= 1)
            {
                string textlv = metroListViewusers.SelectedItems[index].Text;
                if (MessageBox.Show("Are you sure you want to delete user " + textlv + "", ""
                                    , MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    listofemployee.RemoveAt(index);
                    //EmployeeDA.Binarywriter(listofemployee);
                    MessageBox.Show("a user has been removed");
                    Cleanfields();
                }

            }
            else
            {
                MessageBox.Show("You have to select a user from the list");
            }

        }

        private void flatButtonUserEdit_Click(object sender, EventArgs e)
        {
           
           
            if (MessageBox.Show("Are you sure you want to edit the user ", ""
                                   , MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (Employee element in listofemployee)
                {
                    flatComboBoxuser.Text = Convert.ToString(listofemployee[index2].Employeeid);
                    flatTextBoxpasssword.Text = Convert.ToString(listofemployee[index2].Password);
                    
                   
                }
                Cleanfields();
            }
        }

        private void metroListViewusers_SelectedIndexChanged(object sender, EventArgs e)
        {
            index2 = metroListViewusers.FocusedItem.Index;
        }
    }
}
