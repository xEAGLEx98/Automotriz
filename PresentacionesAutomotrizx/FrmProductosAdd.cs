using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManejadoresAutomotriz;
using EntidadesAutomotriz;
namespace PresentacionesAutomotrizx
{
    public partial class FrmProductosAdd : Form
    {
        ManejadoresProductos mp;
        public FrmProductosAdd()
        {
            InitializeComponent();
            mp = new ManejadoresProductos();
            if(FrmProductos.producto.IdProductos>0)
            {
                txtNombre.Text= FrmProductos.producto.Nombre;
                txtCodigoBarras.Text=FrmProductos.producto.CodigoBarras;
                 txtDescripcion.Text=FrmProductos.producto.Descripcion;
                 txtMarca.Text=FrmProductos.producto.Marca;

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mp.Guardar(new Productos(FrmProductos.producto.IdProductos,
                txtCodigoBarras.Text,
                txtNombre.Text,
                txtDescripcion.Text,
                txtMarca.Text));
            Close();
        }
    }
}
