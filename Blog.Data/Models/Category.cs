using Blog.Data.Interfaces;

namespace Blog.Data.Models
{
    public class Category : IBlogItem
    {
        public int Id { get; set; }
        public string name { get; set; }
        public ICollection<BlogPost> BlogPosts { get; set; }
    }
}