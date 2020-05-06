using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LionKingBankAccountApp.Models
{
    public class BankAccountList
    {
        public List<BankAccount> accounts { get; set; }
        public BankAccount bankAccount { get; set; }

       

        public BankAccountList()
        {
            accounts = AccountList;
        }
        public static List<BankAccount> AccountList { get; set; } = InitializeList();

        public static List<BankAccount> InitializeList()
        {
            var list = new List<BankAccount>()
            {
                new BankAccount("Simba", 2000, "lion", true, false),
                new BankAccount("Timon", 1500, "meerkat", false, false),
                new BankAccount("Pumbaa", 3000, "warthog", false, false),
                new BankAccount("Scar", 5000, "lion", false, true),
                new BankAccount("Zazu", 1500, "bird", false, false)
            };
            return list;
        }
    }
}
