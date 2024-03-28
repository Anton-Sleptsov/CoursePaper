using System.Data;
using Курсовая_работа.Models;

namespace Курсовая_работа.Forms
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

            List<Operation> allOperations = [.. user.Incomes];

            foreach (var expenditure in user.Expenses)
            {
                if(expenditure.Amount >= 0)
                    expenditure.Amount = -expenditure.Amount;

                allOperations.Add(expenditure);
            }

            var orderedList = allOperations.OrderByDescending(op => op.Date).ToList();

            for (int i = 0; i < orderedList.Count; i++)
                table.Rows.Add(orderedList[i].Date, orderedList[i].Category.ToString(), orderedList[i].Amount);

            dataGridView1.DataSource = table;
        }
    }
}
