using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGTransporteEServico
{
    public class Carro : Veiculo
    {
        public Carro(string modelo, decimal precoDiario) : base(modelo, precoDiario) { }

        public override void Reservar(DateTime data)
        {
            if(VerificarDisponibilidade(data))
            {
                Console.WriteLine($"O carro {Modelo} foi reservado para a data {data}");
            }
            else
            {
                Console.WriteLine($"O carro {Modelo} não está disponível na data {data}");
            }
        }

        public override decimal CalcularPreco(int dias) 
        { 
            if(dias > 7)
            {
                return (PrecoDiario * dias) * 0.9m;
            }

            return PrecoDiario * dias;
        }


    }
}
