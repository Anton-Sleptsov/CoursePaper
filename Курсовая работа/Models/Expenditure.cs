namespace Курсовая_работа.Models
{
    internal class Expenditure : Operation
    {
        public Expenditure(DateTime date, decimal amount, ExpenseCategory category) : base(date, amount, category) { }
    }
}
