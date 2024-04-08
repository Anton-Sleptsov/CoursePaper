namespace CoursePaper.Models
{
    internal class Income : Operation
    {
        public Income(DateTime date, decimal amount, Category category, string description) : base(date, amount, category, description) { }      
    }
}
