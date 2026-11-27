using System;
using System.Collections.Generic;
using System.Text;
using PostresPro.Datos.Repositorios;
using PostresPro.Modelos;

namespace PostresPro.Servicios
{
    public class ClienteServicio
    {
        private ClienteRepositorio repositorio = new ClienteRepositorio();


        public string? Agregar(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nombre))
            {
                return "El nombre del cliente es obligatorio.";
            }

            if (!string.IsNullOrWhiteSpace(cliente.Telefono) &&
                !cliente.Telefono.All(char.IsDigit))
            {
                return "El teléfono solo debe contener números.";
            }

            if (!string.IsNullOrWhiteSpace(cliente.Correo) &&
                !cliente.Correo.Contains("@"))
            {
                return "El correo debe contener el símbolo @.";
            }

            var clientes = repositorio.Listar();

            if (!string.IsNullOrWhiteSpace(cliente.Telefono) &&
                clientes.Any(c => c.Telefono == cliente.Telefono))
            {
                return "Ya existe un cliente con ese teléfono.";
            }

            if (!string.IsNullOrWhiteSpace(cliente.Correo) &&
                clientes.Any(c => string.Equals(
                    c.Correo, cliente.Correo,
                    StringComparison.OrdinalIgnoreCase)))
            {
                return "Ya existe un cliente con ese correo.";
            }

            repositorio.Agregar(cliente);
            return null;
        }


        public List<Cliente> Listar()
        {
            return repositorio.Listar();
        }


        public Cliente? Buscar(int id)
        {
            return repositorio.Buscar(id);
        }


        public string? Actualizar(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nombre))
            {
                return "El nombre del cliente es obligatorio.";
            }

            if (!string.IsNullOrWhiteSpace(cliente.Telefono) &&
                !cliente.Telefono.All(char.IsDigit))
            {
                return "El teléfono solo debe contener números.";
            }

            if (!string.IsNullOrWhiteSpace(cliente.Correo) &&
                !cliente.Correo.Contains("@"))
            {
                return "El correo debe contener el símbolo @.";
            }

            var clientes = repositorio.Listar();

            if (!string.IsNullOrWhiteSpace(cliente.Telefono) &&
                clientes.Any(c => c.Id != cliente.Id &&
                                  c.Telefono == cliente.Telefono))
            {
                return "Ya existe otro cliente con ese teléfono.";
            }

            if (!string.IsNullOrWhiteSpace(cliente.Correo) &&
                clientes.Any(c => c.Id != cliente.Id &&
                                  string.Equals(
                                      c.Correo,
                                      cliente.Correo,
                                      StringComparison.OrdinalIgnoreCase)))
            {
                return "Ya existe otro cliente con ese correo.";
            }

            repositorio.Actualizar(cliente);
            return null;
        }


        public string? Eliminar(int id)
        {
            Cliente? cliente = repositorio.Buscar(id);

            if (cliente == null)
            {
                return "El cliente no existe.";
            }

            if (cliente.Pedidos.Any())
            {
                return "No se puede eliminar este cliente porque tiene pedidos asociados.";
            }

            repositorio.Eliminar(id);

            return null;
        }

    }
}
