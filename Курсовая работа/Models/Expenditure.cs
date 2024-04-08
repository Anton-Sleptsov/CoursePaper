namespace CoursePaper.Models
{
    internal class Expenditure : Operation
    {
        public Expenditure(DateTime date, decimal amount, Category category,string description) : base(date, amount, category, description) { }
    }
}
