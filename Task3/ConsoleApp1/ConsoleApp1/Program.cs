using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            /*
                    string [ ] ARR= [ 1,7  9  45, ]
                	int arr2=["Str" "alex","moh"
                	string arr3= 'the','fox' 'over' lazy, 'dog',  ]

             */
            string[] ARR = { "1", "7", "9", "45" };
            int[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };

            //Task 2
            string[] fruits = { "Tomato", "Banana", "Watermelon" };
            int indexBanana = Array.IndexOf(fruits, "Banana"); // Index is 1
            int indexTomato = Array.IndexOf(fruits, "Tomato"); // Index is 0
            Console.WriteLine($"Banana index: {indexBanana}");
            Console.WriteLine($"Tomato index: {indexTomato}");

            //Task 3
            string[] favoriteFood = { "Pizza", "Burger", "Pasta", "Sushi", "Salad" };
            string[] favoriteSport = { "Football", "Basketball", "Swimming" };
            string[] favoriteMovie = { "Inception", "Matrix", "Interstellar", "The Dark Knight" };

            // Printing each array using foreach
            Console.WriteLine("Favorite Food:");
            foreach (var food in favoriteFood)
            {
                Console.WriteLine(food);
            }

            Console.WriteLine("Favorite Sport:");
            foreach (var sport in favoriteSport)
            {
                Console.WriteLine(sport);
            }

            Console.WriteLine("Favorite Movie:");
            foreach (var movie in favoriteMovie)
            {
                Console.WriteLine(movie);
            }

            //Task 4
            Console.WriteLine("Input three numbers separated by comma: ");
            string input = Console.ReadLine(); // e.g., "5,10,15"
            string[] numbers = input.Split(',');
            int num1 = int.Parse(numbers[0]);
            int num2 = int.Parse(numbers[1]);
            int num3 = int.Parse(numbers[2]);

            int sum = num1 + num2 + num3;
            Console.WriteLine($"The sum of three numbers: {sum}");

            //Task 5
            int sumOdd = 0;
            Console.WriteLine("The odd numbers are:");
            for (int i = 1; i <= 100; i += 2)
            {
                Console.Write(i + " ");
                sumOdd += i;
            }
            Console.WriteLine($"\nThe Sum of odd Numbers is: {sumOdd}");

            //Task 6
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Task 7
            int number = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number++ + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
