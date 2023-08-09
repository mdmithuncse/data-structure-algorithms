// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, this is fibonacci series example");
Console.WriteLine("Please enter a number");
int inputNumber = Convert.ToInt32(Console.ReadLine());
FibonacciSeries(inputNumber);

void FibonacciSeries(int n)
{
    int firstNumber = 0;
    int secondNumber = 1;
    
    Console.WriteLine(firstNumber);
    Console.WriteLine(secondNumber);

    while(secondNumber <= n)
    {
        int temp = secondNumber;
        secondNumber = secondNumber + firstNumber;
        firstNumber= temp;

        Console.WriteLine(secondNumber);
    }
}
