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
    public partial class StudentPage : Form
    {
        public StudentPage()
        {
            InitializeComponent();
        }

        EntityService service = new EntityService();
        LibraryManagementEntities db = new LibraryManagementEntities();
        private void StudentPage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.StudentService.GetAll();
            var department = service.DepartmentService.GetAll();
            foreach (var item in department)
            {
                cmbdepartment.Items.Add(item.DepartmentName);
            }
        }
        public void clear()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            if (txtname.Text =="" || txtnumber.Text=="")
            {
                MessageBox.Show("Please enter the student name and student number");
                return;
            }
            std.StudentName = txtname.Text;
            std.SchoolNumber = txtnumber.Text;
            if (cmbdepartment.SelectedItem != null)
            {
                std.DepartmentID = service.DepartmentService.GetByCondition(x => x.DepartmentName == cmbdepartment.SelectedItem.ToString()).FirstOrDefault().ID;
            }
            service.StudentService.insert(std);
            MessageBox.Show("Student Saved Succesfully");
            clear();
            dataGridView1.DataSource = service.StudentService.GetAll();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            updatedstd.StudentName = txtname.Text;
            updatedstd.SchoolNumber = txtnumber.Text;
            if (cmbdepartment.SelectedItem != null)
            {
                updatedstd.DepartmentID = service.DepartmentService.GetByCondition(x => x.DepartmentName == cmbdepartment.SelectedItem.ToString()).FirstOrDefault().ID;
            }
            db.SaveChanges();
            MessageBox.Show("Student Details Updated");
            dataGridView1.DataSource = service.StudentService.GetAll();
            clear();

        }

        Student updatedstd = new Student();
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                updatedstd = db.Student.Find(id);
                txtname.Text = updatedstd.StudentName;
                txtnumber.Text = updatedstd.SchoolNumber;

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    int id = (int)item.Cells[0].Value;
                    db.Student.Remove(db.Student.Find(id));
                }
                db.SaveChanges();
                dataGridView1.DataSource = service.StudentService.GetAll();

            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.StudentService.GetByCondition(x => x.StudentName.ToLower().Contains(txtsearch.Text)).ToList();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            StartPage sp = new StartPage();
            sp.Show();
            this.Hide();
        }

    
    }
}
