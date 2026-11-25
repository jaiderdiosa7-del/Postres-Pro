using System;
using System.Collections.Generic;
using System.Text;
using PostresPro.Datos.Repositorios;
using PostresPro.Modelos;

namespace PostresPro.Servicios
{
    public class PedidoServicio
    {
        private PedidoRepositorio repositorio = new PedidoRepositorio();


        public string? Agregar(Pedido pedido)
        {
            if (pedido.ClienteId <= 0)
            {
                return "Debe seleccionar un cliente.";
            }

            if (string.IsNullOrWhiteSpace(pedido.NombrePostre))
            {
                return "El nombre del postre es obligatorio.";
            }

            if (pedido.Cantidad <= 0)
            {
                return "La cantidad debe ser mayor que cero.";
            }

            if (pedido.PrecioUnitario <= 0)
            {
                return "El precio debe ser mayor que cero.";
            }

            pedido.Total = pedido.Cantidad * pedido.PrecioUnitario;

            repositorio.Agregar(pedido);

            return null;
        }


        public List<Pedido> Listar()
        {
            return repositorio.Listar();
        }


        public Pedido? Buscar(int id)
        {
            return repositorio.Buscar(id);
        }


        public string? Actualizar(Pedido pedido)
        {
            if (pedido.ClienteId <= 0)
            {
                return "Debe seleccionar un cliente.";
            }

            if (string.IsNullOrWhiteSpace(pedido.NombrePostre))
            {
                return "El nombre del postre es obligatorio.";
            }

            if (pedido.Cantidad <= 0)
            {
                return "La cantidad debe ser mayor que cero.";
            }

            if (pedido.PrecioUnitario <= 0)
            {
                return "El precio debe ser mayor que cero.";
            }

            pedido.Total = pedido.Cantidad * pedido.PrecioUnitario;

            repositorio.Actualizar(pedido);

            return null;
        }


        public void Eliminar(int id)
        {
            repositorio.Eliminar(id);
        }


    }
}

