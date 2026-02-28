using Projeto.Src;

namespace Projeto;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("Lista de exemplos aplicados:");
            Console.WriteLine();
            Console.WriteLine("1   — Structs");

            Console.WriteLine();
            Console.Write("Digite o número do exemplo que deseja executar ou 0 para sair: ");
            string? escolha = Console.ReadLine();

            if (escolha == "0")
            {
                Console.WriteLine("Fim da operação.");
                return;
            }
            else
            {
                Console.WriteLine();

                if (escolha == "1")
                {
                    Structs.Exemplo();
                }
                else
                {
                    continue;
                }

                Console.WriteLine();
            }
        }
    }
}
