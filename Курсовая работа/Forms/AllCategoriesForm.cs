using System.Data;
using CoursePaper.Models;

namespace CoursePaper.Forms
{
    public partial class AllCategoriesForm : Form, IContainingListBox
    {
        private readonly User user;

        internal AllCategoriesForm(User user)
        {
            InitializeComponent();

            this.user = user;

            RenderListBox();
        }

        public void RenderListBox()
        {
            lstIncomeCategories.Items.Clear();
            foreach (var item in user.IncomesCategories)
                lstIncomeCategories.Items.Add(item);

            lstExpenseCategories.Items.Clear();
            foreach (var item in user.ExpenseCategories)
                lstExpenseCategories.Items.Add(item);
        }

        private void pbAddExpenseCategory_Click(object sender, EventArgs e)
        {
            if (txtNewTitleExpenseCategory.Visible || txtNewTitleIncomeCategory.Visible)
            {
                MessageBox.Show("Сначала закончите редактирование категории!");
                return;
            }

            AddingCategoryForm addingCategory = new(user, TypeOfCategory.Expenditure, this);
            addingCategory.Show();
        }

        private void pbDeleteExpenseCategory_Click(object sender, EventArgs e)
        {
            if (txtNewTitleExpenseCategory.Visible || txtNewTitleIncomeCategory.Visible)
            {
                MessageBox.Show("Сначала закончите редактирование категории!");
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

            DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить категорию\"{category.Title}\"?\n" +
                $"Расходы по этой категории перейдут в категорию \"Другое\"",
                "Удаление", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                ExpenseCategory otherCategory = user.ExpenseCategories.FirstOrDefault(x => x.Title == "Другое");
                user.Expenses.Where(x => x.Category == category).ToList().ForEach(x => x.Category = otherCategory);
                user.ExpenseCategories.Remove(category);
            }

            RenderListBox();
        }

        private void pbAddIncomeCategory_Click(object sender, EventArgs e)
        {
            if (txtNewTitleExpenseCategory.Visible || txtNewTitleIncomeCategory.Visible)
            {
                MessageBox.Show("Сначала закончите редактирование категории!");
                return;
            }

            AddingCategoryForm addingCategory = new(user, TypeOfCategory.Income, this);
            addingCategory.Show();
        }

        private void pbDeleteIncomeCategory_Click(object sender, EventArgs e)
        {
            if (txtNewTitleExpenseCategory.Visible || txtNewTitleIncomeCategory.Visible)
            {
                MessageBox.Show("Сначала закончите редактирование категории!");
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

            DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить категорию\"{category.Title}\"?\n" +
                $"Доходы по этой категории перейдут в категорию \"Другое\"",
                "Удаление", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                IncomeCategory otherCategory = user.IncomesCategories.FirstOrDefault(x => x.Title == "Другое");
                user.Incomes.Where(x => x.Category == category).ToList().ForEach(x => x.Category = otherCategory);
                user.IncomesCategories.Remove(category);
            }

            RenderListBox();
        }

        private void pbEditExpenseCategory_Click(object sender, EventArgs e)
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

            if (!txtNewTitleExpenseCategory.Visible)
            {
                txtNewTitleExpenseCategory.Text = categoryInString;
                txtNewTitleExpenseCategory.Focus();
            }
            else
            {
                string title = txtNewTitleExpenseCategory.Text;
                if (string.IsNullOrWhiteSpace(title))
                {
                    MessageBox.Show("Новое название не может быть пустым!");
                    txtNewTitleExpenseCategory.Text = string.Empty;
                    txtNewTitleExpenseCategory.Visible = !txtNewTitleExpenseCategory.Visible;
                    lblNewTitleExpenseCategory.Visible = !lblNewTitleExpenseCategory.Visible;
                    return;
                }

                var currentCategory = user.ExpenseCategories.FirstOrDefault(x => x.Title == title);
                if (currentCategory != null)
                {
                    MessageBox.Show("Такая категория уже есть!");
                    txtNewTitleExpenseCategory.Text = string.Empty;
                    txtNewTitleExpenseCategory.Visible = !txtNewTitleExpenseCategory.Visible;
                    lblNewTitleExpenseCategory.Visible = !lblNewTitleExpenseCategory.Visible;
                    return;
                }
                else
                {
                    category.Title = title;
                    txtNewTitleExpenseCategory.Text = string.Empty;
                    RenderListBox();
                }
            }

            txtNewTitleExpenseCategory.Visible = !txtNewTitleExpenseCategory.Visible;
            lblNewTitleExpenseCategory.Visible = !lblNewTitleExpenseCategory.Visible;
        }

        private void pbEditIncomeCategory_Click(object sender, EventArgs e)
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

            if (!txtNewTitleIncomeCategory.Visible)
            {
                txtNewTitleIncomeCategory.Text = categoryInString;
                txtNewTitleIncomeCategory.Focus();
            }
            else
            {
                string title = txtNewTitleIncomeCategory.Text;
                if (string.IsNullOrWhiteSpace(title))
                {
                    MessageBox.Show("Новое название не может быть пустым!");
                    txtNewTitleIncomeCategory.Text = string.Empty;
                    txtNewTitleExpenseCategory.Visible = !txtNewTitleIncomeCategory.Visible;
                    lblNewTitleIncomeCategory.Visible = !lblNewTitleIncomeCategory.Visible;
                    return;
                }

                var currentCategory = user.IncomesCategories.FirstOrDefault(x => x.Title == title);
                if (currentCategory != null)
                {
                    MessageBox.Show("Такая категория уже есть!");
                    txtNewTitleIncomeCategory.Text = string.Empty;
                    txtNewTitleIncomeCategory.Visible = !txtNewTitleIncomeCategory.Visible;
                    lblNewTitleIncomeCategory.Visible = !lblNewTitleIncomeCategory.Visible;
                    return;
                }
                else
                {
                    category.Title = title;
                    txtNewTitleIncomeCategory.Text = string.Empty;
                    RenderListBox();
                }
            }

            txtNewTitleIncomeCategory.Visible = !txtNewTitleIncomeCategory.Visible;
            lblNewTitleIncomeCategory.Visible = !lblNewTitleIncomeCategory.Visible;
        }

        private void lstExpenseCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstExpenseCategories.SelectedItem?.ToString() == "Другое")
            {
                pbDeleteExpenseCategory.Visible = false;
                pbEditExpenseCategory.Visible = false;
            }
            else
            {
                pbDeleteExpenseCategory.Visible = true;
                pbEditExpenseCategory.Visible = true;
            }
        }

        private void lstIncomeCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIncomeCategories.SelectedItem?.ToString() == "Другое")
            {
                pbDeleteIncomeCategory.Visible = false;
                pbEditIncomeCategory.Visible = false;
            }
            else
            {
                pbDeleteIncomeCategory.Visible = true;
                pbEditIncomeCategory.Visible = true;
            }
        }
    }
}
