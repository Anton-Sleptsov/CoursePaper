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
    public partial class AddExpenditureForm : Form, IContainingListOfCategories
    {
        private readonly User user;

        internal AddExpenditureForm(User user)
        {
            InitializeComponent();
            this.user = user;

            RenderListOfCategories();
        }

        private void btnAddExpenseCategory_Click(object sender, EventArgs e)
        {
            AddingCategory addingCategory = new(user, TypeOfCategory.Expenditure, this);
            addingCategory.Show();
        }

        public void RenderListOfCategories()
        {
            lstExpenseCategories.Items.Clear();
            foreach (var item in user.ExpenseCategories)
                lstExpenseCategories.Items.Add(item);
        }
    }
}
