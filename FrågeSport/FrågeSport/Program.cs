int poäng = 0;

string answer;

Console.WriteLine("Phasmophobia Quiz");
Console.WriteLine("Svara genom att skriva a, b, c eller d.");

Console.WriteLine("Fråga 1: Vilket spöke har den snabbaste *bas* hastigheten i spelet?");
Console.WriteLine("  a) Deogen  b) Spirit  c) Hantu  d) Revenant ");

answer = Console.ReadLine();
if (answer == "a")
{
    poäng += 1;
    Console.WriteLine("Bra jobbat! Du får en poäng.");
    Console.WriteLine($"Du har {poäng} poäng.");
}

else
{
    poäng -= 1;
    Console.WriteLine("Du hade fel! Minus poäng för dig!.");
    Console.WriteLine($"Du har {poäng} poäng.");
}

Console.WriteLine("Fråga 2: Vilket är det snabbaste spöket i spelet?");
Console.WriteLine("  a) Revenant  b) Deogen  c) Moroi  d) Thaye");

answer = Console.ReadLine();
if (answer == "c")
{
    poäng += 1;
    Console.WriteLine("Grattis du hade rätt!");
    Console.WriteLine($"Du har {poäng} poäng.");
}

else
{
    poäng -= 1;
    Console.WriteLine("Du hade fel! L.");
    Console.WriteLine($"Du har {poäng} poäng.");
}

Console.WriteLine("Fråga 3: Vilket spöken blir snabbare när den har Line of Sight? (enbart Line of Sight) ");
Console.WriteLine("  a) Jinn  b) Revenant  c) Myling  d) The Mimic");

answer = Console.ReadLine();
if (answer == "b")
{
    poäng += 1;
    Console.WriteLine("Bra jobbat! Du har rätt.");
    Console.WriteLine($"Du har {poäng} poäng.");
}

else
{
    poäng -= 1;
    Console.WriteLine("Du hade fel! Jag måste tyvärr ta bort ett poäng.");
    Console.WriteLine($"Du har {poäng} poäng.");
}

Console.WriteLine("Fråga 4: Vilket spöke vet alltid vart du är (du kan inte gömma dig)");
Console.WriteLine("  a) Spirit  b) Poltergeist  c) Deogen  d) Huntress  ");

answer = Console.ReadLine();

if (answer == "c")
{
    poäng += 1;
    Console.WriteLine("Bra du hade rätt!");
    Console.WriteLine($"Du har {poäng} poäng.");
}
else
{
    poäng -= 1;
    Console.WriteLine("Du hade fel! Minus poäng för dig!");
    Console.WriteLine($"Du har {poäng} poäng.");
}

Console.WriteLine("Fråga 5: Vilket spöke har bara en svaghet och ingen styrka?");
Console.WriteLine("  a) Poltergeist  b) Onryo  c) Wraith  d) Spirit");

answer = Console.ReadLine();
if (answer == "d")
{
    poäng += 1;
    Console.WriteLine("Du hade rätt! bra jobbat.");
    Console.WriteLine($"Du har {poäng} poäng.");
}
else
{
    poäng -= 1;
    Console.WriteLine("Du hade fel! sämst.");
    Console.WriteLine($"Du har {poäng} poäng.");
}

Console.WriteLine("Fråga 6: Vilken är den största mappen i phasmophobia?");
Console.WriteLine("  a) Tanglewood  b) Grafton Farmhouse  c) Asylum  d) Maple Lodge Campsite");

answer = Console.ReadLine();
if (answer == "c")
{
    poäng += 1;
    Console.WriteLine("Du hade rätt! tjoohoo!");
    Console.WriteLine($"Du har {poäng} poäng.");
}
else
{
    poäng -= 1;
    Console.WriteLine("Du hade fel! nooooob");
    Console.WriteLine($"Du har {poäng} poäng.");
}






Console.ReadLine();
