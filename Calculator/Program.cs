PrintWelcomeMessage();

int firstNumber = int.Parse(GetUserInput("Input the first number: "));
int secondNumber = int.Parse(GetUserInput("Input the second number: "));

PrintMenu();

string choice = GetUserInput("=> ");
long result = 0;

if (IsChoiceEqualToOption(choice, "a"))
{
    result = Add(firstNumber, secondNumber);
    Console.WriteLine(result);
}
else if (IsChoiceEqualToOption(choice, "s"))
{
    result = Subtract(firstNumber, secondNumber);
    Console.WriteLine(result);
}
else if (IsChoiceEqualToOption(choice, "m"))
{
    result = Multiply(firstNumber, secondNumber);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Invalid choice!");
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();

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

string GetUserInput(string inputMessage)
{
    Console.Write(inputMessage);
    string? userInput = Console.ReadLine();
    return userInput ?? string.Empty;
}

void PrintWelcomeMessage()
{
    Console.WriteLine("Hello!");
}

bool IsChoiceEqualToOption(string choice, string option) =>
    choice.Equals(option, StringComparison.CurrentCultureIgnoreCase);
