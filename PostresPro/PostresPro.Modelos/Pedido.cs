using System;
using System.Collections.Generic;
using System.Text;

namespace PostresPro.Modelos
{
    public class Pedido
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public string NombrePostre { get; set; } = "";
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; } = "Pendiente";
        public decimal Total { get; set; }
    }
}
