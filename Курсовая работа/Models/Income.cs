namespace Курсовая_работа.Models
{
    internal class Income : Operation
    {
        public Income(DateTime date, decimal amount, IncomeCategory category) : base(date, amount, category) { }      
    }
}
