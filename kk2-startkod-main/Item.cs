// One item on the shopping list.
using System.Diagnostics.CodeAnalysis;

class Item
{
    public string Name { get; set; }
    public int Price { get; set; }

    public Item(string name, int price)
    {
        
        if (string.IsNullOrWhiteSpace(name))       //Kontrollera att name är null eller mellanslag. Tänkte om att vara ska matas bokstäver men visa produkter
        {                                          //kan ha ett nummer i sitt nanm så.. lämna till användare om vill se bara nummer eller bokstäver med nummer. 
            throw new ArgumentException("Produktens namn måste skrivas, kan inte vara tömt. Produkten ska inte läggas till.");   //Feedback om felet 
        }
        Name = name;
        
        if (price <= 0)                             //Kontrollera att pris ska vara mer en 0. Inmatning är redan skyddad från Program.cs
        {
            throw new ArgumentOutOfRangeException("Produktens pris kan inte vara negativ eller noll. Allt kosta i detta livet. Produkten ska inte läggas till.");  //Feedback om felet
        }
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name} - {Price} kr";
    }
}
