using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
namespace AccesoDatosAutomotriz
{
    public class AccesoPermisos
    {
        Base b = new Base("localhost","root","","automotriz");

        public void SeleccionPermisos(dynamic entidad)
        {
            b.Comando(string.Format("CALL Seleccion({0}, {1})", entidad.FkIdUsuarios, entidad.Seleccion));
        }
    }
}
