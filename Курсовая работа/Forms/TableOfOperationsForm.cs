using System.Data;
using CoursePaper.Models;

namespace CoursePaper.Forms
{
    public partial class TableOfOperationsForm : Form
    {
        private User user;
        private const string allCategoriesTitle = "Все категории";
        private string selectedCategoryInString = allCategoriesTitle;

        internal TableOfOperationsForm(User user)
        {
            InitializeComponent();

            this.user = user;
        }

        private void TableOfOperationsForm_Load(object sender = null, EventArgs e = null)
        {
            decimal totalAmount = 0;

            DataTable table = new();
            table.Columns.Add("Дата", typeof(DateTime));
            table.Columns.Add("Категория", typeof(string));
            table.Columns.Add("Сумма", typeof(decimal));
            table.Columns.Add("Описание", typeof(string));

            List<Operation> allOperations = GetAllRenderingOperations();
            List<Operation> allOperationsInCategory;
            if (selectedCategoryInString == allCategoriesTitle)
                allOperationsInCategory = allOperations;
            else
                allOperationsInCategory = allOperations.Where(op => op.Category.Title == selectedCategoryInString).ToList();

            foreach (var item in allOperationsInCategory)
            {
                if (item.GetType() == typeof(Expenditure))
                    totalAmount -= item.Amount;
                else
                    totalAmount += item.Amount;
            }

            var orderedList = allOperationsInCategory.OrderByDescending(op => op.Date).ToList();

            foreach (var item in orderedList)
            {
                if (item.GetType() == typeof(Expenditure))
                    table.Rows.Add(item.Date.ToShortDateString(), item.Category.ToString(), -item.Amount, item.Description);
                else
                    table.Rows.Add(item.Date.ToShortDateString(), item.Category.ToString(), item.Amount, item.Description);
            }

            dataGridView1.DataSource = table;

            lblTotalAmount.Text = totalAmount.ToString();

            if (totalAmount < 0)
                lblTotalAmount.ForeColor = Color.Red;
            else
                lblTotalAmount.ForeColor = Color.Black;

        }

        private void radioExpenses_CheckedChanged(object sender, EventArgs e)
        {
            gbCategories.Text = "Категории расходов";
            gbCategories.Visible = true;

            cbCategories.SelectedItem = allCategoriesTitle;

            cbCategories.Items.Clear();
            cbCategories.Items.Add(allCategoriesTitle);
            foreach (var item in user.ExpenseCategories)
                cbCategories.Items.Add(item);

            TableOfOperationsForm_Load();
        }

        private void radioIncomes_CheckedChanged(object sender, EventArgs e)
        {
            gbCategories.Text = "Категории доходов";
            gbCategories.Visible = true;

            cbCategories.SelectedItem = allCategoriesTitle;

            cbCategories.Items.Clear();
            cbCategories.Items.Add(allCategoriesTitle);
            foreach (var item in user.IncomesCategories)
                cbCategories.Items.Add(item);

            TableOfOperationsForm_Load();
        }

        private void radioAllOperations_CheckedChanged(object sender, EventArgs e)
        {
            cbCategories.SelectedItem = allCategoriesTitle;
            gbCategories.Visible = false;

            TableOfOperationsForm_Load();
        }
        private List<Operation> GetAllRenderingOperations()
        {
            List<Operation> allOperations = new();
            if (radioExpenses.Checked)
                allOperations = [.. user.Expenses];
            else if (radioIncomes.Checked)
                allOperations = [.. user.Incomes];
            else
                allOperations = [.. user.Incomes, .. user.Expenses];

            List<Operation> allOperationsWithTime = new();
            if (radioThisMonth.Checked)
                allOperationsWithTime = allOperations.Where(op => op.Date.Month == DateTime.Now.Month).ToList();
            else if (radioThisYear.Checked)
                allOperationsWithTime = allOperations.Where(op => op.Date.Year == DateTime.Now.Year).ToList();
            else
                allOperationsWithTime = allOperations;

            return allOperationsWithTime;
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCategoryInString = cbCategories.SelectedItem.ToString();
            TableOfOperationsForm_Load();
        }

        private void radioAllTime_CheckedChanged(object sender, EventArgs e) => TableOfOperationsForm_Load();

        private void radioThisMonth_CheckedChanged(object sender, EventArgs e) => TableOfOperationsForm_Load();

        private void radioThisYear_CheckedChanged(object sender, EventArgs e) => TableOfOperationsForm_Load();
    }
}
