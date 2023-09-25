// See https://aka.ms/new-console-template for more information
using System;

int points = 0;

Console.WriteLine("hej");
Console.WriteLine("svara på mina tre frågor");
Console.WriteLine("vad är 20 + 6");
Console.WriteLine("a) 26  b) 14  c) 206 ");
string answer1 = Console.ReadLine();
if (answer1 == "a")
{
  points++;
  Console.WriteLine("rätt bra gjort");
}
else
{
  Console.WriteLine("hur fick du fel");
}


Console.WriteLine("nästa fråga");
Console.WriteLine("vilken färg har en apelsin");
Console.WriteLine("a) oranshe  b) orange  c) carrot färg ");
string answer2 = Console.ReadLine();
if (answer2 == "b")
{
  points++;
  Console.WriteLine("rätt");
}
else
{
  Console.WriteLine("nej. det är okej att ha fel om du är färgblind");
}

Console.WriteLine("sista frågan");
Console.WriteLine("vad går upp men aldrig kommer ner?");
Console.WriteLine("a) gas  b) vinden  c) åldern");
string answer3 = Console.ReadLine();
if (answer3 == "c")
{
  points++;
  Console.WriteLine("rätt");
}
else
{
  Console.WriteLine("fel");
}

// -----------------------------------------------------------------------------

Console.WriteLine($"efter tre svåra frågor så har du fått {points} poäng");
if (points == 0)
{
  Console.WriteLine("du är dumb som fan");
}
else if (points < 3)
{
  Console.WriteLine("jag vet inte vad jag ska säga");
}
else 
{
  Console.WriteLine("du fick alla rätt. du är ingen idiot.");
}

Console.WriteLine("tryck på vilken klapp som helst för att avsluta");
Console.ReadKey();