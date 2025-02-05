/*
// Author: Isaac Martinez
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Practice implementing methods in C#
*/
namespace COMP003A.LectureActivity4_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Greet the user
            Greetuser();

            // Input two numbers and calculate their sum
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine()); // Parse user input to an integer

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine()); // Parse user input to an integer

            int sum = CalculateSum(num1, num2); // Call the method and store the result
            Console.WriteLine($"The sum of {num1} and {num2} is {sum}.");

            // Display the contents of an array
            int[] numbers = { 10, 20, 30, 40, 50 }; // Initialize an array
            Console.WriteLine("Array contents:");
            DisplayArray(numbers); // Call the method to print the array
        }

        /// <summary>
        /// Greet the user by name
        /// </summary>
        static void Greetuser()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine(); // Store user input in 'name'
            Console.WriteLine($"Hello, {name}! Welcome to the Methods Activivty.");
        }

        ///<summary>
        /// Calculate the sum of two numbers and returns the result
        /// </summary>
        /// <param name="num1">Integer Input Number 1</param>
        /// <param name="num2">Integer Input Number 2</param>
        /// <returns>Integer sum of the two integer inputs</returns>
        
        static int CalculateSum(int num1, int num2)
        {
            return num1 + num2; // Add the two numbers and return the result
        }

        ///<summary>
        /// Display the contents of an array
        /// </summary>
        /// <param name="numbers">Array collection of integers</param>
        
        static void DisplayArray(int[] numbers)
        {
            foreach (int num in numbers) // Loop through the arrray
            {
                Console.WriteLine(num); // Print each number
            }
        }
    }
}
