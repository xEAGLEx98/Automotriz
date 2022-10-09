using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
namespace AccesoDatosAutomotriz
{
    public class AccesoHerramientas:IAutomotriz
    {
        Base b = new Base("localhost","root","","automotriz");

        public void Borrar(dynamic entidad)
        {
            b.Comando(string.Format("CALL DeleteHerramientas({0})", entidad.IdHerramientas));
        }

        public void Guardar(dynamic entidad)
        {
            b.Comando(string.Format("CALL InsertHerramientas('{0}' '{1}' , {2} , '{3}' , '{4}' , {5})",
                entidad.CodigoHerramientas, entidad.Nombre, entidad.Medida, entidad.Marca, entidad.Descripcion,
                entidad.IdHerramientas));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("CALL ShowHerramientas('%{0}%')", filtro),"herramientas");
        }
    }
}
