// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, this is factorial example");
Console.WriteLine("Please input a number:");
int inputNumber = int.Parse(Console.ReadLine());
Console.WriteLine($"The factorial of {inputNumber} is {Factorial(inputNumber)}");

int Factorial(int n)
{
    int i = 1;
    int factorial = 1;

    while (i <= n)
    {
        factorial *= i;
        i++;
    }

    return factorial;
}