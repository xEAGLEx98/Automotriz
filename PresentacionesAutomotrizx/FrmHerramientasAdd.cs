using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesAutomotriz;
using ManejadoresAutomotriz;
namespace PresentacionesAutomotrizx
{
    public partial class FrmHerramientasAdd : Form
    {
        ManejadoresHerramientas mh;
        public FrmHerramientasAdd()
        {
            InitializeComponent();
            mh = new ManejadoresHerramientas();
            if(FrmHerramientas.herramienta.IdHerramientas>0)
            {
                txtCodigo.Text=FrmHerramientas.herramienta.CodigoHerramienta;
                 txtNombre.Text= FrmHerramientas.herramienta.Nombre;
                 txtMedida.Text=FrmHerramientas.herramienta.Medida.ToString();
                 txtMarca.Text=FrmHerramientas.herramienta.Marca;
                 txtDescripcion.Text= FrmHerramientas.herramienta.Descripcion;
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mh.Guardar(new Herramientas(FrmHerramientas.herramienta.IdHerramientas,
                txtCodigo.Text,
                txtNombre.Text,
                int.Parse(txtMedida.Text),
                txtMarca.Text,
                txtDescripcion.Text));
            Close();
        }
    }
}
