using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGTransporteEServico
{
    public abstract class Veiculo : IVeiculoReservavel
    {
        public Veiculo(string modelo, decimal precoDiario) 
        { 
            Modelo = modelo;
            PrecoDiario = precoDiario;
        }

        protected string Modelo { get; set; }
        protected decimal PrecoDiario { get; set; }
        public abstract decimal CalcularPreco(int dias);
        public abstract void Reservar(DateTime data);
        protected bool VerificarDisponibilidade(DateTime data)
        {
            Random rand = new Random();
            return rand.Next(0, 2) == 1;
        }
    }
}
