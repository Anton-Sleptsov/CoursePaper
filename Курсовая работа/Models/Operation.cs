namespace CoursePaper.Models
{
    internal abstract class Operation
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }

        public Operation(DateTime date, decimal amount, Category category, string description)
        {
            Date = date;
            Amount = amount;
            Category = category;
            Description = description;
        }
    }
}
