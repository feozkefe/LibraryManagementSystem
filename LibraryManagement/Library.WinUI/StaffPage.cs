using BLL.Service;
using Library.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.WinUI
{
    public partial class StaffPage : Form
    {
        public StaffPage()
        {
            InitializeComponent();
        }

        EntityService service = new EntityService();
        private void button1_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            if (txtname.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Please enter the name and password");
                return;
            }
            if (txtpassword.Text == txtconfirm.Text)
            {
                staff.StaffName = txtname.Text;
                staff.Password = txtpassword.Text;
                service.StaffService.insert(staff);
                MessageBox.Show("New Staff Added Succesfully");
            }
            else
            {
                MessageBox.Show("Passwords don't match");
            }      
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartPage sp = new StartPage();
            sp.Show();
            this.Hide();
        }
    }
}
