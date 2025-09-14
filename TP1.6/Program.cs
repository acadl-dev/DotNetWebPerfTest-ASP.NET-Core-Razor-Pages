namespace TP1._6
{
    // Classe que gerencia os logs
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
    internal class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();

            // Criação do multicast delegate
            Action<string> logDelegate = null;
            logDelegate += logger.LogToConsole;
            logDelegate += logger.LogToFile;
            logDelegate += logger.LogToDatabase;

            while (true)
            {
                Console.Write("Digite a mensagem de log (ou 'sair' para encerrar): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "sair")
                    break;

                // Chama todos os métodos do delegate
                logDelegate?.Invoke(input);

                Console.WriteLine("Log registrado em todos os destinos!\n");
            }
        }
    }
}
