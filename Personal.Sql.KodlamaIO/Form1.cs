using Sql.Business.Abstract;
using Sql.Business.Concrete;
using Sql.DataAccess.Concrete;

namespace Personal.Sql.KodlamaIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _categoryManager = new CategoryManager(new CategoryDal());
            _courseManager = new CourseManager(new CourseDal());
            _instructorManager = new InstructorManager(new InstructorDal());
        }

        private ICourseManager _courseManager;
        private IInstructorManager _instructorManager;
        private ICategoryManager _categoryManager;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCourses();
            LoadCategories();
            cbxInstructor.DataSource = _instructorManager.GetAll();
            cbxInstructor.DisplayMember = "InstructorName";
            cbxInstructor.ValueMember = "InstructorId";
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryManager.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
        }

        private void LoadCourses()
        {
            try
            {
                dgwCourses.DataSource = _courseManager.GetAll().ToList();
            }
            catch
            {


            }

        }

    }
}
