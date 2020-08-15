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
    public partial class BookPage : Form
    {
        public BookPage()
        {
            InitializeComponent();
        }

        LibraryManagementEntities db = new LibraryManagementEntities();
        public void clear()
        {
            foreach (Control item in Controls)
            {
                if(item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
                if (item is ComboBox)
                {
                    ComboBox cbox = (ComboBox)item;
                    cbox.SelectedItem = null;
                }
            }
        }

        EntityService service = new EntityService();
        private void BookPage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.BooksService.GetAll();

            var genres = service.GenresService.GetAll();
            foreach (var item in genres)
            {
                comboBox1.Items.Add(item.CategoryName);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            if (txtname.Text=="" || txtauthor.Text=="")
            {
                MessageBox.Show("Please enter the book and author name");
                return;
            }
            book.BookName = txtname.Text;
            book.Author = txtauthor.Text;
            if (comboBox1.SelectedItem != null)
            {
                book.GenresID = service.GenresService.GetByCondition(x => x.CategoryName == comboBox1.SelectedItem.ToString()).FirstOrDefault().ID;
            }
            if (checkBox1.Checked)
            {
                book.Available = true;
            }
            else
            {
                book.Available = false;
            }
            service.BooksService.insert(book);
            MessageBox.Show("Book Added Succesfully");
            clear();
            dataGridView1.DataSource = service.BooksService.GetAll();
        }

        Books updatedbook = new Books();
        private void btnupdate_Click(object sender, EventArgs e)
        {
            updatedbook.BookName = txtname.Text;
            updatedbook.Author = txtauthor.Text;
            if (comboBox1.SelectedItem != null)
            {
                updatedbook.GenresID = service.GenresService.GetByCondition(x => x.CategoryName == comboBox1.SelectedItem.ToString()).FirstOrDefault().ID;
            }
            if (checkBox1.Checked)
            {
                updatedbook.Available = true;
            }
            else
            {
                updatedbook.Available = false;
            }
            db.SaveChanges();
            MessageBox.Show("Book Details Updated");
            dataGridView1.DataSource = service.BooksService.GetAll();
            clear();

        }
        
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                updatedbook = db.Books.Find(id);
                txtname.Text = updatedbook.BookName;
                txtauthor.Text = updatedbook.Author;

                    //DataGridViewRow row = dataGridView1.Rows[id-1];
                    //txtname.Text = row.Cells[1].Value.ToString();
                    //txtauthor.Text = row.Cells[2].Value.ToString();
                    //comboBox1.SelectedItem = row.Cells[3].Value.ToString();
                                   
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtname.Text = row.Cells[1].Value.ToString();
                txtauthor.Text = row.Cells[2].Value.ToString();
                comboBox1.SelectedItem = row.Cells[3].Value.ToString();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    int id = (int)item.Cells[0].Value;
                    db.Books.Remove(db.Books.Find(id));
                }
                db.SaveChanges();
                dataGridView1.DataSource = service.BooksService.GetAll();
                
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.BooksService.GetAll().Where(x => x.BookName.ToLower().Contains(txtsearch.Text)).ToList();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            StartPage sp = new StartPage();
            sp.Show();
            this.Hide();
        }
    }
}
