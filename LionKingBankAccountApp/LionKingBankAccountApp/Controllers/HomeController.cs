using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LionKingBankAccountApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LionKingBankAccountApp.Controllers
{

    public class HomeController : Controller
    {
        
        [HttpGet("show")]
        public IActionResult Index()
        {
            var simbaAcc = new BankAccount()
            {
                Name = "Simba",
                Balance = 2000,
                AnimalType = "lion"
            };
            return View(simbaAcc);
        }
        [HttpGet("string")]
        public IActionResult ShowString()
        {
            var text = "This is an <em>HTML</em> text. <b>Enjoy yourself!</b>";
            return View(text as object);
        }
        [HttpGet("accounts")]
        public IActionResult ShowMultipleAccounts()
        {
            var accounts = new BankAccountList();
           

            return View("Test", accounts);
        }
        [HttpPost]
        public IActionResult RaiseTheBalance(int increment)
        {
            
            foreach (var item in BankAccountList.AccountList)
            {
                if (item.IsKing)
                {
                    item.Balance += increment + 90;
                }
                else
                {
                    item.Balance += increment;
                }
            }
            var accounts = new BankAccountList();
            return View("Test", accounts);
        }
        [HttpPost]
        public IActionResult AddNewAccount(string name, decimal balance, string animalType,bool isKing, bool isBad)
        {
            var accounts = new BankAccountList();
            accounts.accounts.Add(new BankAccount(name, balance, animalType, isKing, isBad));
            return View("Test", accounts);
        }
    }
}