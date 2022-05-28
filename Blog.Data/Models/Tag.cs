using Blog.Data.Interfaces;

namespace Blog.Data.Models
{
    public class Tag : IBlogItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<BlogPost> BlogPosts { get; set; }
    }
}