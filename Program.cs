using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGTransporteEServico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IVeiculoReservavel> veiculos = new List<IVeiculoReservavel>
            {
                new Carro("Nissan Skyline", 1000),
                new Moto("Ducati Multi Strada 1250", 500)
            };

            DateTime dataReserva = DateTime.Now.AddDays(5);

            foreach(var veiculo in veiculos)
            {
                Console.WriteLine($"Reservando veículo: {veiculo.GetType().Name}");
                veiculo.Reservar(dataReserva);

                int diasReserva = 2; // Exemplo de reserva de 10 dias

                decimal preco = veiculo.CalcularPreco(diasReserva);
                Console.WriteLine($"Custo total para {diasReserva} dias: R$ {preco}");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
