ShoppingList list = new ShoppingList("items.txt");  
list.Load();

while (true)
{
    Console.WriteLine();
    list.Print();
    Console.WriteLine();
    Console.WriteLine("1. Lägg till vara");
    Console.WriteLine("2. Ta bort vara");
    Console.WriteLine("3. Spara");
    Console.WriteLine("4. Sök vara");
    Console.WriteLine("5. Avsluta");
    Console.Write("Välj: ");

    
    string inputChoice = Console.ReadLine().Trim();     //This code take a string
    if (!int.TryParse(inputChoice,out int text))        //Giving a feedback just so it will know why its wrong
    {
        Console.WriteLine("Välja ett nummer från menyn.");
    }
    if (int.TryParse(inputChoice, out int choice))      //This code convert string into a number, if the code is false
                                                        //the program stay in the while-loop
        if (choice == 1)
        {
            try
            {
                Console.Write("Namn: ");
                string name = Console.ReadLine().Trim();     //This code helps to give the user more flexibility because it can take away 
                Console.Write("Pris: ");                     //spaces, so just the string keeps. Sadly null is still allow in this version
                string inputPrice = Console.ReadLine().Trim();
                if(int.TryParse(inputPrice, out int price))  //Convert into a number and if its not a number the product is not added
                {
                    list.Add(new Item(name, price));
                }
                else
                {
                    Console.WriteLine("Priset måste vara ett nummer");
                }
            }
            catch (ArgumentException ex)                //Fångar ArgumentExeptions och skriver till användare
            {
                Console.WriteLine($"Fel: {ex.Message}");
            }
            catch (Exception)                           //Om felet läser inte från första catch så visas denna istället
            {
                Console.WriteLine("Någonting gick fel vid inmatning av produkten och priset. Produkten ska inte läggas till.");
            }
        }
        else if (choice == 2)
        {
            Console.Write("Nummer: ");
            string inputTaBort = Console.ReadLine().Trim(); 
            if(int.TryParse(inputTaBort, out int number))   //Convert into a number and if its not a number, go back to the while-loop
            {
                list.RemoveAt(number);
            }

        }
        else if (choice == 3)
        {
            list.Save();
        }
        else if (choice == 4)
        {
            Console.Write("Namn att söka efter: ");
            string wanted = Console.ReadLine().Trim();    //keeping input neutral and protect from spaces for comparation in the method
            Item found = list.Find(wanted);

            if (found == null)
            {
                Console.WriteLine("Varan finns inte i listan.");
            }
            else
            {
                Console.WriteLine($"Hittade: {found}");
            }
        }
        else if (choice == 5)
        {
            break;
        }
        else
        {
            Console.WriteLine("Välja ett nummer från menyn.");
        }
}
