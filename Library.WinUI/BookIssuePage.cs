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
    public partial class BookIssuePage : Form
    {
        public BookIssuePage()
        {
            InitializeComponent();
        }

        EntityService service = new EntityService();
        LibraryManagementEntities db = new LibraryManagementEntities();
        private void BookIssuePage_Load(object sender, EventArgs e)
        {
            datastudent.DataSource = service.StudentService.GetAll();
            databook.DataSource = service.BooksService.GetByCondition(x=> x.Available==true);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            StartPage sp = new StartPage();
            sp.Show();
            this.Hide();
        }

        
        private void btngive_Click(object sender, EventArgs e)
        {
            BookIssue issue = new BookIssue();
            Books newstock = new Books();
            int bookid = Convert.ToInt32(databook.SelectedRows[0].Cells[0].Value);
            int stdid = Convert.ToInt32(datastudent.SelectedRows[0].Cells[0].Value);
            issue.BookID = bookid;
            issue.StudentID = stdid;
            issue.IssueDate = DateTime.Today;
            service.BookIssueService.insert(issue);

            int id = Convert.ToInt32(databook.SelectedRows[0].Cells[0].Value);
            newstock = db.Books.Find(id);
            newstock.BookName = databook.SelectedRows[0].Cells[1].Value.ToString();
            newstock.Author = databook.SelectedRows[0].Cells[2].Value.ToString();
            newstock.GenresID = Convert.ToInt32(databook.SelectedRows[0].Cells[3].Value);
            newstock.Available = false;
            db.SaveChanges();
            MessageBox.Show("Book Issue is Recorded");
            datastudent.DataSource = service.StudentService.GetAll();
            databook.DataSource = service.BooksService.GetByCondition(x => x.Available == true);


        }
    }
}
