using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGTransporteEServico
{
    public class Moto : Veiculo
    {
        public Moto(string modelo, decimal precoDiario) : base(modelo, precoDiario) { }

        public override void Reservar(DateTime data)
        {
            if (VerificarDisponibilidade(data))
            {
                Console.WriteLine($"A moto {Modelo} foi reservado para a data {data}");
            }
            else
            {
                Console.WriteLine($"A moto {Modelo} não está disponível na data {data}");
            }
        }

        public override decimal CalcularPreco(int dias)
        {
            if(dias < 3)
            {
                return (PrecoDiario * dias) + 50;
            }
            return PrecoDiario * dias;
        }

    }
}
