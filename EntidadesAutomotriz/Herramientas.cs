using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAutomotriz
{
    public class Herramientas
    {
        public Herramientas(int idHerramientas, string codigoHerramienta, string nombre, double medida, string marca, string descripcion)
        {
            IdHerramientas = idHerramientas;
            CodigoHerramienta = codigoHerramienta;
            Nombre = nombre;
            Medida = medida;
            Marca = marca;
            Descripcion = descripcion;
        }

        public int IdHerramientas { get; set; }
        public string CodigoHerramienta { get; set; }
        public string Nombre { get; set; }
        public double Medida { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
    }
}
