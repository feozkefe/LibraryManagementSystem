using BLL.Service;
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
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        EntityService service = new EntityService();
        private void FirstPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (service.StaffService.Any(x => x.StaffName.Equals(textBox1.Text) && x.Password.Equals(textBox2.Text)))
            {
                StartPage sp1 = new StartPage();
                sp1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Staff Name or Password");
            }
        }
    }
}
