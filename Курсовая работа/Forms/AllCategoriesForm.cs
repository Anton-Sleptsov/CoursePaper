﻿using System;
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

            DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить категорию\"{category.Title}\"?",
                "Удаление", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                user.ExpenseCategories.Remove(category);

            RenderListOfCategories();
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

            DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить категорию\"{category.Title}\"?",
                "Удаление", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                user.IncomesCategories.Remove(category);

            RenderListOfCategories();
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
                    RenderListOfCategories();
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
                    RenderListOfCategories();
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
