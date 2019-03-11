using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.Entity;

namespace lab_122_wpf_crud_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class StudentDataWindow : Window
    {
       
        public StudentDataWindow()
        {

            InitializeComponent();
            Initialize();

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            using (var db = new CollegeContext())
            {
                var student01 = new Student()
                {
                    StudentName = "Seb",
                    StudentID = 1,
                    Height = 715,
                    Weight = 65
                };

                db.Students.Add(student01);
                db.SaveChanges();
            }


        }
        public void Initialize()
        {
            List<Student> students = new List<Student>();
            using (var db = new CollegeContext())
            {

                students = db.Students.ToList<Student>();
            }
            ListBox namelist = new ListBox();
            namelist.ItemsSource = students;
            namelist.DisplayMemberPath = "StudentName";
        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
    }

    public class CollegeContext : DbContext
    {
        //CONSTRUCTOR method : bounce responsibikity back up to entity DbContext tgo do all the hard work
        public CollegeContext() : base("SpartaDb") { }

        public DbSet<Student> Students { get; set; }
        
    }
}
