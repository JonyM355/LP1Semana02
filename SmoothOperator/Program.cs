using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            sbyte n = sbyte.Parse(Console.ReadLine());

            Console.WriteLine($"Decremento: {--n}");
            Console.WriteLine($"Incremento: {++n}");
        }
    }
}
