namespace Курсовая_работа.Models
{
    internal class IncomeCategory(string title)
    {
        public string Title { get; set; } = title;

        public override string ToString()
        {
            return Title;
        }
    }
}
