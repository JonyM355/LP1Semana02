using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro não negativo:");
            sbyte n = sbyte.Parse(Console.ReadLine());

            Console.WriteLine($"{n / 2}");
            Console.WriteLine($"{n << 3}");
            Console.WriteLine($"{n ^ 6}");
            Console.WriteLine($"{n > 10}");
        }
    }
}
