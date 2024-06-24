namespace Task.Models;

public record Category
{
    public List<Product> Products { get; set; }
    public string Name { get; set; }

    Category() { }

    public Category(string name, List<Product> products) { Products = products; Name = name; }

    public override string ToString()
    {
        return $"Name: {Name}";
    }
}
