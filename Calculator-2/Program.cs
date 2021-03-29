using System;

namespace Calculator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Write your math expression and press enter. Remember to stick to the same precedence");
                Console.WriteLine(Calculator.Calculate(Console.ReadLine()));
            }
        }
    }
}
