using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = { 73, 57, 49, 99, 133, 20, 1 };
            int[] expected = Sort(array, 0, array.Length - 1);

            foreach (var item in expected)
                Console.WriteLine($"{item }");
        }

        static int[] Sort(int[] array, int left, int right)
        {
            if(left < right)
            {
                int middle = left + (right - left) / 2;

                Sort(array, left, middle);
                Sort(array, middle + 1, right);

                Merge(array, left, middle, right);
            }

            return array;
        }

        static void Merge(int[] array, int left, int middle, int right)
        {
            int leftArrayLength = middle - left + 1;
            int rightArrayLength = right - middle;

            int[] leftTempArray = new int[leftArrayLength];
            int[] rightTempArray = new int[rightArrayLength];
            
            int i, j, k;

            for (i = 0; i < leftArrayLength; i++)
                leftTempArray[i] = array[left + i];

            for (j = 0; j < rightArrayLength; j++)
                rightTempArray[j] = array[middle + 1 + j];

            i = 0;
            j = 0;
            k = left;

            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    array[k++] = leftTempArray[i++];
                }
                else
                {
                    array[k++] = rightTempArray[j++];
                }
            }

            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];
            }

            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];
            }
        }
    }
}
