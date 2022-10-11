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
                FrmProductos.producto.Nombre = txtNombre.Text;
                FrmProductos.producto.CodigoBarras = txtCodigoBarras.Text;
                FrmProductos.producto.Descripcion = txtDescripcion.Text;
                FrmProductos.producto.Marca = txtMarca.Text;

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
