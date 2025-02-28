using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Gerar num aleatório~
            Random rnd = new Random();
            int numberToGuess = rnd.Next(31);
            //pedir ao jgdr um num entre 0-30
            int tentativas = 0;

            while (true)
            {
                tentativas++;
                Console.Write("Insert number: ");
                int num = int.Parse(Console.ReadLine());

                //se o num for < 0 ou > 30, informar e voltar
                if ((num < 0) || (num > 30))
                {
                    Console.Write("Numbers must be between 0 and 30. ");
                    Console.WriteLine("Try again.");
                    continue;
                }
                
                //se o num for < que o numToGuess, informá-lo e voltar
                if (num < numberToGuess)
                {
                    Console.Write($"The hidden number is higher than {num}. ");
                    Console.WriteLine("Try again.");
                    continue;
                }

                //se o num for > que o numToGuess, informá-lo e voltar
                if (num > numberToGuess)
                {
                    Console.Write($"The hidden number is lower than {num}. ");
                    Console.WriteLine("Try again.");
                    continue;
                }

                //se o num == aleatório, apresentar o número de vezes q demorou
                else
                {
                    Console.Write($@"You found the hidden number {num} after");
                    Console.WriteLine($" {tentativas} tries.");
                    break;
                }
            }
            //se o num inserido for < ou > que o num aleatorio,informar

        }
    }
}
