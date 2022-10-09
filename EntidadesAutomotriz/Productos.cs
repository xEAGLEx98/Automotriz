using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAutomotriz
{
    public class Productos
    {
        public Productos(int idProductos, string codigoBarras, string nombre, string descripcion, string marca)
        {
            IdProductos = idProductos;
            CodigoBarras = codigoBarras;
            Nombre = nombre;
            Descripcion = descripcion;
            Marca = marca;
        }

        public int IdProductos { get; set; }
        public string CodigoBarras { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
    }
}
