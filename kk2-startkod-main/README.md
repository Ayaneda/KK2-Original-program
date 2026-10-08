# Felrapport

### Program krasha direkt efter run
1. Starta program.
2. Fel meddelande: Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array. ShoppingList.cs:line 90 och Program.cs:line 2.
3. Notera: Detta händer vid varje program korning.

#### Åtgärd
1. Text filen hade en extra tomt space och programet kunde inte ladda det.(item.txt, rad 4)
2. Commit hash: 7580fd549b647f561e87cfdd1ad4761605029397

### Första produkt saknas i listan
1. Starta program
2. Listan bara visa priset från den andra produkt och läsa normalt vidare efter det.
3. Notera: varje efter program körning.

#### Åtgärd 
1. Första felet: I Load methoden vid inläsning. Byt till med avancerad inläsning där känner till \r\n och gör att det går att läsa hela filen. (rad 84)
2. Andra felet: I Print methoden, for-loopen började med i=1 istället än i=0. Ändrade och första produkten földe med. (ShoppingList.cs, rad 52)
3. Commit hash: 03f2cb88259574590945ca351ad21547ffbd8906

### Program krashar i meny val
1. Starta program
2. Fel meddelande: The input string 'sdfsdf' was not in a correct format.Program.cs:line 17
3. Notera: Det händer efter felinmatning forutom 1,2,3,4 och 5.

#### Åtgärd
1. Ändrade input till string och därefter i en if-sats - konvertera till int med variabel choice, if choice innehåller finns i meny, körs funktionen annars bara håller sig i while-loop. (Program.cs, rad 17 och 18)
2. Commit hash: 5776e74244f17fc144043e5c562fb85c3be1f039

### Program krasha i pris
1. Starta program
2. Välja lägga till produkt.
3. Skriva till en namn
4. Mata in annat än nummer.
5. Fel meddelande: Unhandled exception. System.FormatException: The input string 'gdfgsdgf' was not in a correct format. Program.cs:line 26


#### Åtgärd
1. Ändrade input till string och därefter i en if-sats - konvertera till int med variabel price, om det är inte en heltal. Avbrytt varan inlägg och gå tillbaka till menyn.  (Program.cs, rad 25-29)
2. Commit hash: a75cd259e51e85d0117faf9012957b9ed6d1c502

### Program krashar vid fel inmatning
1. Starta program
2. Välja ta bort produkt.
3. välja nummer till vara som inte finss och fel inmatning av icke heltal.
4. * Fel meddelande: The input string 'gwegwesg' was not in a correct format. Program.cs:line 37
   * Fel meddelande: Index was out of range. Must be non-negative and less than the size of the collection. (Parameter 'index'). ShoppingList.cs:line 20 och Program.cs:line 38.

#### Åtgärd
1. Första felet: Ändrade input till string och därefter i en if-sats - konvertera till int med variabel number, om det är inte en heltal. Avbrytt varan inlägg och gå tillbaka till menyn. (Program.cs, rad 37-41)
2. Andra felet: La till en if-sats som kontrollera att nummer finns inom index annars en feedback meddelande. (ShoppingList.cs, rad 20-27)
3. Commit hash: 
