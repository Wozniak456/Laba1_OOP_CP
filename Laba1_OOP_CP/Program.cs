using System;
using csLib;
namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input a number1: ");
            int number_A = int.Parse(Console.ReadLine());
            int rez;
            Class1.MinusOne(number_A, out rez);
            Console.Write($"{number_A} - 1 = {rez}\n");
            Console.Write("input a number2: ");
            int number_B = int.Parse(Console.ReadLine());
            Console.Write("input a number3: ");
            int number_С = int.Parse(Console.ReadLine());
            Console.Write($"Numbers '{number_B}' and '{number_С}' are equal: {Class1.Equal(number_B, number_С)}");
        }
    }
}
