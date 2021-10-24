using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string numberInput = "0123456789";
            string smallLetterInput = "abcdefghijklmnopqrstuvwxyz";
            string capitalLetterInput = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string letterInput = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string specialCharacterInput = "!@#$%^&*()_+";
            string alphaNumericInput = "abcd1234ABCD69325";

            Console.WriteLine($"IsAllNumber: {IsAllNumber(numberInput)}");
            Console.WriteLine($"IsAllSmallLetter: {IsAllSmallLetter(smallLetterInput)}");
            Console.WriteLine($"IsAllCapitalLetter: {IsAllCapitalLetter(capitalLetterInput)}");
            Console.WriteLine($"IsAllLetter: {IsAllLetter(letterInput)}");
            Console.WriteLine($"IsAllSpecialCharacter: {IsAllSpecialCharacter(specialCharacterInput)}");
            Console.WriteLine($"IsAllAlphaNumericCharacter: {IsAllAlphaNumericCharacter(alphaNumericInput)}");
        }

        private static bool IsNumber(char ch)
        {
            // For 0 to 9 ascii value range is 48 - 57

            if (ch >= 48 && ch <= 57)
            {
                return true;
            }

            return false;
        }

        private static bool IsSmallLetter(char ch)
        {
            // For a to z ascii value range is 97 - 122
            if (ch >= 97 && ch <= 122)
            {
                return true;
            }

            return false;
        }

        private static bool IsCapitalLetter(char ch)
        {
            // For A to Z ascii value range is 65 - 90
            if (ch >= 65 && ch <= 90)
            {
                return true;
            }

            return false;
        }

        private static bool IsLetter(char ch)
        {
            // For a to z ascii value range is 97 - 122 and For A to Z ascii value range is 65 - 90
            if ((ch >= 97 && ch <= 122) || (ch >= 65 && ch <= 90))
            {
                return true;
            }

            return false;
        }

        private static bool IsSpecialCharacter(char ch)
        {
            // For special characters ascii value range is 32 - 47 and 58 - 64 and 91 - 96 and 123 - 127
            if ((ch >= 32 && ch <= 47) || (ch >= 58 && ch <= 64) || (ch >= 91 && ch <= 96) || (ch >= 123 && ch <= 127))
            {
                return true;
            }

            return false;
        }

        public static bool IsAlphaNumericCharacter(char ch)
        {
            // For a to z ascii value range is 97 - 122 and For A to Z ascii value range is 65 - 90
            // For 0 to 9 ascii value range is 48 - 57 
            if ((ch >= 97 && ch <= 122) || (ch >= 65 && ch <= 90) || (ch >= 48 && ch <= 57))
            {
                return true;
            }

            return false;
        }

        public static bool IsAllNumber(string input)
        {
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (IsNumber(input[i]))
                {
                    count++;
                }
            }

            return count == input.Length ? true : false;
        }

        public static bool IsAllSmallLetter(string input)
        {
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (IsSmallLetter(input[i]))
                {
                    count++;
                }
            }

            return count == input.Length ? true : false;
        }

        public static bool IsAllCapitalLetter(string input)
        {
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (IsCapitalLetter(input[i]))
                {
                    count++;
                }
            }

            return count == input.Length ? true : false;
        }

        public static bool IsAllLetter(string input)
        {
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (IsLetter(input[i]))
                {
                    count++;
                }
            }

            return count == input.Length ? true : false;
        }

        public static bool IsAllSpecialCharacter(string input)
        {
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (IsSpecialCharacter(input[i]))
                {
                    count++;
                }
            }

            return count == input.Length ? true : false;
        }

        public static bool IsAllAlphaNumericCharacter(string input)
        {
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (IsAlphaNumericCharacter(input[i]))
                {
                    count++;
                }
            }

            return count == input.Length ? true : false;
        }
    }
}
