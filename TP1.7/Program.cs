namespace TP1._7
{
    internal class Program
    {
        class Logger
        {
            public void LogToConsole(string message)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"[Console] {message}");
                Console.ResetColor();
            }

            public void LogToFile(string message)
            {
                string filePath = "log.txt";
                File.AppendAllText(filePath, $"[File] {message}{Environment.NewLine}");
            }

            public void LogToDatabase(string message)
            {
                // Simulação de log em banco de dados
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"[Database] {message} (simulado)");
                Console.ResetColor();
            }
        }
        static void Main(string[] args)
        {
            var logger = new Logger();

            // Criação do multicast delegate sem associar métodos inicialmente
            Action<string> logDelegate = null;

            while (true)
            {
                Console.Write("Digite a mensagem de log (ou 'sair' para encerrar, 'associar' para adicionar métodos): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "sair")
                    break;

                if (input.ToLower() == "associar")
                {
                    // Associando métodos somente quando desejado
                    logDelegate += logger.LogToConsole;
                    logDelegate += logger.LogToFile;
                    logDelegate += logger.LogToDatabase;
                    Console.WriteLine("Métodos do logger associados ao delegate.\n");
                    continue;
                }

                // Invocação robusta do delegate usando ?.Invoke()
                logDelegate?.Invoke(input);

                Console.WriteLine("Mensagem processada (se houver métodos associados).\n");
            }
        }
    }
}
