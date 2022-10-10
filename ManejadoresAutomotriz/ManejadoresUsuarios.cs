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
    public class ManejadoresUsuarios:IAutomotriz
    {
        AccesoUsuarios au = new AccesoUsuarios();
        Grafica g = new Grafica();

        public void Borrar(dynamic entidad)
        {
            DialogResult dr = MessageBox.Show(String.Format("¿Estás seguro de eliminar este registro?", entidad.Nombre),
                "!INFORME", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
                au.Borrar(entidad);
                
        }

        public void Guardar(dynamic entidad)
        {
            au.Guardar(entidad);
            g.Mensaje("Información guardada exitosamente", "!INFORME", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = au.Mostrar(filtro).Tables["usuarios"];
            tabla.Columns.Insert(7, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(8, g.Boton("Eliminar", Color.Red));
            tabla.Columns[0].Visible = false;
        }
    }
}
