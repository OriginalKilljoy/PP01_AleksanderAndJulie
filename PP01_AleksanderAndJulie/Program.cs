/* OPPGAVE 1
   Lag et program hvor du kan skrive inn en tekst, og når du sender teksten inn vil du få tilbake teksten reversert. Gjør dette uten å bruke innebygde reverse metoder
   Bygg videre ved å legge til flere ting man kan gjøre med stringen, eksempel:
   Alternativer for hva man vil gjøre, trykk 1,2 eller 3 for å reversere, konvertere til uppercase eller lowercase..
 */

Console.WriteLine("Hei! Skriv inn en tekst du ønsker å få reversert:)");

var input = Console.ReadLine();
string reversedInput = "";

foreach (var letter in input)
{
    reversedInput = letter + reversedInput;
}

Console.WriteLine($"Du skrev: {input}");
Console.WriteLine($"Reversert blir det: {reversedInput}");