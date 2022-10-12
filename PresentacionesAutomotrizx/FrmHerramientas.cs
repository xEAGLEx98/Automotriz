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
    public partial class FrmHerramientas : Form
    {
        int columna = 0, fila = 0;
        public static Herramientas herramienta = new Herramientas(0, "", "", 0, "", "");
        ManejadoresHerramientas mh;
        public static bool[,] permisos = FrmMenu.permisos;
        public FrmHerramientas()
        {
            InitializeComponent();
            mh = new ManejadoresHerramientas();
        }

        private void dgvHerramientas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }
        void Actualizar()
        {
            mh.Mostrar(dgvHerramientas, txtBuscar.Text);
        }
        private void dgvHerramientas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            herramienta.IdHerramientas = int.Parse(dgvHerramientas.Rows[fila].Cells[0].Value.ToString());
            herramienta.CodigoHerramienta = dgvHerramientas.Rows[fila].Cells[1].Value.ToString();
            herramienta.Nombre = dgvHerramientas.Rows[fila].Cells[2].Value.ToString();
            herramienta.Medida = int.Parse(dgvHerramientas.Rows[fila].Cells[3].Value.ToString());
            herramienta.Marca = dgvHerramientas.Rows[fila].Cells[4].Value.ToString();
            herramienta.Descripcion = dgvHerramientas.Rows[fila].Cells[5].Value.ToString();
            switch (columna)
            {
                case 6: {
                        if(permisos[1, 2] == false)
                MessageBox.Show("No tienes permisos");
            else
                        {
                            FrmHerramientasAdd a = new FrmHerramientasAdd();
                            a.ShowDialog();
                            Actualizar();
                        }
                    }
                    break;
                case 7: {
                        if(permisos[1, 3] == false)
                MessageBox.Show("No tienes permisos");
            else
                        {
                            mh.Borrar(herramienta);
                            Actualizar();
                        }
                    }
                    break;
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (permisos[1, 1] == false)
                MessageBox.Show("No tienes permisos");
            else
            {
                herramienta.IdHerramientas = -1;
                FrmHerramientasAdd a = new FrmHerramientasAdd();
                a.ShowDialog();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
