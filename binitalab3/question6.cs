using System;

namespace binitalab3
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException()
        {
        }

        public InvalidAgeException(string message) : base(message)
        {
        }

        public InvalidAgeException(string message, Exception inner) : base(message, inner)
        {
        }
    }

    internal class question6
    {
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        Console.WriteLine("Enter your age:");
        //        int age = int.Parse(Console.ReadLine());

        //        if (age < 18)
        //        {
        //            throw new InvalidAgeException("Age cannot be less than 18.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Your age is valid: " + age);
        //        }
        //    }
        //    catch (InvalidAgeException ex)
        //    {
        //        Console.WriteLine("Custom Exception Caught: " + ex.Message);
        //    }
        //    catch (FormatException ex)
        //    {
        //        Console.WriteLine("Invalid input format. Please enter a valid integer. " + ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("An unexpected error occurred: " + ex.Message);
        //    }

        //    Console.ReadKey();
        //    Console.Read();
        //}
    }
}

