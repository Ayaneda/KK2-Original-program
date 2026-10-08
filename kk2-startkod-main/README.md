# Laga programmet

## Instruktioner
Startkoden är en inköpslista som sparar varorna i en textfil mellan körningarna. Programmet
innehåller sex fel:
* Fyra får programmet att krascha.
* Ett ger fel resultat utan att krascha.
* Ett döljer att något gick fel.

Din uppgift är att hitta alla sex, rätta dem, och beskriva dem i din README.
### Så kommer du igång
* Starta programmet. Det kraschar direkt — läs hela felmeddelandet och anropsstacken, inte bara
första raden.
* Skriv bokstäver där programmet vill ha ett tal.
* Ta bort en vara som inte finns.
* Döp om items.txt och starta igen.
* Lägg till en vara, spara, avsluta och starta om. Ser listan likadan ut?
* Sök efter en vara som du ser i listan.
* Räkna efter totalsumman för hand.
* Läs koden. Alla sex felen visar sig inte när du kör programmet.
### Krav för godkänt (del 1)

1. [ ] Programmet kraschar inte, oavsett vad användaren skriver i menyn, i priset eller i numret.
2. [ ] Programmet startar även om items.txt saknas.
3. [ ] Det som sparas går att läsa tillbaka — listan ser likadan ut efter en omstart.
4. [ ] En vara som syns i listan hittas också när man söker på dess namn.
5. [ ] Totalsumman stämmer.
6. [ ] Ingen catch är tom, och programmet påstår inte att något lyckades när det misslyckades.
7. [ ] TryParse används för inmatning som förväntas kunna bli fel.
8. [ ] De catch som finns fångar specifika undantagstyper, inte bara Exception