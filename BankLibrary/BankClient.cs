using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class BankClient : Person
    {
        public List<BankAccount> Accounts { get; set; }

        public BankClient()
        {
            Accounts = new List<BankAccount>();
        }
    }
}
