using System;

namespace TP1._11
{
    internal class Program
    {
        // M�todo que concatena nome e sobrenome
        static string Concat(string nome, string sobrenome)
        {
            string resultado = $"{nome} {sobrenome}";
            Console.WriteLine($"Concat: {resultado}");
            return resultado;
        }

        // M�todo que converte para mai�sculas
        static string ToUpperCase(string nome, string sobrenome)
        {
            string resultado = $"{nome} {sobrenome}".ToUpper();
            Console.WriteLine($"ToUpperCase: {resultado}");
            return resultado;
        }

        // M�todo que remove espa�os
        static string RemoveSpaces(string nome, string sobrenome)
        {
            string resultado = $"{nome}{sobrenome}"; // sem espa�o
            Console.WriteLine($"RemoveSpaces: {resultado}");
            return resultado;
        }

        static void Main(string[] args)
        {
            // Defini��o do delegate
            Func<string, string, string> processor = null;

            // Encadeando m�todos
            processor += Concat;
            processor += ToUpperCase;
            processor += RemoveSpaces;

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.WriteLine("\nExecutando delegate encadeado...");
            string resultadoFinal = processor.Invoke(nome, sobrenome);

            Console.WriteLine($"\nResultado final retornado pelo delegate: {resultadoFinal}");
            Console.ReadLine();
        }
    }
    
}
