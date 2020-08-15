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
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void btnbooks_Click(object sender, EventArgs e)
        {
            BookPage book = new BookPage();
            book.Show();
            this.Hide();
        }

        private void btnstudents_Click(object sender, EventArgs e)
        {
            StudentPage student = new StudentPage();
            student.Show();
            this.Hide();

        }

        private void btnissue_Click(object sender, EventArgs e)
        {
            BookIssuePage bookissue = new BookIssuePage();
            bookissue.Show();
            this.Hide();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            BookReturnPage bookreturn = new BookReturnPage();
            bookreturn.Show();
            this.Hide();
        }

        private void btnavailable_Click(object sender, EventArgs e)
        {
            AvailableBooksPage bookavailable = new AvailableBooksPage();
            bookavailable.Show();
            this.Hide();
        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            StaffPage staff = new StaffPage();
            staff.Show();
            this.Hide();
        }
    }
}
