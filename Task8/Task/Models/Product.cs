namespace Task.Models;

public record Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }

    public Product() {}

    public Product(string name, double price, string description) { Name = name; Price = price; Description = description; }

    public override string ToString()
    {
        return $"{Name}: {Description}: {Price}";
    }
}
