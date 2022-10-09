using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
namespace AccesoDatosAutomotriz
{
    public class AccesoProductos:IAutomotriz
    {
        Base b = new Base("localhost","root","","automotriz");

        public void Borrar(dynamic entidad)
        {
            b.Comando(string.Format("CALL DeleteProductos({0})", entidad.IdProductos));
        }

        public void Guardar(dynamic entidad)
        {
            b.Comando(string.Format("CALL InsertProductos('{0}', '{1}', '{2}', '{3}', {4})", entidad.CodigoBarras,
                entidad.Nombre, entidad.Descripcion, entidad.Marca, entidad.IdProductos));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("CALL SHowProductos('%{0}%')", filtro), "productos");
        }
    }
}
