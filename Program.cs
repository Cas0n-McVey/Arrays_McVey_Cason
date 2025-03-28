using System;

namespace Arrays_McVey_Cason
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks for a whole number for array size
            Console.WriteLine("Enter a whole number for array size");
            // Convert it into a integer
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[arraySize];
            // Start it off with 0
            int sum = 0;

            // You get get the length of the number
            for(int i = 0; i < numbers.Length; i++)
            {
                // Asks for a whole number to add to array
                Console.WriteLine("Enter a whole number to add to the array.");
                // Convert it into a integer
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }

            // Tells you the sum of the array
            Console.WriteLine($"The sum of the array is {sum}\n");

            //Sorts the numbers
            Array.Sort(numbers);

            Console.WriteLine("Array:");
            // Put them all in the Console
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
