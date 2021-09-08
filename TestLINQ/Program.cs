using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLINQ
{
    class Program
    {
        private static IList<Student> studentList = new List<Student>() {
    new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
};

        private static IList<Standard> standardList = new List<Standard>() {
    new Standard(){ StandardID = 1, StandardName="Standard 1"},
    new Standard(){ StandardID = 2, StandardName="Standard 2"},
    new Standard(){ StandardID = 3, StandardName="Standard 3"}
};

        static void Main(string[] args)
        {
            /*
            IEnumerable<Student> queryResult1 = studentList.Where(s => s.Age > 18 && s.StudentName.StartsWith("R"))
                                                          .OrderByDescending(s => s.StudentName)
                                                          .Select(s => s);
            foreach (var item in queryResult1)
            {
                Console.WriteLine(item.StudentName);
            }
            
            var queryResult2 = from s in studentList
                               where s.Age > 20
                               orderby s.StudentName
                               select new { Name = s.StudentName, Age = s.Age };

            foreach (var item in queryResult2)
            {
                Console.WriteLine("Student Name: {0}  Age: {1}", item.Name, item.Age);
            }
            */
            //Inner Join
            var queryResult3 = from s in studentList
                                      join stad in standardList
                                      on s.StandardID equals stad.StandardID
                                      select new { Name = s.StudentName, Standard = stad.StandardName };
            foreach (var item in queryResult3)
            {
                Console.WriteLine("Student Name: {0}  Standard Name: {1}", item.Name, item.Standard);
            }

        }
    }
}
