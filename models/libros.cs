namespace LABORATORY.models.Enums;
public class Book
{
    public Book(string titles, string Author, string Description,decimal Price, string Category)
    {
        titles = title();
        Author = author;
        Description = description;
        Price = price;
        Category = category;
    }
   
    public title titles{ get; set; }
    public string  author{ get; set; }
    public string description { get; set; }
    public decimal  price { get; set; }
    public int inventory{ get; set; }
    public string category{ get; set; }
    
}