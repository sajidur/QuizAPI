namespace QuizAPI.Models
{
    public class Post
    {
        public int PostId { get; internal set; }
        public int CategoryId { get; internal set; }
        public string Description { get; internal set; }
        public string Title { get; internal set; }
        public Category Category { get; internal set; }
    }
}