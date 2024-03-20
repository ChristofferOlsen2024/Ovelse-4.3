// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vil du have ananas på din pizza?");

string svar = Console.ReadLine();

if (svar == "ja")
{
    Console.WriteLine("Det skal du få.");
} else if (svar == "nej")
{
    Console.WriteLine("Okay det får du ik så.");
}