using System;

namespace binitalab3
{
    internal class question5
    {
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            Console.WriteLine("Enter the numerator:");
    //            int numerator = int.Parse(Console.ReadLine());

    //            Console.WriteLine("Enter the denominator:");
    //            int denominator = int.Parse(Console.ReadLine());

    //            int result = numerator / denominator;
    //            Console.WriteLine("Result of division: " + result);
    //        }
    //        catch (DivideByZeroException ex)
    //        {
    //            Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
    //        }
    //        catch (FormatException ex)
    //        {
    //            Console.WriteLine("Error: Invalid input. Please enter numbers only. " + ex.Message);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("An unexpected error occurred: " + ex.Message);
    //        }

    //        try
    //        {
    //            int[] numbers = { 1, 2, 3, 4, 5 };

    //            Console.WriteLine("Enter the index of the array element you want to access:");
    //            int index = int.Parse(Console.ReadLine());

    //            Console.WriteLine("Element at index " + index + " is: " + numbers[index]);
    //        }
    //        catch (IndexOutOfRangeException ex)
    //        {
    //            Console.WriteLine("Error: Index is out of bounds. " + ex.Message);
    //        }
    //        catch (FormatException ex)
    //        {
    //            Console.WriteLine("Error: Invalid input. Please enter a valid index. " + ex.Message);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("An unexpected error occurred: " + ex.Message);
    //        }

    //        try
    //        {
    //            Console.WriteLine("Enter your age:");
    //            int age = int.Parse(Console.ReadLine());

    //            if (age < 0)
    //            {
    //                throw new AgeException("Age cannot be negative.");
    //            }

    //            Console.WriteLine("Your age is: " + age);
    //        }
    //        catch (AgeException ex)
    //        {
    //            Console.WriteLine("Custom Error: " + ex.Message);
    //        }
    //        catch (FormatException ex)
    //        {
    //            Console.WriteLine("Error: Invalid input. Please enter a valid age. " + ex.Message);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("An unexpected error occurred: " + ex.Message);
    //        }

    //        Console.ReadKey();
    //        Console.Read();
    //    }
    }

    public class AgeException : Exception
    {
        public AgeException(string message) : base(message)
        {
        }
    }
}
