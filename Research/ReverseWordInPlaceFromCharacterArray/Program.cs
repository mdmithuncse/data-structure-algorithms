using System;

namespace ReverseWordInPlaceFromCharacterArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            char[] input1 = new char[] 
            { 
                'I', ' ', 'd','r', 'i', 'v', 'e', ' ', 'w', 'i', 't', 'h', ' ', 'b','o','l','t' 
            };

            char[] input2 = new char[]
            {
                ' ', ' ', ' ', 'w','e', ' ', ' ', ' ', ' ', 'l', 'i', 'k', 'e', ' ', ' ', 'j','a','v','a', '.', ' ', ' ', ' '
            };

            char[] output = ReverseWord(input2);

            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine($"{output[i]}");
            }
        }

        public static char[] ReverseWord(char[] input)
        {
            int start = 0;
            int end = 0;

            for (int i = 0; i < input.Length; i++)
            {
                // Skip space characters
                while(i < input.Length && input[i] == ' ')
                {
                    i++;
                }

                start = i;

                // Skip non-space characters
                while (i < input.Length && input[i] != ' ')
                {
                    i++;
                }

                end = i - 1;

                // Reverse characters in place in the character array
                while(end > start)
                {
                    char temp = input[start];
                    input[start] = input[end];
                    input[end] = temp;

                    start++;
                    end--;
                }
            }

            return input;
        }
    }
}
