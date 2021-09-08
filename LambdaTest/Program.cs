using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace LambdaTest
{
    class Program
    {
        public delegate bool FilterInt(int i);
        static void Main(string[] args)
        {
            int i = 10;
            
            if (i.IsGreaterThan(100))
                Console.WriteLine("i is grreat than 100");
            else
                Console.WriteLine("i is less or equal than 100");


            String s = "lkn";

            Func<int, bool> equalsFive = x => x == 5;
            bool result = equalsFive(4);
            Console.WriteLine(result);   // False


            List<int> listOfInt = new List<int> { 0,1,2,3,4,5,6,7,8,9};

            FilterInt filterOdd = new FilterInt(IsOdd);
            //List<int> oddList = FilterList(listOfInt, filterOdd);
            //foreach (int i in oddList)
            //{
            //    Console.WriteLine(i);
            //}

            //  Lambda Expression:           item => (item & 1) == 1

            List<int> oddList = FilterList(listOfInt, item => (item & 1) == 1);
            foreach (int item in oddList)
            {
                Console.WriteLine(item);
            }
            /*
            
            FilterInt filterEven = new FilterInt(IsEven);
            List<int> evenList = FilterList(listOfInt, filterEven);
            foreach (int i in evenList)
            {
                Console.WriteLine(i);
            }

            FilterInt filterMultiple3 = new FilterInt(IsMultipleOf3);
            List<int> multiple3List = FilterList(listOfInt, filterMultiple3);
            foreach (int i in multiple3List)
            {
                Console.WriteLine(i);
            }
            */
        }
        public static bool IsOdd(int i)
        {
            //if (i % 2 == 0)
            //    return false;
            //else
            //    return true;
            return (i & 1) == 1;
        }
        public static bool IsEven(int i)
        {
            if (i % 2 != 0)
                return false;
            else
                return true;
        }
        public static bool IsMultipleOf3(int i)
        {
            if (i % 3 != 0)
                return false;
            else
                return true;
        }
        private static List<int> FilterList(List<int> list, FilterInt filter)
        {
            List<int> resultlist = new List<int>();
            foreach (int item in list)
            {
                if (filter(item))
                    resultlist.Add(item);
            }

            return resultlist;
        }
    }
}
