namespace Курсовая_работа.Models
{
    internal class Income
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; } 
        public IncomeCategory Category { get; set; } 

        public Income(DateTime date, decimal amount, IncomeCategory category)
        {
            Date = date;
            Amount = amount;
            Category = category;
        }
    }
}
