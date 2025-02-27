int addNumbers (int a, int b)
{
    return a + b;
}
int subNumbers (int a, int b)
{
    return a - b;
}
int multNumbers (int a, int b)
{
    return a * b;
}
string calculator (int a, int b, string userChoice)
{
    if(userChoice == "a" || userChoice == "A")
    {
        return (a + " + " + b + " = " + addNumbers(a, b));
    }else if(userChoice == "s" || userChoice == "S")
    {
        return (a + " - " + b + " = " + addNumbers(a, b));
    }
    else if(userChoice == "m" || userChoice == "M")
    {
        return (a + " * " + b + " = " + addNumbers(a, b));
    }
    return "invalid choice!";
}

Console.WriteLine("Hello");

Console.WriteLine("Input the first number");
string userNumber1 = Console.ReadLine();
int a = int.Parse(userNumber1);

Console.WriteLine("Input the second number");
string userNumber2 = Console.ReadLine();
int b = int.Parse(userNumber2);

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");

string userChoice = Console.ReadLine();
Console.WriteLine(calculator(a, b, userChoice));

Console.WriteLine("Press any key to close!");
Console.ReadKey();