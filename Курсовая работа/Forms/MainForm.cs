using Курсовая_работа.Forms;
using Курсовая_работа.Models;

namespace Курсовая_работа
{
    public partial class MainForm : Form
    {
        User user = new();

        public MainForm()
        {
            InitializeComponent();
        }

        public void ShowBalance()
        {
            txtBalance.Text = user.Balance.ToString();
        }

        private void btnOpenAddExpenditureForm_Click(object sender, EventArgs e)
        {
            AddExpenditureForm addExpenditureForm = new(user, this);
            addExpenditureForm.Show();
        }

        private void btnOpenAddIncomeForm_Click(object sender, EventArgs e)
        {
            AddIncomeForm addIncomeForm = new(user, this);
            addIncomeForm.Show();
        }
    }
}
