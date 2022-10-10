using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadoresAutomotriz
{
    public interface IAutomotriz
    {
        void Guardar(dynamic entidad);
        void Borrar(dynamic entidad);
        void Mostrar(DataGridView tabla, string filtro);
    }
}
