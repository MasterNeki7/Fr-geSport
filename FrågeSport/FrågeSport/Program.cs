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
    Console.WriteLine($"Din poäng nu är {poäng}");
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
    Console.WriteLine($"Din poäng är {poäng}.");
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
    Console.WriteLine($"Du har nu {poäng} poäng!");
}

else
{
    poäng -= 1;
    Console.WriteLine("Du hade fel! Jag måste tyvärr ta bort ett poäng.");
    Console.WriteLine($"Du har {poäng} poäng");
}

















Console.ReadLine();
