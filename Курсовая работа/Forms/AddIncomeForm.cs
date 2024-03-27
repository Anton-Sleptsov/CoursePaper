using Курсовая_работа.Models;

namespace Курсовая_работа
{
    public partial class AddIncomeForm : Form
    {
        private readonly User user;
        internal AddIncomeForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            DateTime date = dateOfIncome.Value;
            decimal amount = decimal.Parse(txtAmountOfIncome.Text);
            IncomeCategory category = lstIncomeCategories.SelectedItem as IncomeCategory;

            user.Incomes.Add( new(date, amount, category));
        }
    }
}
