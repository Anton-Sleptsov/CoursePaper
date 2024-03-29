namespace Курсовая_работа.Models
{
    internal class Expenditure : Operation
    {
        public Expenditure(DateTime date, decimal amount, ExpenseCategory category,string description) : base(date, amount, category, description) { }
    }
}
