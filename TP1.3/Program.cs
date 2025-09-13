namespace TP1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> calcularArea = CalcularAreaDoRetangulo;

            Console.WriteLine("Insira a base do retângulo em cm");
            double baseRetangulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Agora insira altura do retângulo em cm");
            double alturaRetangulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A área desse retângulo é: " + calcularArea(baseRetangulo, alturaRetangulo) + "cm^2");

        }

        public static double CalcularAreaDoRetangulo(double baseRetangulo, double alturaRetangulo)
        {
            return baseRetangulo * alturaRetangulo;
        }
    }
}
