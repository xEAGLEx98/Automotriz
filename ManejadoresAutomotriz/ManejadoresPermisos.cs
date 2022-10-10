using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatosAutomotriz;
namespace ManejadoresAutomotriz
{
    public class ManejadoresPermisos
    {
        AccesoPermisos ap = new AccesoPermisos();
        public void Seleccionar(dynamic entidad)
        {
            ap.SeleccionPermisos(entidad);
            MessageBox.Show("Permisos ", "!INFORME",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
