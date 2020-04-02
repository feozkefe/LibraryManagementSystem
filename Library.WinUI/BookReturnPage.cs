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
    public partial class BookReturnPage : Form
    {
        public BookReturnPage()
        {
            InitializeComponent();
        }

        EntityService service = new EntityService();
        LibraryManagementEntities db = new LibraryManagementEntities();
        private void btnexit_Click(object sender, EventArgs e)
        {
            StartPage sp = new StartPage();
            sp.Show();
            this.Hide();
        }

        private void BookReturnPage_Load(object sender, EventArgs e)
        {
            datastudent.DataSource = service.StudentService.GetAll();
            databook.DataSource = service.BooksService.GetByCondition(x => x.Available == false);
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            BookReturn returnedbook = new BookReturn();
            Books newstock2 = new Books();
            int bookid = Convert.ToInt32(databook.SelectedRows[0].Cells[0].Value);
            int stdid = Convert.ToInt32(datastudent.SelectedRows[0].Cells[0].Value);
            returnedbook.BookID = bookid;
            returnedbook.StudentID = stdid;
            returnedbook.ReturnDate = DateTime.Today;
            service.BooksReturnService.insert(returnedbook);

            int id = Convert.ToInt32(databook.SelectedRows[0].Cells[0].Value);
            newstock2 = db.Books.Find(id);
            newstock2.BookName= databook.SelectedRows[0].Cells[1].Value.ToString();
            newstock2.Author= databook.SelectedRows[0].Cells[2].Value.ToString();
            newstock2.GenresID= Convert.ToInt32(databook.SelectedRows[0].Cells[3].Value);
            newstock2.Available = true;
            db.SaveChanges();
            MessageBox.Show("Book Return is Recorded");
            datastudent.DataSource = service.StudentService.GetAll();
            databook.DataSource = service.BooksService.GetByCondition(x => x.Available == false);
        }
    }
}
