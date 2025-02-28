using System;
using System.Net.NetworkInformation;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Digite uma altura de um cilindro:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um raio para um cilindro:");
            double r = double.Parse(Console.ReadLine());

            double pi = Math.PI;

            double v = pi * Math.Pow(r, 2) * a;
            Console.WriteLine($"Volume: {v:f3}");

            double area = 2 * pi * r * (r + a);
            Console.WriteLine($"Área: {area:f3}");
        }
    }
}
