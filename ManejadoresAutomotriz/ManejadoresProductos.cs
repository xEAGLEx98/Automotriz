using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatosAutomotriz;
using Crud;
namespace ManejadoresAutomotriz
{
    public class ManejadoresProductos:IAutomotriz
    {
        Grafica g = new Grafica();
        AccesoProductos ap = new AccesoProductos();

        public void Borrar(dynamic entidad)
        {
            DialogResult dr = MessageBox.Show(String.Format("¿Estás seguro de eliminar este registro?",
               entidad.Nombre), "!ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
                ap.Borrar(entidad);
        }

        public void Guardar(dynamic entidad)
        {
            ap.Guardar(entidad);
            g.Mensaje("Información guardada exitosamente", "!INFORME", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = ap.Mostrar(filtro).Tables["productos"];
            tabla.Columns.Insert(5, g.Boton("Editar", Color.DarkSeaGreen));
            tabla.Columns.Insert(6, g.Boton("Eliminar", Color.DarkRed));
            tabla.Columns[0].Visible = false;
        }
    }
}
