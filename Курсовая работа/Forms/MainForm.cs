using CoursePaper.Forms;
using CoursePaper.Models;
using Курсовая_работа;

namespace CoursePaper
{
    public partial class MainForm : Form
    {
        readonly User user = SerializableSaver.Load<User>() ?? new();

        public MainForm()
        {
            InitializeComponent();
            ShowBalance();
        }

        public void ShowBalance()
        {
            txtBalance.Text = user.Balance.ToString();
            if (user.Balance < 0)
            {
                txtBalance.ForeColor = Color.Red;
                lblBalance.ForeColor = Color.Red;
            }
            else
            {
                txtBalance.ForeColor = Color.Black;
                lblBalance.ForeColor = Color.Black;
            }
        }

        private void btnOpenAddExpenditureForm_Click(object sender, EventArgs e)
        {
            if (txtBalance.Enabled)
            {
                MessageBox.Show("Сначала закончите редактирование баланса!");
                return;
            }

            AddExpenditureForm addExpenditureForm = new(user, this);
            addExpenditureForm.Show();
        }

        private void btnOpenAddIncomeForm_Click(object sender, EventArgs e)
        {
            if (txtBalance.Enabled)
            {
                MessageBox.Show("Сначала закончите редактирование баланса!");
                return;
            }

            AddIncomeForm addIncomeForm = new(user, this);
            addIncomeForm.Show();
        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            if (txtBalance.Enabled)
            {
                if (!decimal.TryParse(txtBalance.Text, out decimal input))
                {
                    MessageBox.Show("Введите сумму в верном формате!");
                    ShowBalance();
                    txtBalance.Enabled = false;
                    return;
                }

                user.UserAllowance = input - user.AmountOfExpensesAndIncomes;
                ShowBalance();
            }

            txtBalance.Enabled = !txtBalance.Enabled;
        }

        private void btnAllCategories_Click(object sender, EventArgs e)
        {
            if (txtBalance.Enabled)
            {
                MessageBox.Show("Сначала закончите редактирование баланса!");
                return;
            }

            AllCategoriesForm allCategoriesForm = new(user);
            allCategoriesForm.Show();
        }

        private void btnTableOfOperations_Click(object sender, EventArgs e)
        {
            if (txtBalance.Enabled)
            {
                MessageBox.Show("Сначала закончите редактирование баланса!");
                return;
            }

            TableOfOperationsForm tableOfOperationsForm = new(user);
            tableOfOperationsForm.Show();
        }

        private void btnEditOperations_Click(object sender, EventArgs e)
        {
            if (txtBalance.Enabled)
            {
                MessageBox.Show("Сначала закончите редактирование баланса!");
                return;
            }

            AllOperationsForm allOperationsForm = new(user, this);
            allOperationsForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializableSaver.Save(user);
        }
    }
}
