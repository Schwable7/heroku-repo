using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace LionKingBankAccountApp.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public string AnimalType { get; set; }
        public bool IsKing { get; set; }
        public bool IsBad { get; set; }
        public string Color
        {
            get
            {
                if (IsKing)
                {
                    return "color:chartreuse";
                }
                else
                {
                    return "";
                }
            }
        }

        public BankAccount()
        {

        }
        public BankAccount(string name, decimal balance, string animalType, bool isKing, bool isBad)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            IsKing = isKing;
            IsBad = isBad;
        }

    }
}
