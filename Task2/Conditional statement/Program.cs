using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Task 1
        Console.WriteLine("Enter first integer: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second integer: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Smaller number is: " + Math.Min(num1, num2));

        // Task 2
        Console.WriteLine("Enter a number to check its sign: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
            Console.WriteLine("The sign is +");
        else if (num < 0)
            Console.WriteLine("The sign is -");
        else
            Console.WriteLine("The number is zero");

        // Task 3
        Console.WriteLine("Enter three numbers to sort (comma separated): ");
        string[] input = Console.ReadLine().Split(',');
        int num3 = int.Parse(input[0]);
        int num4 = int.Parse(input[1]);
        int num5 = int.Parse(input[2]);
        int[] arr = { num3, num4, num5 };
        Array.Sort(arr);
        Console.WriteLine("Sorted numbers in ascending order: " + string.Join(", ", arr));

        // Task 4
        Console.WriteLine("Enter five numbers to find the maximum (comma separated): ");
        string[] inputMax = Console.ReadLine().Split(',');
        int[] nums = Array.ConvertAll(inputMax, int.Parse);
        Console.WriteLine("Maximum number is: " + nums.Max());

        // Task 5
        Console.WriteLine("Enter kilometers per hour: ");
        double kilometersPerHour = Convert.ToDouble(Console.ReadLine());
        double milesPerHour = kilometersPerHour * 0.621371;
        Console.WriteLine($"{kilometersPerHour} km/h = {milesPerHour} miles per hour");

        // Task 6
        Console.WriteLine("Enter hours: ");
        int hours = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter minutes: ");
        int minutes = Convert.ToInt32(Console.ReadLine());
        int totalMinutes = (hours * 60) + minutes;
        Console.WriteLine($"Total minutes: {totalMinutes}");

        // Task 7
        Console.WriteLine("Enter total minutes: ");
        int totalMins = Convert.ToInt32(Console.ReadLine());
        int hrs = totalMins / 60;
        int mins = totalMins % 60;
        Console.WriteLine($"{hrs} Hours, {mins} Minutes");

        // Task 8
        string[] sentences = { "Hello World", "C# is great", "I love programming", "Coding is fun", "Arrays are useful" };
        foreach (var sentence in sentences)
        {
            Console.WriteLine(sentence.PadRight(20)); // Prints each sentence with a fixed width
        }

        // Task 9
        Console.WriteLine("Enter a sentence to reverse odd-length words: ");
        string sentenceInput = Console.ReadLine();
        Console.WriteLine("Reversed odd-length words: " + ReverseOdd(sentenceInput));
    }

    static string ReverseOdd(string sentence)
    {
        string[] words = sentence.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length % 2 != 0)
            {
                char[] chars = words[i].ToCharArray();
                Array.Reverse(chars);
                words[i] = new string(chars);
            }
        }
        return string.Join(" ", words);
    }
}
