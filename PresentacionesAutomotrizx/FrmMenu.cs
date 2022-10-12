using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatosAutomotriz;
namespace PresentacionesAutomotrizx
{
    public partial class FrmMenu : Form
    {
        AccesoPermisos ap;
        public static bool[,] permisos = new bool[2,4];
        public FrmMenu()
        {
            InitializeComponent();
            ap = new AccesoPermisos();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            List<string> modulos = new List<string>();
            //modulos:
            modulos.Add("productos");
            modulos.Add("herramientas");

            var ds = ap.ExtraerPermisos(FrmLogin.IdUsuario);
            var dt = new DataTable();
            dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                permisos[i,0] = bool.Parse(dt.Rows[i]["lectura"].ToString());
                permisos[i,1] = bool.Parse(dt.Rows[i]["escritura"].ToString());
                permisos[i,2] = bool.Parse(dt.Rows[i]["actualizacion"].ToString());
                permisos[i,3] = bool.Parse(dt.Rows[i]["eliminacion"].ToString());
                //m.EvaluarLectura(permisoMostrar, modulos[i]);
            }
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            if (permisos[0, 0] == false)
                MessageBox.Show("No tienes permisos");
            else
            {
                FrmHerramientas h = new FrmHerramientas();
                h.ShowDialog();
            }
            
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (permisos[1, 0] == false)
                MessageBox.Show("No tienes permisos");
            else
            {
                FrmProductos h = new FrmProductos();
                h.ShowDialog();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
