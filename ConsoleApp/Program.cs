using BankLibrary;
using GeometryLib;
using GeometryLib2;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test1();
            //TestBankAccount();
            //TestBankAccountWithClient();
            //TestInheritance();
            //TestGeometry1();
            TestGeometry2();
        }

        private static void TestGeometry2()
        {
            Circle c1 = new Circle(10);
            Square sq1 = new Square(10);
            PrintGeometricFigure(c1);
            PrintGeometricFigure(sq1);
        }
        private static void PrintGeometricFigure(GeometryFigure fg)
        {
            Console.WriteLine("Area: {0} Perimetro: {1}", fg.GetArea(), fg.GetPerimetro());
        }

        private static void TestGeometry1()
        {
            //Cerchio c1 = new Cerchio(10);
            //PrintCerchio(c1);
            //Quadrato q1 = new Quadrato(10);
            //PrintQuadrato(q1);
            Cerchio c1 = new Cerchio(10);
            Quadrato q1 = new Quadrato(10);
            PrintFigura(c1);
            PrintFigura(q1);
        }

        private static void PrintQuadrato(Quadrato q1)
        {
            Console.WriteLine("Area: {0} Perimetro: {1}", q1.GetArea(), q1.GetPerimetro());
        }

        private static void PrintCerchio(Cerchio c1)
        {
            Console.WriteLine("Area: {0} Perimetro: {1}", c1.GetArea(), c1.GetPerimetro());
        }

        private static void PrintFigura(IFiguraGeometrica fg)
        {
            Console.WriteLine("Area: {0} Perimetro: {1}", fg.GetArea(), fg.GetPerimetro());
        }

        private static void TestInheritance()
        {
            BankClient bc = new BankClient();

            BankClientDoubleVIP dvip = new BankClientDoubleVIP(1234);

            BankLibrary.BankAccount Conto1;
            Conto1 = new BankLibrary.BankAccount("123456", 0);
            Conto1.Deposit(2000);

            dvip.Accounts.Add(Conto1);
            
            Console.WriteLine("OK for client {0} {1}", dvip.FirstName, dvip.LastName);
        }
        private static void TestBankAccountWithClient()
        {
            BankLibrary.BankClient mrJoe = new BankLibrary.BankClient();

            BankLibrary.BankAccount Conto1;
            Conto1 = new BankLibrary.BankAccount("123456", 0);
            Conto1.Deposit(2000);

            BankLibrary.BankAccount Conto2;
            Conto2 = new BankLibrary.BankAccount("6775556");
            Conto2.Deposit(1000);

            mrJoe.Accounts.Add(Conto1);
            mrJoe.Accounts.Add(Conto2);

            double tempBalance = 0;

            foreach (BankLibrary.BankAccount account in mrJoe.Accounts)
            {
                tempBalance += account.GetBalance();
            }

            Console.WriteLine("Saldo totale per tutti i conti: {0}", tempBalance);
        }
        private static void TestBankAccount()
        {
            BankLibrary.BankAccount Conto1;
            Conto1 = new BankLibrary.BankAccount("123456", 0);

            Conto1.Deposit(1000);


            bool ControlloPrelievo = Conto1.Withdraw(1600);

            if (ControlloPrelievo != false)
            {
                Console.WriteLine("Saldo conto numero {0}:  {1}", Conto1.AccountNumber, Conto1.GetBalance());
            }
            else
            {
                Console.WriteLine("non Possibile il prelievo per il conto {0}", Conto1.AccountNumber);
            }
        }
        private static void Test1()
        {
            Class1 c;

            System.Int32 x = 10;
            int y = 20;
            System.String result = "Risultato: ";

            int z = Somma(x, y);
            result += z;
            System.Console.WriteLine(result);
        }
        private static int Somma(int add1, int add2)
        {
            System.Drawing.Bitmap bm;
            return add1 + add2;
        }
    }
}
