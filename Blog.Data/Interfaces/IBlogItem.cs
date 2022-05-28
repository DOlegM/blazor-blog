namespace Blog.Data.Interfaces;

// By having a common interface with the Id property,
// we can write generic functions for handling the saving
// of objects.
interface IBlogItem
{
    public int Id { get; set; }
}