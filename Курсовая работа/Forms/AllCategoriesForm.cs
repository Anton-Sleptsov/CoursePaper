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
    public partial class AllCategoriesForm : Form, IContainingListOfCategories
    {
        private readonly User user;

        internal AllCategoriesForm(User user)
        {
            InitializeComponent();

            this.user = user;

            RenderListOfCategories();
        }

        public void RenderListOfCategories()
        {
            lstIncomeCategories.Items.Clear();
            foreach (var item in user.IncomesCategories)
                lstIncomeCategories.Items.Add(item);

            lstExpenseCategories.Items.Clear();
            foreach (var item in user.ExpenseCategories)
                lstExpenseCategories.Items.Add(item);
        }

        private void pbUpdateCategories_Click(object sender, EventArgs e)
        {
            RenderListOfCategories();
        }

        private void pbAddExpenseCategory_Click(object sender, EventArgs e)
        {
            AddingCategoryForm addingCategory = new(user, TypeOfCategory.Expenditure, this);
            addingCategory.Show();
        }

        private void pbDeleteExpenseCategory_Click(object sender, EventArgs e)
        {
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

            DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить категорию\"{category.Title}\"?",
                "Удаление", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                user.ExpenseCategories.Remove(category);

            RenderListOfCategories();
        }

        private void pbAddIncomeCategory_Click(object sender, EventArgs e)
        {
            AddingCategoryForm addingCategory = new(user, TypeOfCategory.Income, this);
            addingCategory.Show();
        }

        private void pbDeleteIncomeCategory_Click(object sender, EventArgs e)
        {
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

            DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить категорию\"{category.Title}\"?",
                "Удаление", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                user.IncomesCategories.Remove(category);

            RenderListOfCategories();
        }
    }
}
