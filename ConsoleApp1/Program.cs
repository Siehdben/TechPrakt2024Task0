using System;

namespace SumCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Num1:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Num2:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;
            Console.WriteLine($"Сума чисел {number1} та {number2} = {sum}.");
        }
    }
}
