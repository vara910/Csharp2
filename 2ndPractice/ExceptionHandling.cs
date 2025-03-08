using System;

namespace _2ndPractice
{
    class ExceptionHandling
    {
        public void ExampleExeption()
        {
            try
            {
                Console.WriteLine("Enter the first number:");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                int abr = int.Parse(Console.ReadLine());
                int result = num / abr;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Arithmetic exception caught: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Input format exception caught: {ex.Message}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ExceptionHandling eh = new ExceptionHandling();
            eh.ExampleExeption();
        }
    }
}
