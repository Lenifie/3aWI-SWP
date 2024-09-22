// See https://aka.ms/new-console-template for more information
Console.WriteLine("Aufgabe 1");

string input = string.Empty;
while (true)
{
    input = Console.ReadLine();

    if(input == "Beenden")
    {
        break;
    }
    Console.WriteLine(input);
}