# Felrapport

### Program krasha direkt efter run
1. Starta program.
2. Fel meddelande: Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array. ShoppingList.cs:line 90 och Program.cs:line 2.
3. Notera: Detta händer vid varje program korning.

#### Åtgärd
1. Text filen hade en extra tomt space och programet kunde inte ladda det.