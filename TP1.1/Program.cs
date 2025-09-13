namespace TP1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // decimal valor_desconto = 0.1m;
           // decimal valor_original = 0.0m;

            CalculateDiscount calculateDiscount;
            calculateDiscount = CalcularDesconto;

            Console.WriteLine("Insira o valor original do produto:");
            Console.Write("R$: ");
            decimal valor_original = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("O valor atualizado é: R$ " + calculateDiscount(valor_original).ToString("F2"));
            Console.ReadLine(); //Para ler o console
        }

        public delegate decimal CalculateDiscount(decimal valor_original);

        public static decimal CalcularDesconto(decimal valor_original)
        {
            
            return valor_original - (valor_original * 0.1m);

        }
    }
}
