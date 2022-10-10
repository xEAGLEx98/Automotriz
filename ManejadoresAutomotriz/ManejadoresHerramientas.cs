using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud;
using AccesoDatosAutomotriz;
using System.Windows.Forms;
using System.Drawing;

namespace ManejadoresAutomotriz
{
    public class ManejadoresHerramientas:IAutomotriz
    {
        AccesoHerramientas ah = new AccesoHerramientas();
        Grafica g = new Grafica();

        public void Borrar(dynamic entidad)
        {
            DialogResult dr = MessageBox.Show(String.Format("¿Estás seguro de eliminar este registro?", entidad.Nombre),
                "!INFORME", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
                ah.Borrar(entidad);
        }

        public void Guardar(dynamic entidad)
        {
            ah.Guardar(entidad);
            g.Mensaje("Registro guardado exitosamente", "!INFORME", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = ah.Mostrar(filtro).Tables["herramientas"];
            tabla.Columns.Insert(6, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(7, g.Boton("Eliminar", Color.Red));
            tabla.Columns[0].Visible = false;
        }
    }
}
