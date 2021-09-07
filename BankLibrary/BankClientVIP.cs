using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class BankClientVIP : BankClient
    {
        public int SafeDepositBoxNumber { get; set; }

        public BankClientVIP(int boxNumber)
        {
            //Accounts = new List<BankAccount>();
            SafeDepositBoxNumber = boxNumber;
        }
    }
}
