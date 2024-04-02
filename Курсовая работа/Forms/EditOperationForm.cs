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
    public partial class EditOperationForm : Form, IContainingListBox
    {
        private readonly User user;
        private readonly IContainingListBox form;
        private readonly MainForm mainForm;
        private readonly Operation operation;
        private readonly TypeOfCategory typeOfCategory;

        internal EditOperationForm(IContainingListBox form, MainForm mainForm, User user, Operation operation, TypeOfCategory typeOfCategory)
        {
            InitializeComponent();

            this.user = user;
            this.form = form;
            this.mainForm = mainForm;
            this.operation = operation;
            this.typeOfCategory = typeOfCategory;

            RenderListBox();
        }

        private void EditOperationForm_Load(object sender, EventArgs e)
        {
            txtAmount.Text = operation.Amount.ToString();
            date.Value = operation.Date;

            object selectedCategory = null;
            for (int i = 0; i < lstCategories.Items.Count; i++)
            {
                var item = lstCategories.Items[i];
                if(item.ToString() == operation.Category.ToString())
                    selectedCategory = item;
                
            }
            lstCategories.SelectedItem = selectedCategory;

            txtDescription.Text = operation.Description;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime dateOfOperation = date.Value;
            if (dateOfOperation > DateTime.Now)
            {
                MessageBox.Show("Дата дохода не может находиться в будущем!");
                date.Value = DateTime.Now;
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Введите сумму в верном формате!");
                txtAmount.Text = string.Empty;
                return;
            }
            else if (amount < 0)
            {
                MessageBox.Show("Сумма не может быть отрицательной!");
                txtAmount.Text = string.Empty;
                return;
            }

            if (lstCategories.SelectedItem == null)
            {
                MessageBox.Show("Выберите категорию!");
                return;
            }

            Category category = null;
            string categoryInString = lstCategories.SelectedItem.ToString();
            if(typeOfCategory == TypeOfCategory.Income)
                category = user.IncomesCategories.FirstOrDefault(x => x.Title == categoryInString);
            else if(typeOfCategory == TypeOfCategory.Expenditure)
                category = user.ExpenseCategories.FirstOrDefault(x => x.Title == categoryInString);

            if (category == null)
            {
                MessageBox.Show("Выберите категорию!");
                return;
            }

            string description = txtDescription.Text;

            operation.Amount = amount;
            operation.Date = dateOfOperation;
            operation.Category = category;
            operation.Description = description;
            Close();
            form.RenderListBox();
            mainForm.ShowBalance();
        }

        public void RenderListBox()
        {
            if(typeOfCategory == TypeOfCategory.Income)
            {
                lstCategories.Items.Clear();
                foreach (var item in user.IncomesCategories)
                    lstCategories.Items.Add(item);
            }
            else if(typeOfCategory == TypeOfCategory.Expenditure)
            {
                lstCategories.Items.Clear();
                foreach (var item in user.ExpenseCategories)
                    lstCategories.Items.Add(item);
            }
        }
    }
}
