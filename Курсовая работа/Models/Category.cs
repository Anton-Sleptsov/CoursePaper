namespace CoursePaper.Models
{
    internal class Category
    {
        public string Title { get; set; }

        public Category(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
