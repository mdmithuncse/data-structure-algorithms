// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, this is prime number example");
Console.WriteLine("Please enter a number:");
int inputNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The number {inputNumber} is {IsPrimeNumber(inputNumber)} prime number");

string IsPrimeNumber(int n)
{
    int i = 2;

    while(i<= (n / 2))
    {
        if (n % i == 0)
        {
            return "not a";
        }

        i++;
    }

    return "a";
}