﻿using CoursePaper.Forms;
using CoursePaper.Models;

namespace CoursePaper
{
    public partial class AddIncomeForm : Form, IContainingListBox
    {
        private readonly User user;
        private readonly MainForm mainForm;

        internal AddIncomeForm(User user, MainForm mainForm)
        {
            InitializeComponent();

            this.user = user;
            this.mainForm = mainForm;
            dateOfIncome.Value = DateTime.Now;

            RenderListBox();
        }

        public void RenderListBox()
        {
            lstIncomeCategories.Items.Clear();
            foreach (var item in user.IncomesCategories)
                lstIncomeCategories.Items.Add(item);
        }

        private void btnAddIncomeCategory_Click(object sender, EventArgs e)
        {
            AddingCategoryForm addingCategory = new(user, TypeOfCategory.Income, this);
            addingCategory.ShowDialog();
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            DateTime date = dateOfIncome.Value;
            if (date > DateTime.Now)
            {
                MessageBox.Show("Дата дохода не может находиться в будущем!");
                dateOfIncome.Value = DateTime.Now;
                return;
            }

            if (!decimal.TryParse(txtAmountOfIncome.Text, out decimal amount))
            {
                MessageBox.Show("Введите сумму в верном формате!");
                txtAmountOfIncome.Text = string.Empty;
                return;
            }
            else if (amount < 0)
            {
                MessageBox.Show("Сумма не может быть отрицательной!");
                txtAmountOfIncome.Text = string.Empty;
                return;
            }

            if (lstIncomeCategories.SelectedItem == null)
            {
                MessageBox.Show("Выберите категорию!");
                return;
            }
            string categoryInString = lstIncomeCategories.SelectedItem.ToString();
            IncomeCategory category = user.IncomesCategories.FirstOrDefault(x => x.Title == categoryInString);
            if (category == null)
            {
                MessageBox.Show("Выберите категорию!");
                return;
            }

            string description = txtDescriptionOfIncome.Text;

            user.Incomes.Add(new(date, amount, category, description));
            Close();
            mainForm.ShowBalance();
        }
    }
}
