using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
namespace AccesoDatosAutomotriz
{
    public class AccesoPermisos:IAutomotriz
    {
        Base b = new Base("localhost","root","","automotriz");

        public void Borrar(dynamic entidad)
        {
            b.Comando(string.Format("CALL DeletePermisos()"))
        }

        public void Guardar(dynamic entidad)
        {
            throw new NotImplementedException();
        }

        public DataSet Mostrar(string filtro)
        {
            throw new NotImplementedException();
        }
    }
}
