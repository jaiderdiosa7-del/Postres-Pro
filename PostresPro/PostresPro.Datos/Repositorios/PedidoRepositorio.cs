using System;
using System.Collections.Generic;
using System.Text;
using PostresPro.Modelos;
using PostresPro.Datos;

namespace PostresPro.Datos.Repositorios
{
    public class PedidoRepositorio
    {
        public void Agregar(Pedido pedido)
        {
            using (var db = new AppDbContext())
            {
                db.Pedidos.Add(pedido);
                db.SaveChanges();
            }
        }

        public List<Pedido> Listar()
        {
            using (var db = new AppDbContext())
            {
                return db.Pedidos.ToList();
            }
        }

        public Pedido? Buscar(int id)
        {
            using (var db = new AppDbContext())
            {
                return db.Pedidos.Find(id);
            }
        }

        public void Actualizar(Pedido pedido)
        {
            using (var db = new AppDbContext())
            {
                db.Pedidos.Update(pedido);
                db.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            using (var db = new AppDbContext())
            {
                var pedido = db.Pedidos.Find(id);

                if (pedido != null)
                {
                    db.Pedidos.Remove(pedido);
                    db.SaveChanges();
                }
            }
        }

    }
}