using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Numerics;

namespace Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число, факториал которого нужно найти: ");
            int number = Convert.ToInt32(Console.ReadLine());
            BigInteger result = FactorialAsync(number).Result;
            Console.WriteLine("Факториал числа = {0}", result);
            Console.ReadKey();
        }
        static BigInteger Factorial(int number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= (BigInteger)i;
                Thread.Sleep(500);
            }
            return (factorial);
        }
        static async Task<BigInteger> FactorialAsync(int number)
        {
            BigInteger result = await Task.Run(() => Factorial(number));
            return result;
        }
    }
}
