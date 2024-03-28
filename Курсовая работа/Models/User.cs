namespace Курсовая_работа.Models
{
    internal class User
    {
        public decimal Balance
        {
            get
            {
                return AmountOfExpensesAndIncomes + UserAllowance;
            }
            set { }
        }
        public List<Expenditure> Expenses { get; set; }
        public List<Income> Incomes { get; set; }
        public List<ExpenseCategory> ExpenseCategories { get; set; }
        public List<IncomeCategory> IncomesCategories { get; set; }
        public decimal UserAllowance { get; set; }
        public decimal AmountOfExpensesAndIncomes
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
        }

        public User()
        {
            Balance = 0;
            Expenses = new();
            Incomes = new();    
            ExpenseCategories = [new("Другое")];
            IncomesCategories = [new("Другое")];

        }
    }
}
