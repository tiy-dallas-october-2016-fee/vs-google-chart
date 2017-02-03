using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChartStuff.Models
{
    public class Budget
    {
        public IEnumerable<Income> Incomes { get; set; }
        public IEnumerable<Expense> Expenses { get; set; }
    }

    public class Income
    {
        public decimal Amount { get; set; }
        public string Source { get; set; }
    }

    public class Expense
    {
        public decimal Amount { get; set; }
        public string Name { get; set; }
    }
}