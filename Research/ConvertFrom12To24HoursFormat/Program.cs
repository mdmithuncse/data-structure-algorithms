using System;

namespace ConvertFrom12To24HoursFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string input = "07:05:45PM";
            string output = ConvertTo24Hours(input);
            Console.WriteLine($"The output is: {output}");
        }

        static string ConvertTo24Hours(string input)
        {
            // Get hours
            int h1 = (int)input[1] - '0';
            int h2 = (int)input[0] - '0';
            int hh = (h2 * 10 + h1 % 10);

            // If time is in "AM"
            if (input[8] == 'A')
            {
                if (hh == 12)
                {
                    Console.Write("00");
                    for (int i = 2; i <= 7; i++)
                        Console.Write(input[i]);
                }
                else
                {
                    for (int i = 0; i <= 7; i++)
                        Console.Write(input[i]);
                }
            }

            // If time is in "PM"
            else
            {
                if (hh == 12)
                {
                    Console.Write("12");
                    for (int i = 2; i <= 7; i++)
                        Console.Write(input[i]);
                }
                else
                {
                    hh = hh + 12;
                    Console.Write(hh);
                    for (int i = 2; i <= 7; i++)
                        Console.Write(input[i]);
                }
            }

            return string.Empty;
        }
    }
}
