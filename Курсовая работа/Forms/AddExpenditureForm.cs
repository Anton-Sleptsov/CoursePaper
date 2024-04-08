using CoursePaper.Models;

namespace CoursePaper.Forms
{
    public partial class AddExpenditureForm : Form, IContainingListBox
    {
        private readonly User user;
        private readonly MainForm mainForm;

        internal AddExpenditureForm(User user, MainForm mainForm)
        {
            InitializeComponent();

            this.user = user;
            this.mainForm = mainForm;
            dateOfExpenditure.Value = DateTime.Now;

            RenderListBox();
        }

        public void RenderListBox()
        {
            lstExpenseCategories.Items.Clear();
            foreach (var item in user.ExpenseCategories)
                lstExpenseCategories.Items.Add(item);
        }

        private void btnAddExpenseCategory_Click(object sender, EventArgs e)
        {
            AddingCategoryForm addingCategory = new(user, TypeOfCategory.Expenditure, this);
            addingCategory.Show();
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            DateTime date = dateOfExpenditure.Value;
            if (date > DateTime.Now)
            {
                MessageBox.Show("Дата расхода не может находиться в будущем!");
                dateOfExpenditure.Value = DateTime.Now;
                return;
            }

            if (!decimal.TryParse(txtAmountOfExpense.Text, out decimal amount))
            {
                MessageBox.Show("Введите сумму в верном формате!");
                txtAmountOfExpense.Text = string.Empty;
                return;
            }
            else if (amount < 0)
            {
                MessageBox.Show("Сумма не может быть отрицательной!");
                txtAmountOfExpense.Text = string.Empty;
                return;
            }

            if (lstExpenseCategories.SelectedItem == null)
            {
                MessageBox.Show("Выберите категорию!");
                return;
            }
            string categoryInString = lstExpenseCategories.SelectedItem.ToString();
            ExpenseCategory category = user.ExpenseCategories.FirstOrDefault(x => x.Title == categoryInString);
            if (category == null)
            {
                MessageBox.Show("Выберите категорию!");
                return;
            }

            string description = txtDescriptionOfExpense.Text;

            user.Expenses.Add(new(date, amount, category, description));
            Close();
            mainForm.ShowBalance();
        }
    }
}
