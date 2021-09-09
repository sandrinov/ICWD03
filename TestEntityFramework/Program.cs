using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEntityFramework
{
    class Program
    {
        private static NorthwindEntities db = new NorthwindEntities();
        static void Main(string[] args)
        {
            TestEntity1();
            TestEntity2();
        }

        private static void TestEntity2()
        {
            var query2 = from p in db.Products
                         select new
                         {
                             p.ProductID,
                             p.ProductName,
                             p.UnitPrice
                         };

            var query3 = from p in db.Products
                         where p.ProductID == 1
                         select p;

            var query4 = from p in db.Products
                         where p.SupplierID == 5 && p.UnitPrice > 20
                         select p;

            var query5 = from p in db.Products
                         where p.SupplierID == 5 || p.SupplierID == 6
                         select p;

            var query6 = from p in db.Products
                         orderby p.ProductID
                         select p;

            var query7 = from p in db.Products
                         orderby p.ProductID descending
                         select p;

            var query8 = from p in db.Products
                         orderby p.CategoryID, p.UnitPrice descending
                         select p;

            // Select Top 10 * From Products
            var query9 = (from p in db.Products
                          select p).Take(10);

            var query11 = (from p in db.Products
                           select p).First();

            // Select Distinct CategoryId From Products
            var query13 = (from p in db.Products
                           select p.CategoryID).Distinct();

            // Select CategoryId, Count(CategoryID) As NewField 
            var query14 = from p in db.Products
                          group p by p.CategoryID into g
                          select new
                          {
                              CategoryId = g.Key,
                              NewField = g.Count()
                          };

        }

        private static void PrintResult(IQueryable q)
        {

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
