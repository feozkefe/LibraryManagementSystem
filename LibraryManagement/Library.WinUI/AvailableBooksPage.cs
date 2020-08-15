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
            var uye = service.BooksService.GetAll();
            var uyee = service.StudentService.GetAll();
            var uyeee = service.BookIssueService.GetAll();

            foreach (var item in uye)
            {
                foreach (var bir in uyee)
                {
                    foreach (var iki in uyeee)
                    {
                        ListViewItem ekle = new ListViewItem(item.BookName);

                        ekle.SubItems.Add(bir.StudentName);
                        ekle.SubItems.Add(bir.SchoolNumber);

                        ekle.SubItems.Add(iki.IssueDate.ToString());

                        listView1.Items.Add(ekle);
                    }
                   
                }
  
            }
        }
    }
}
