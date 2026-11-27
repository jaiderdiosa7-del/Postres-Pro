using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PostresPro.Datos;


public class BaseDatosServicio
{
    public void CrearBaseDatos()
    {
        using (var db = new AppDbContext())
        {
            db.Database.EnsureCreated();

            var conexion = db.Database.GetDbConnection();
            conexion.Open();

            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "PRAGMA table_info('Clientes');";

                using (var lector = comando.ExecuteReader())
                {
                    bool existeColumna = false;

                    while (lector.Read())
                    {
                        if (lector.GetString(1) == "Activo")
                        {
                            existeColumna = true;
                            break;
                        }
                    }

                    lector.Close();

                    if (!existeColumna)
                    {
                        using (var agregar = conexion.CreateCommand())
                        {
                            agregar.CommandText =
                                "ALTER TABLE Clientes ADD COLUMN Activo INTEGER NOT NULL DEFAULT 1;";

                            agregar.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
    }
}
