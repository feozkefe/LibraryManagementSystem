using BLL.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class EntityService
    {
        public EntityService()
        {
            _bookService = new BooksRepository();
            _studentService = new StudentsRepository();
            _genresService = new GenresRepository();
            _departmentService = new DepartmentRepository();
            _staffService = new StaffRepository();
            _bookissueService = new BookIssueRepository();
            _bookreturnService = new BookReturnRepository();

        }
        private StudentsRepository _studentService;

        public StudentsRepository StudentService
        {
            get { return _studentService; }
            set { _studentService = value; }
        }

        private BookIssueRepository _bookissueService;

        public BookIssueRepository BookIssueService
        {
            get { return _bookissueService; }
            set { _bookissueService = value; }
        }
        private BooksRepository _bookService;

        public BooksRepository BooksService
        {
            get { return _bookService; }
            set { _bookService = value; }
        }
        private GenresRepository _genresService;

        public GenresRepository GenresService
        {
            get { return _genresService; }
            set { _genresService = value; }
        }

        private StaffRepository _staffService;

        public StaffRepository StaffService
        {
            get { return _staffService; }
            set { _staffService = value; }
        }
        private BookReturnRepository _bookreturnService;

        public BookReturnRepository BooksReturnService
        {
            get { return _bookreturnService; }
            set { _bookreturnService = value; }
        }
        private DepartmentRepository _departmentService;

        public DepartmentRepository DepartmentService
        {
            get { return _departmentService; }
            set { _departmentService = value; }
        }


    }
}

