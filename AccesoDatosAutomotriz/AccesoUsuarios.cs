using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
namespace AccesoDatosAutomotriz
{
    public class AccesoUsuarios : IAutomotriz
    {
        Base b = new Base("localhost","root","","automotriz");

        public void Borrar(dynamic entidad)
        {
            b.Comando(string.Format("CALL DeleteUsuarios({0})", entidad.IdUsuarios));
        }

        public void Guardar(dynamic entidad)
        {
            b.Comando(string.Format("CALL InsertUsuarios('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6})",
                entidad.Nombre, entidad.ApellidoP, entidad.ApellidoM, entidad.FDN, entidad.RFC, entidad.Pass,
                entidad.IdUsuarios));
        }

        public DataSet Mostrar(string filtro)
        {
           return b.Obtener(String.Format("CALL ShowUsuarios('%{0}%')", filtro), "usuarios");
        }
        public DataSet Login(string usuario)
        {
            return b.Obtener(string.Format("select * from usuarios where nombre = '{0}'", usuario), "usuarios");
        }
    }
}
