using System;
using System.Collections.Generic;
using System.Text;

namespace PostresPro.Modelos
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Telefono { get; set; } = "";
        public string Correo { get; set; } = "";
        public bool Activo { get; set; } = true;


        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}
