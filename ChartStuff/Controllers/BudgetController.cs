using ChartStuff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChartStuff.Controllers
{
    public class BudgetController : Controller
    {
        // GET: Budget
        public ActionResult Index()
        {
            var data = new Budget
            {
                Incomes = new List<Income>
                {
                    new Income { Source = "Comic Book Sales", Amount = 1000.54M },
                    new Income { Source = "McDonalds", Amount = 349.43M },
                },
                Expenses = new List<Expense>
                {
                    new Expense { Name = "Food", Amount = 278.43M },
                    new Expense { Name = "Fishtank supplies", Amount = 20.60M },
                    new Expense { Name = "Rent", Amount = 800.00M },
                    new Expense { Name = "Haircut", Amount = 12.95M }
                }
            };

            IEnumerable<Budget> list = new List<Budget> { data };

            //pretend that came from a database

            var budget = list.First();

            var vm = new BudgetIndexViewModel();
            vm.Budget = budget;

            foreach (var expense in vm.Budget.Expenses)
            {
                vm.TotalExpenses += expense.Amount;
            }

            foreach (var income in vm.Budget.Incomes)
            {
                vm.TotalIncome += income.Amount;
            }


            return View(vm);
        }
    }

    public class BudgetIndexViewModel
    {
        public Budget Budget { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal TotalIncome { get; set; }
    }
}