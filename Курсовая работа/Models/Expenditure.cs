namespace Курсовая_работа.Models
{
    internal class Expenditure
    {
        public DateTime Date { get; set; } 
        public decimal Amount { get; set; } 
        public ExpenseCategory Category { get; set; }

        public Expenditure(DateTime date, decimal amount, ExpenseCategory category)
        {
            Date = date;
            Amount = amount;
            Category = category;
        }
    }
}
