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
2. Andra felet: I Print methoden, for-loopen började med i=1 istället än i=0. Ändrade och första produkten földe med. (rad 52)
3. Commit hash: 03f2cb88259574590945ca351ad21547ffbd8906

### Program krashar i meny val
1. Starta program
2. Fel meddelande: The input string 'sdfsdf' was not in a correct format.
3. Notera: Det händer efter felinmatning forutom 1,2,3,4 och 5.

#### Åtgärd
1. Ändrade input till string och därefter i en if-sats - konvertera till int med variabel choice, if choice innehåller finns i meny, körs funktionen annars bara håller sig i while-loop. (rad 17 och 18)
2. Commit hash: 
