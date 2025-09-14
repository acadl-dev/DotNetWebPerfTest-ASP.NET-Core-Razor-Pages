using System;

namespace TP1._11
{
    internal class Program
    {
        // Método que concatena nome e sobrenome
        static string Concat(string nome, string sobrenome)
        {
            string resultado = $"{nome} {sobrenome}";
            Console.WriteLine($"Concat: {resultado}");
            return resultado;
        }

        // Método que converte para maiúsculas
        static string ToUpperCase(string nome, string sobrenome)
        {
            string resultado = $"{nome} {sobrenome}".ToUpper();
            Console.WriteLine($"ToUpperCase: {resultado}");
            return resultado;
        }

        // Método que remove espaços
        static string RemoveSpaces(string nome, string sobrenome)
        {
            string resultado = $"{nome}{sobrenome}"; // sem espaço
            Console.WriteLine($"RemoveSpaces: {resultado}");
            return resultado;
        }

        static void Main(string[] args)
        {
            // Definição do delegate
            Func<string, string, string> processor = null;

            // Encadeando métodos
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
