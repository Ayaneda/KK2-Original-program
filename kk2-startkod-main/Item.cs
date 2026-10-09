// One item on the shopping list.
using System.Diagnostics.CodeAnalysis;

class Item
{
    public string Name { get; set; }
    public int Price { get; set; }

    public Item(string name, int price)
    {
        
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Produktens namn måste skrivas, kan inte vara tömt. Produkten ska inte läggas till.");
        }
        Name = name;
        
        if (price <= 0)
        {
            throw new ArgumentOutOfRangeException("Produktens pris kan inte vara negativ eller noll. Allt kosta i detta livet. Produkten ska inte läggas till.");
        }
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name} - {Price} kr";
    }
}
