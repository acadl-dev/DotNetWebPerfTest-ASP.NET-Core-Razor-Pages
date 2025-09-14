namespace TP1._4
{
    // Definição da classe TemperatureSensor
    class TemperatureSensor
    {
        // Definição do evento
        public event EventHandler TemperatureExceeded;

        // Método para simular a leitura da temperatura
        public void CheckTemperature(double temperature)
        {
            Console.WriteLine($"Temperatura atual: {temperature}ºC");

            // Dispara o evento se a temperatura ultrapassar 100ºC
            if (temperature > 100)
            {
                OnTemperatureExceeded(EventArgs.Empty);
            }
        }

        // Método protegido para disparar o evento
        protected virtual void OnTemperatureExceeded(EventArgs e)
        {
            TemperatureExceeded?.Invoke(this, e);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            var sensor = new TemperatureSensor();

            // Inscrição do manipulador do evento
            sensor.TemperatureExceeded += Sensor_TemperatureExceeded;

            while (true)
            {
                Console.Write("Digite a temperatura atual (ou 'sair' para encerrar): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "sair")
                    break;

                if (double.TryParse(input, out double temp))
                {
                    sensor.CheckTemperature(temp);
                }
                else
                {
                    Console.WriteLine("Entrada inválida! Digite um número.");
                }
            }
        }
        // Manipulador do evento
        private static void Sensor_TemperatureExceeded(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ALERTA! Temperatura acima do limite seguro!");
            Console.ResetColor();
        }
    }
}
