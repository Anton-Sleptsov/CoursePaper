using Курсовая_работа.Forms;
using Курсовая_работа.Models;

namespace Курсовая_работа
{
    public partial class Form1 : Form
    {
        User user = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenAddExpenditureForm_Click(object sender, EventArgs e)
        {
            AddExpenditureForm addExpenditureForm = new AddExpenditureForm(user);
            addExpenditureForm.Show();
        }
    }
}
