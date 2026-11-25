
using PostresPro.Servicios;

namespace PostresPro.Escritorio
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            BaseDatosServicio servicio = new BaseDatosServicio();
            servicio.CrearBaseDatos();

            Application.Run(new FormClientes());
        }
    }
}
