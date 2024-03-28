using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа.Models
{
    internal abstract class Operation
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public Category Category { get; set; }

        public Operation(DateTime date, decimal amount, Category category)
        {
            Date = date;
            Amount = amount;
            Category = category;
        }
    }
}
