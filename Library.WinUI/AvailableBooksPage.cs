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
    public partial class AvailableBooksPage : Form
    {
        public AvailableBooksPage()
        {
            InitializeComponent();
        }

        EntityService service = new EntityService();
        private void button1_Click(object sender, EventArgs e)
        {
            StartPage sp1 = new StartPage();
            sp1.Show();
            this.Hide();
        }

        private void AvailableBooksPage_Load(object sender, EventArgs e)
        {



        }
    }
}
