using System;

namespace Arrays_McVey_Cason
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number for array size");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[arraySize];
            int sum = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a whole number to add to the array.");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }

            Console.WriteLine($"The sum of the array is {sum}\n");

            Array.Sort(numbers);

            Console.WriteLine("Array:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
