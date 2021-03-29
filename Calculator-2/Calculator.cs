using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator_2
{
    public static class Calculator
    {
        public static double Calculate(string problem)
        {
            var numbers = Array.ConvertAll(problem.Split('+', '-', '*', '/'), int.Parse).ToList();
            var chars = problem.Split('1', '2', '3', '4', '5', '6', '7', '8', '9', '0');
            double sum = numbers[0];

            for (int i = 0; i < numbers.Count -1; i++)
            {
                if (chars[i+1].Equals("+"))
                {
                    sum += numbers[i+1];
                }
                else if (chars[i+1].Equals("-"))
                {
                    sum -= numbers[i + 1];
                }
                else if (chars[i+1].Equals("*"))
                {
                    sum *= numbers[i + 1];
                }
                else if (chars[i+1].Equals("/"))
                {
                    sum /= numbers[i + 1];
                }
            }              
            return sum;
        }
    }
}
