using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PostresPro.Datos;

namespace PostresPro.Servicios
{
    public class BaseDatosServicio
    {
        public void CrearBaseDatos()
        {
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();
            }
        }
    }
}
