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
    }
}
