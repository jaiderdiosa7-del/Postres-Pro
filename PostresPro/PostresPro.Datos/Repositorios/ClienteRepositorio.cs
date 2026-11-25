using System;
using System.Collections.Generic;
using System.Text;
using PostresPro.Datos;
using PostresPro.Modelos;

namespace PostresPro.Datos.Repositorios
{
    public class ClienteRepositorio
    {
        public void Agregar(Cliente cliente)
        {
            using (var db = new AppDbContext())
            {
                db.Clientes.Add(cliente);
                db.SaveChanges();
            }
        }

        public List<Cliente> Listar()
        {
            using (var db = new AppDbContext())
            {
                return db.Clientes.ToList();
            }
        }

        public Cliente? Buscar(int id)
        {
            using (var db = new AppDbContext())
            {
                return db.Clientes.Find(id);
            }
        }

        public void Actualizar(Cliente cliente)
        {
            using (var db = new AppDbContext())
            {
                db.Clientes.Update(cliente);
                db.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            using (var db = new AppDbContext())
            {
                var cliente = db.Clientes.Find(id);

                if (cliente != null)
                {
                    db.Clientes.Remove(cliente);
                    db.SaveChanges();
                }
            }
        }

    }
}
