using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolWinForm
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private List<Grade> grades = new List<Grade>();


        public Form1()
        {
            InitializeComponent();
            // 1) Inizializzare lista grades
            grades.Add(new Grade() { GradeID = 1, GradeName = "Prima A" });
            grades.Add(new Grade() { GradeID = 2, GradeName = "Seconda A" });
            grades.Add(new Grade() { GradeID = 3, GradeName = "Terza B" });

            // 2) Inizializzare lista students
            students.Add(new Student() { StudentID = 1, StudentName = "John", Age = 18, GradeID = 1 });
            students.Add(new Student() { StudentID = 2, StudentName = "Steve", Age = 21, GradeID = 1 });
            students.Add(new Student() { StudentID = 3, StudentName = "Bill", Age = 18, GradeID = 2 });
            students.Add(new Student() { StudentID = 4, StudentName = "Ram", Age = 20, GradeID = 2 });
            students.Add(new Student() { StudentID = 5, StudentName = "Ron", Age = 21, GradeID = 3 });
            students.Add(new Student() { StudentID = 6, StudentName = "Billy", Age = 18, GradeID = 1 });
            students.Add(new Student() { StudentID = 7, StudentName = "Zebra", Age = 21, GradeID = 1 });
            students.Add(new Student() { StudentID = 8, StudentName = "Toro", Age = 18, GradeID = 1 });
            students.Add(new Student() { StudentID = 9, StudentName = "Falco", Age = 20, GradeID = 1 });
            students.Add(new Student() { StudentID = 10, StudentName = "Giulio", Age = 21, GradeID = 1 });

            // 3) Popolare la combo cmb_grades
            foreach (Grade grade in grades)
            {
                this.cmb_grades.Items.Add(grade.GradeName);
            }
        }

        private void cmb_grades_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Popolare la Listbox con gli studenti della classe scelta
            string gradeNameSelected = this.cmb_grades.SelectedItem.ToString();

            /*
            var queryResult1 = (from g in grades
                              where g.GradeName == gradeNameSelected
                              select g).FirstOrDefault();

            if (queryResult1 != null)
            {
                var queryresult2 = from s in students
                                   where s.GradeID == queryResult1.GradeID
                                   select s;

                this.lst_students.Items.Clear();

                foreach (var item in queryresult2)
                {
                    this.lst_students.Items.Add(item.StudentID + " " + item.StudentName);
                }
            }

            */
            var queryResult = from s in students
                              join g in grades on s.GradeID equals g.GradeID
                              where g.GradeName == gradeNameSelected
                              select s;
            this.lst_students.Items.Clear();

            foreach (var item in queryResult)
            {
                this.lst_students.Items.Add(item.StudentID + " " + item.StudentName);
            }
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            //Usare linq per ordinare la lista in base al campo StudentName
            if (this.cmb_grades.SelectedItem != null)
            {
                string gradeNameSelected = this.cmb_grades.SelectedItem.ToString();
                var queryResult = from s in students
                                  join g in grades on s.GradeID equals g.GradeID
                                  where g.GradeName == gradeNameSelected
                                  orderby s.StudentName
                                  select s;

                this.lst_students.Items.Clear();

                foreach (var item in queryResult)
                {
                    this.lst_students.Items.Add(item.StudentID + " " + item.StudentName);
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            // Leggere il campo text di txt_search (StudentName)
            // Usare linq per trovare (oppure no) lo StudentName
            // Visualizzarlo nella label lbl_resultSearch 
            string searchString = this.txt_search.Text;
            if(!String.IsNullOrEmpty(searchString))
            {
                this.lbl_resultSearch.Text = "";

                var queryResult = (from st in students
                                   where st.StudentName.ToUpper() == searchString.ToUpper()
                                   select st).FirstOrDefault();
                Student s = queryResult;
                if (s != null)
                {
                    int gradeID = s.GradeID;
                    Grade grade = (from g in grades
                                   where g.GradeID == gradeID
                                   select g).FirstOrDefault();

                    this.lbl_resultSearch.Text = s.StudentName + " " + grade.GradeName;
                }
                else
                {
                    this.lbl_resultSearch.Text = "Not Found";
                }
            }
        }
    }
}
