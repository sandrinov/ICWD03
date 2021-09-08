using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            TestEntity1();
        }

        private static void TestEntity1()
        {
            NorthwindEntities ctx = new NorthwindEntities();

            var queryResult = from e in ctx.Employees
                              where e.FirstName.Length > 6
                              orderby e.LastName
                              select e;

            foreach (var employee in queryResult)
            {
                Console.WriteLine("First Name: {0} Last Name:{1}", employee.LastName, employee.FirstName);
            }
        }
    }
}
