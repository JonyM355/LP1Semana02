using System;
using System.Collections;
using System.Security.AccessControl;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string question, response;

            do
            {
                Console.WriteLine("Pergunta-me alguma coisa!");
                question = Console.ReadLine();

                switch (question)
                {
                    case "Qual é o sentido da vida?":
                        response = "Sim! ;)";
                        break;

                    case "Hotel?":
                        response = "Trivago";
                        break;

                    case "Qual é o teu segredo?":
                        response = "O meu segredo é _________!";
                        break;

                    case "Tudo bem?":
                        response = "Estou bem, obrigado por perguntares.";
                        break;

                    default:
                        response = "Não sei a resposta!";
                        break;
                }
                Console.WriteLine(response);

            } while (response != "EXIT");
        }
    }
}
