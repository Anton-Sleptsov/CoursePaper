namespace Курсовая_работа.Models
{
    internal class User
    {
        public decimal Balance
        {
            get
            {
                decimal sum = 0;
                foreach (var expenditure in Expenses)
                    sum -= expenditure.Amount;

                foreach (var income in Incomes)
                    sum += income.Amount;

                return sum;
            }
            set { }
        }
        public List<Expenditure> Expenses { get; set; }
        public List<Income> Incomes { get; set; }
        public List<ExpenseCategory> ExpenseCategories { get; set; }
        public List<IncomeCategory> IncomesCategories { get; set; }
    }
}
