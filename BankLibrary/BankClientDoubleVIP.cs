using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class BankClientDoubleVIP: BankClient
    {
        public int StrongBoxNumber { get; set; }
        public BankClientDoubleVIP(int boxNumber)
        {
            //Accounts = new List<BankAccount>();
            StrongBoxNumber = boxNumber;
        }
    }
}
