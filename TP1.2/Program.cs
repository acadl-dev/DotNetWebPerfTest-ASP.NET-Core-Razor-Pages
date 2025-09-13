namespace TP1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Pressione 1 + Enter para selecionar seu idioma como Português (BR).");
            Console.WriteLine("Press 2 + Enter to select your language as English.");
            Console.WriteLine("Presione 3 + Enter para seleccionar su idioma como Español.");
            int option = int.Parse(Console.ReadLine());
            Action<string> escolherIdioma = null; // Declarar o delegate


            if (option == 1)
            {
                escolherIdioma = idiomaSelecionadoPortugues;
            }
            else if (option == 2)
            {
                escolherIdioma = idiomaSelecionadoEnglish;
            }
            else if (option == 3)
            {
                escolherIdioma = idiomaSelecionadoEspanol;
            }
            else {

                Console.WriteLine("Opção selecionada inválida: ");
            }

            // Executar o delegate, se válido
            if (escolherIdioma != null)
            {
                escolherIdioma(""); // Passa string vazia porque o método não usa
            }

        }





        public static void idiomaSelecionadoPortugues(string idioma)
        {
            Console.WriteLine("Seja bem vindo(a) ao nosso portal de comunicação!");
        }

        public static void idiomaSelecionadoEnglish(string idioma)
        {
            Console.WriteLine("Welcome to our communication portal!");
        }

        public static void idiomaSelecionadoEspanol(string idioma)
        {
            Console.WriteLine("¡Bienvenido a nuestro portal de comunicación!");
        }
    }
}
