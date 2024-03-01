using System;

namespace NomeDoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Digite um número não-negativo: ");
            string m = Console.ReadLine();
            byte n = byte.Parse(m);
            Console.WriteLine("Resultado da operação de decremento de n: ");
            Console.WriteLine(--n);
            Console.WriteLine("Resultado da operação de incremento de n: ");
            Console.WriteLine(++n);

        }
    }
}
