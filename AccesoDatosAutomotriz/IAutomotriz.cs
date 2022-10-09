using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatosAutomotriz
{
    public interface IAutomotriz
    {
        void Guardar(dynamic entidad);
        void Borrar(dynamic entidad);
        DataSet Mostrar(string filtro);
    }
}
