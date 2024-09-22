// See https://aka.ms/new-console-template for more information
Console.WriteLine("Aufgabe 1");

string input = string.Empty;
while (true)
{
    input = Console.ReadLine();

    if(input == "beenden")
    {
        break;
    }
    Console.WriteLine(input);
}


Console.WriteLine("Aufgabe 2");
string input2 = string.Empty;
int number = 0;

while (true)
{
    input2 = Console.ReadLine();

    if (input2 == "beenden")
    {
        break;
    }

    if(int.TryParse(input2 , out number)&& number >= 0){
        Console.WriteLine("Number is: " + number);
    }
    else
    {
        Console.WriteLine("Not a number");
    }
}