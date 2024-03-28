namespace Курсовая_работа.Models
{
    internal class IncomeCategory(string title) : Category
    {
        public string Title { get; set; } = title;

        public override string ToString()
        {
            return Title;
        }
    }
}
