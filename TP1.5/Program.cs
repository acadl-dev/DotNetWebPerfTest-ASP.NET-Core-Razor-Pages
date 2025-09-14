namespace TP1._5
{
    // Classe que gerencia downloads
    class DownloadManager
    {
        // Evento para notificar conclusão do download
        public event EventHandler DownloadCompleted;

        // Método que simula um download
        public void StartDownload(string fileName)
        {
            Console.WriteLine($"Iniciando download de '{fileName}'...");

            // Simula tempo de download
            Thread.Sleep(3000); // 3 segundos

            // Dispara o evento ao finalizar
            OnDownloadCompleted(EventArgs.Empty, fileName);
        }

        // Método protegido para disparar o evento
        protected virtual void OnDownloadCompleted(EventArgs e, string fileName)
        {
            DownloadCompleted?.Invoke(this, new DownloadEventArgs(fileName));
        }
    }

    // Classe para passar informações do download
    class DownloadEventArgs : EventArgs
    {
        public string FileName { get; }

        public DownloadEventArgs(string fileName)
        {
            FileName = fileName;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager = new DownloadManager();

            // Inscrição do manipulador do evento
            manager.DownloadCompleted += Manager_DownloadCompleted;

            while (true)
            {
                Console.Write("Digite o nome do arquivo para download (ou 'sair' para encerrar): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "sair")
                    break;

                manager.StartDownload(input);
            }
        }
        // Manipulador do evento
        private static void Manager_DownloadCompleted(object sender, EventArgs e)
        {
            if (e is DownloadEventArgs args)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Download concluído: {args.FileName}");
                Console.ResetColor();
            }
        }
    }
}
