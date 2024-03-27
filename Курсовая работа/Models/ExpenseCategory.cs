namespace Курсовая_работа.Models
{
    internal class ExpenseCategory(string title)
    {
        public string Title { get; set; } = title;

        public override string ToString()
        {
            return Title;
        }
    }
}
