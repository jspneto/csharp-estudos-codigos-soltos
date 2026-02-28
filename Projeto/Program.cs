namespace Projeto;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("Lista de exemplos aplicados:");
            Console.WriteLine();
            Console.WriteLine("    Sem exemplos aplicados");

            Console.WriteLine();
            Console.Write("Digite o número do exemplo que deseja executar ou 0 para sair: ");
            string? escolha = Console.ReadLine();
            Console.WriteLine();

            if (escolha == "0")
            {
                return;
            }
            else
            {
                continue;
            }
        }
    }
}
