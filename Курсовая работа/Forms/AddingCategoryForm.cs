﻿using CoursePaper.Models;

namespace CoursePaper.Forms
{
    public partial class AddingCategoryForm : Form
    {
        private readonly User user;
        private readonly TypeOfCategory typeOfCategory;
        private readonly IContainingListBox form;
        internal AddingCategoryForm(User user, TypeOfCategory typeOfCategory, IContainingListBox form)
        {
            InitializeComponent();
            this.user = user;
            this.typeOfCategory = typeOfCategory;
            this.form = form;
        }

        private void btnAddingCategory_Click(object sender, EventArgs e)
        {
            string title = txtTitleOfCategory.Text;
            if(string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Введите название категории!");
                txtTitleOfCategory.Text = string.Empty;
                return;
            }

            if(typeOfCategory == TypeOfCategory.Income)
            {
                var currentCategory = user.IncomesCategories.FirstOrDefault(x => x.Title == title);

                if(currentCategory != null)
                {
                    MessageBox.Show("Такая категория уже есть!");
                    txtTitleOfCategory.Text = string.Empty;
                    return;
                }
                else
                {
                    user.IncomesCategories.Add(new(title));
                    txtTitleOfCategory.Text = string.Empty;
                    Close();
                    form.RenderListBox();
                }
            }
            else if (typeOfCategory == TypeOfCategory.Expenditure)
            {
                var currentCategory = user.ExpenseCategories.FirstOrDefault(x => x.Title == title);

                if (currentCategory != null)
                {
                    MessageBox.Show("Такая категория уже есть!");
                    txtTitleOfCategory.Text = string.Empty;
                    return;
                }
                else
                {
                    user.ExpenseCategories.Add(new(title));
                    txtTitleOfCategory.Text = string.Empty;
                    Close();
                    form.RenderListBox();
                }
            }

        }
    }
}
