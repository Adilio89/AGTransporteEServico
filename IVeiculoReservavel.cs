using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGTransporteEServico
{
    public interface IVeiculoReservavel
    {
        void Reservar(DateTime data);

        decimal CalcularPreco(int dias);
    }
}
