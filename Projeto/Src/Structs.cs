using System.Globalization;

namespace Projeto.Src;

static class Structs
{
    public static void Exemplo()
    {
        TextoReferencia();

        Console.WriteLine();
        Console.WriteLine("Chamada e atribuição diretas:");
        Console.WriteLine();
        Console.WriteLine("Ponto p;");
        Console.WriteLine("p.X = 10;");
        Console.WriteLine("p.Y = 20;");
        Console.WriteLine("Console.WriteLine(p.ToString());");
        Console.WriteLine();
        Console.Write("Imprime ");
        
        Ponto p;
        p.X = 10;
        p.Y = 20;
        Console.WriteLine(p.ToString()); // Imprime (10.00 , 20.00)

        Console.WriteLine();
        Console.WriteLine("Chamada via construtor:");
        Console.WriteLine();
        Console.WriteLine("p = new();");
        Console.WriteLine("Console.WriteLine(p.ToString())");
        Console.WriteLine();
        Console.WriteLine("Imprime ");

        p = new();
        Console.WriteLine(p.ToString()); // Imprime (0.00 , 0.00)
    }

    private static void TextoReferencia()
    {
        string descricao = "Structs podem funcionar tanto dentro de classes quanto isolados, e aceitam\n"
            + "construtores e métodos. Uso recomendado em casos onde é necessário representar\n"
            + "elementos complexos que não precisam ou não podem ser instanciados.";

        string implementacao = "struct Ponto\n"
            + "{\n"
            + "    double X;\n"
            + "    double Y;\n"
            + "\n"
            + "    public override string ToString()\n"
            + "    {\n"
            + "        return \"(\"\n"
            + "            + $\"{X.ToString(\"F2\", CultureInfo.InvariantCulture)} , \"\n"
            + "            + $\"{Y.ToString(\"F2\", CultureInfo.InvariantCulture)}\"\n"
            + "        \")\"\n"
            + "    }\n"
            + "}\n";

        Console.WriteLine(descricao);
        Console.WriteLine();
        Console.WriteLine("Exemplo de implementação: ");
        Console.WriteLine();
        Console.WriteLine(implementacao);
    }

    private struct Ponto
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return "("
                + $"{X.ToString("F2", CultureInfo.InvariantCulture)} , "
                + $"{Y.ToString("F2", CultureInfo.InvariantCulture)}"
                + ")";
        }
    }
}