using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовая_работа.Models;

namespace Курсовая_работа.Forms
{
    public partial class AllOperationsForm : Form, IContainingListBox
    {
        private readonly User user;
        private readonly MainForm mainForm;

        internal AllOperationsForm(User user, MainForm mainForm)
        {
            InitializeComponent();

            this.user = user;
            this.mainForm = mainForm;

            RenderListBox();
        }

        public void RenderListBox()
        {
            lstIncomes.Items.Clear();
            foreach (var item in user.Incomes)
                lstIncomes.Items.Add(item.Date + " " + item.Category + " " + item.Amount);

            lstExpenses.Items.Clear();
            foreach (var item in user.Expenses)
                lstExpenses.Items.Add(item.Date + " " + item.Category + " " + item.Amount);
        }

        private void pbDeleteExpense_Click(object sender, EventArgs e)
        {
            if (lstExpenses.SelectedItem == null)
            {
                MessageBox.Show("Выберите расход!");
                return;
            }

            string operationInString = lstExpenses.SelectedItem.ToString();

            DateTime date = Convert.ToDateTime(operationInString.Split(' ')[0]);
            DateTime time = Convert.ToDateTime(operationInString.Split(' ')[1]);
            DateTime dateTime = new(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);
            Category category = user.ExpenseCategories.FirstOrDefault(x => x.Title == operationInString.Split(' ')[2]);
            decimal amount = decimal.Parse(operationInString.Split(' ')[3]);
            Expenditure operation = user.Expenses.FirstOrDefault(x => x.Date.Date == dateTime.Date &&
                                                         x.Date.Hour == dateTime.Hour &&
                                                         x.Date.Minute == dateTime.Minute &&
                                                         x.Date.Second == dateTime.Second &&
                                                         x.Category == category &&
                                                         x.Amount == amount);

            if (operation == null)
            {
                MessageBox.Show("Выберите расход!");
                return;
            }

            user.Expenses.Remove(operation);

            RenderListBox();
            mainForm.ShowBalance();
        }

        private void pbDeleteIncome_Click(object sender, EventArgs e)
        {
            if (lstIncomes.SelectedItem == null)
            {
                MessageBox.Show("Выберите доход!");
                return;
            }

            string operationInString = lstIncomes.SelectedItem.ToString();

            DateTime date = Convert.ToDateTime(operationInString.Split(' ')[0]);
            DateTime time = Convert.ToDateTime(operationInString.Split(' ')[1]);
            DateTime dateTime = new(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);
            Category category = user.IncomesCategories.FirstOrDefault(x => x.Title == operationInString.Split(' ')[2]);
            decimal amount = decimal.Parse(operationInString.Split(' ')[3]);
            Income operation = user.Incomes.FirstOrDefault(x => x.Date.Date == dateTime.Date &&
                                                         x.Date.Hour == dateTime.Hour &&
                                                         x.Date.Minute == dateTime.Minute &&
                                                         x.Date.Second == dateTime.Second &&
                                                         x.Category == category &&
                                                         x.Amount == amount);

            if (operation == null)
            {
                MessageBox.Show("Выберите доход!");
                return;
            }

            user.Incomes.Remove(operation);

            RenderListBox();
            mainForm.ShowBalance();
        }

        private void pbEditExpense_Click(object sender, EventArgs e)
        {
            if (lstExpenses.SelectedItem == null)
            {
                MessageBox.Show("Выберите расход!");
                return;
            }

            string operationInString = lstExpenses.SelectedItem.ToString();

            DateTime date = Convert.ToDateTime(operationInString.Split(' ')[0]);
            DateTime time = Convert.ToDateTime(operationInString.Split(' ')[1]);
            DateTime dateTime = new(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);
            Category category = user.ExpenseCategories.FirstOrDefault(x => x.Title == operationInString.Split(' ')[2]);
            decimal amount = decimal.Parse(operationInString.Split(' ')[3]);
            Expenditure operation = user.Expenses.FirstOrDefault(x => x.Date.Date == dateTime.Date &&
                                                         x.Date.Hour == dateTime.Hour &&
                                                         x.Date.Minute == dateTime.Minute &&
                                                         x.Date.Second == dateTime.Second &&
                                                         x.Category == category &&
                                                         x.Amount == amount);

            if (operation == null)
            {
                MessageBox.Show("Выберите расход!");
                return;
            }

            EditOperationForm editOperationForm = new(this, mainForm, user, operation, TypeOfCategory.Expenditure);
            editOperationForm.Show();
        }

        private void pbEditIncome_Click(object sender, EventArgs e)
        {
            if (lstIncomes.SelectedItem == null)
            {
                MessageBox.Show("Выберите доход!");
                return;
            }

            string operationInString = lstIncomes.SelectedItem.ToString();

            DateTime date = Convert.ToDateTime(operationInString.Split(' ')[0]);
            DateTime time = Convert.ToDateTime(operationInString.Split(' ')[1]);
            DateTime dateTime = new(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);
            Category category = user.IncomesCategories.FirstOrDefault(x => x.Title == operationInString.Split(' ')[2]);
            decimal amount = decimal.Parse(operationInString.Split(' ')[3]);
            Income operation = user.Incomes.FirstOrDefault(x => x.Date.Date == dateTime.Date &&
                                                         x.Date.Hour == dateTime.Hour &&
                                                         x.Date.Minute == dateTime.Minute &&
                                                         x.Date.Second == dateTime.Second &&
                                                         x.Category == category &&
                                                         x.Amount == amount);

            if (operation == null)
            {
                MessageBox.Show("Выберите доход!");
                return;
            }

            EditOperationForm editOperationForm = new(this, mainForm, user, operation, TypeOfCategory.Income);
            editOperationForm.Show();
        }
    }
}
