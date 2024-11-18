PrintWelcomeMessage();

int firstNumber = int.Parse(GetUserInputFromConsole("Input the first number: "));
int secondNumber = int.Parse(GetUserInputFromConsole("Input the second number: "));

PrintMenu();
string option = GetUserInputFromConsole("=> ");

if (option.Equals("a", StringComparison.CurrentCultureIgnoreCase))
{
    Console.WriteLine(Add(firstNumber, secondNumber));
}
else if (option.ToLower() == "s")
{
    Console.WriteLine(Subtract(firstNumber, secondNumber));
}
else if (option.ToLower() == "m")
{
    Console.WriteLine(Multiply(firstNumber, secondNumber));
}
else
{
    Console.WriteLine("Invalid choice!");
}

Console.WriteLine("Press any key to close.");
Console.ReadLine();

long Multiply(int firstNumber, int secondNumber)
{
    return firstNumber * secondNumber;
}

long Subtract(int firstNumber, int secondNumber)
{
    return firstNumber - secondNumber;
}

long Add(int firstNumber, int secondNumber)
{
    return firstNumber + secondNumber;
}

void PrintMenu()
{
    Console.WriteLine("What do you want to do with those numbers?");
    Console.WriteLine("[A]dd");
    Console.WriteLine("[S]ubtract");
    Console.WriteLine("[M]ultiply");

}

string GetUserInputFromConsole(string inputMessage)
{
    Console.Write(inputMessage);
    string? userInput = Console.ReadLine();
    return userInput;
}

void PrintWelcomeMessage()
{
    Console.WriteLine("Hello!");
}
