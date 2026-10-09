// Holds the items and takes care of loading and saving them.
class ShoppingList
{
    private List<Item> items = new List<Item>();
    private string path;
    private int _budgettak = 1000;

    public ShoppingList(string path)
    {
        this.path = path;
    }

    public void Add(Item item)
    {
        if(item.Price + Total() > _budgettak)
        {
            throw new ArgumentException("Produkten överskrider budgettaket. Produkten ska inte läggas till.");
        }
        items.Add(item);
    }

    // Removes the item the user sees as number 1, 2, 3 ...
    public void RemoveAt(int number)
    {
        if (number >= 1 && number <= items.Count)   //It controls to remove only when there is a product with the given number
        {
            items.RemoveAt(number - 1);
        }
        else
        {
            Console.WriteLine("Varan finns inte i listan.");
        }
    }

    // Adds up the price of every item on the list.
    public int Total()
    {
        int sum = 0;

        for (int i = 0; i < items.Count; i++)     //Index start always with 0, because it was 1 before always skip first product.
        {
            sum += items[i].Price;
        }

        return sum;
    }

    // Looks up an item by its name. Returns null if there is no such item.
    public Item Find(string name)
    {
        foreach (Item item in items)
        {
            if (item.Name.ToLower() == name.ToLower()) //Keep the input neutral in the comparation.
            {
                return item;
            }
        }

        return null;
    }

    public void Print()
    {
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i]}");
        }
        int kvarAttKöppa = _budgettak - Total();
        Console.WriteLine($"Totalt: {Total()} kr");
        Console.WriteLine($"Budgettak: {_budgettak} kr");
        Console.WriteLine($"Kvar att handla för: {kvarAttKöppa} kr");
    }

    // Writes one item per line, as "price;name".
    public void Save()
    {
        List<string> lines = new List<string>();

        foreach (Item item in items)
        {
            lines.Add($"{item.Price};{item.Name}");
        }

        try                                              //This keep the program running even if it can not save into a file
        {
            File.WriteAllText(path, string.Join("\r\n", lines) + "\r\n");   //Powerful code, overwrite if there is a file, else 
                                                                            //create a file with the name given from the path variable
            Console.WriteLine("Listan är sparad.");
        }
        catch(FormatException)                          //If the format is not accepted, give feedback
        {
            Console.WriteLine("Det gick något fel med formatering");
        }
        catch(Exception ex)                             //If nothing works, give an error message
        {
            Console.WriteLine($"Ett fel har hänt: {ex.Message}");
        }
        
    }

    // Reads the file back into the list.
    public void Load()
    {
        try                                                //Using try-catch I make sure that the program keep going even when the 
                                                           //the program can not read or find the file
        {
            string[] lines = File.ReadAllLines(path);     //this code read all lines and accept /n and /r formats too.
            

            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                items.Add(new Item(parts[1], int.Parse(parts[0])));
            }
        }
        catch(FileNotFoundException)                        //If the file is not found or exist - feedback to the user
        {
            Console.WriteLine("Ups, nånting gick fel.");
            Console.WriteLine("Filen kunde inte läsas eller inte finns.");
        }
        catch (Exception ex)                                //Send a feedback with an error message
        {
            Console.WriteLine($"Ett fel har hänt: {ex.Message}");
        }
    }
}
