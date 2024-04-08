namespace CoursePaper.Models
{
    internal class ExpenseCategory(string title) : Category
    {
        public string Title { get; set; } = title;

        public override string ToString()
        {
            return Title;
        }
    }
}
