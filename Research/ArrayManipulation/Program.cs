using System;

namespace ArrayManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] intInput = new int[9] { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            PrintSingleDimensionalArray(intInput);

            string[,] strInput = new string[3, 3] 
            {
                { "s", "y", "v" }, 
                { "k", "l", "m" }, 
                { "a", "h", "p" }
            };
            PrintTwoDimensionalArray(strInput);

            string[,,] strInput1 = new string[2, 2, 3] 
            {
                {
                    { "a", "b", "c" },
                    { "d", "e", "f" }
                },
                {
                    { "g", "h", "i" },
                    { "j", "k", "l" }
                }
            };
            PrintThreeDimensionalArray(strInput1);

            string[,,,] strInput2 = new string[3, 2, 3, 3]
            {
                {
                    {
                        { "1.1a", "1.1b", "1.1c" },
                        { "1.1d", "1.1e", "1.1f" },
                        { "1.1g", "1.1h", "1.1i" }
                    },
                    {
                        { "1.2j", "1.2k", "1.2l" },
                        { "1.2m", "1.2n", "1.2o" },
                        { "1.2p", "1.2q", "1.2r" }
                    }
                },
                {
                    {
                        { "2.1a", "2.1b", "2.1c" },
                        { "2.1d", "2.1e", "2.1f" },
                        { "2.1g", "2.1h", "2.1i" }
                    },
                    {
                        { "2.2j", "2.2k", "2.2l" },
                        { "2.2m", "2.2n", "2.2o" },
                        { "2.2p", "2.2q", "2.2r" }
                    }
                },
                {
                    {
                        { "3.1a", "3.1b", "3.1c" },
                        { "3.1d", "3.1e", "3.1f" },
                        { "3.1g", "3.1h", "3.1i" }
                    },
                    {
                        { "3.2j", "3.2k", "3.2l" },
                        { "3.2m", "3.2n", "3.2o" },
                        { "3.2p", "3.2q", "3.2r" }
                    }
                }
            };

            PrintFourDimensionalArray(strInput2);
        }

        public static void PrintSingleDimensionalArray(int[] input)
        {
            if (input.Length < 0)
            {
                Console.WriteLine($"There is no element in array {nameof(input)}");
            }

            Console.WriteLine($"The elements of the array {nameof(input)} is:");

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{input[i]} -->");
            }
        }

        public static void PrintTwoDimensionalArray(string[,] input)
        {
            if (input.GetLength(0) < 0 && input.GetLength(1) < 0)
            {
                Console.WriteLine($"There is no element in array {nameof(input)}");
            }

            Console.WriteLine($"The elements of the array {nameof(input)} is:");

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    Console.WriteLine($"Array[{i}, {j}] ==> {input[i, j]}");
                }
            }
        }

        public static void PrintThreeDimensionalArray(string[,,] input)
        {
            if (input.GetLength(0) < 0 && input.GetLength(1) < 0 && input.GetLength(2) < 0)
            {
                Console.WriteLine($"There is no element in array {nameof(input)}");
            }

            Console.WriteLine($"The elements of the array {nameof(input)} is:");

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    for (int k = 0; k < input.GetLength(2); k++)
                    {
                        Console.WriteLine($"Array[{i}, {j}, {k}] ==> {input[i, j, k]}");
                    }
                }
            }
        }

        public static void PrintFourDimensionalArray(string[,,,] input)
        {
            if (input.GetLength(0) < 0 && input.GetLength(1) < 0 && input.GetLength(2) < 0 && input.GetLength(3) < 0)
            {
                Console.WriteLine($"There is no element in array {nameof(input)}");
            }

            Console.WriteLine($"The elements of the array {nameof(input)} is:");

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    for (int k = 0; k < input.GetLength(2); k++)
                    {
                        for (int l = 0; l < input.GetLength(3); l++)
                        {
                            Console.WriteLine($"Array[{i}, {j}, {k}, {l}] ==> {input[i, j, k, l]}");
                        }
                    }
                }
            }
        }
    }
}
