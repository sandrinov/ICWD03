using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class BankClient
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String  Address { get; set; }
        public List<BankAccount> Accounts { get; set; }

        public BankClient()
        {
            Accounts = new List<BankAccount>();
        }
    }
}
