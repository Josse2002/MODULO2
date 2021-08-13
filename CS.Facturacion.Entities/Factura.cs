using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Facturacion.Entities
{
    public class Factura
    {
        public Int64 Id { get; set; }

        public Int64 Numero { get; set; }

        public DateTime Fecha { get; set; }

        public Int64 IdCliente { get; set; }

        public Double SubTotal { get; set; }

        public Double TotalImpuesto { get; set; }

        public Double Total { get; set; }

        public string Estado { get; set; }

        public Factura() { }

        public Factura(Int64 pId, Int64 pNumero, DateTime pFecha, Int64 pIdCliente, Double pSubTotal, Double pTotalImpuesto,
            Double pTotal, string pEstado)
        {
            Id = pId;
            Numero = pNumero;
            Fecha = pFecha;
            IdCliente = pIdCliente;
            SubTotal = pSubTotal;
            TotalImpuesto = pTotalImpuesto;
            Total = pTotal;
            Estado = pEstado;

        }
    }
}
