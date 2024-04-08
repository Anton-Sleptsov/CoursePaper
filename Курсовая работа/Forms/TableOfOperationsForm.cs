using System.Data;
using CoursePaper.Models;

namespace CoursePaper.Forms
{
    public partial class TableOfOperationsForm : Form
    {
        private User user;

        internal TableOfOperationsForm(User user)
        {
            InitializeComponent();

            this.user = user;
        }

        private void TableOfOperationsForm_Load(object sender, EventArgs e)
        {
            DataTable table = new();
            table.Columns.Add("Дата", typeof(DateTime));
            table.Columns.Add("Категория", typeof(string));
            table.Columns.Add("Сумма", typeof(decimal));
            table.Columns.Add("Описание", typeof(string));

            List<Operation> allOperations = [.. user.Incomes, .. user.Expenses];

            var orderedList = allOperations.OrderByDescending(op => op.Date).ToList();

            foreach (var item in orderedList)
            {
                if(item.GetType() == typeof(Expenditure))
                    table.Rows.Add(item.Date, item.Category.ToString(), -item.Amount, item.Description);
                else
                    table.Rows.Add(item.Date, item.Category.ToString(), item.Amount, item.Description);
            }
            
            dataGridView1.DataSource = table;
        }
    }
}
