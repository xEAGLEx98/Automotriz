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
    public partial class FrmProductos : Form
    {
        int columna = 0, fila = 0;
        public static Productos producto = new Productos(0, "", "", "", "");
        ManejadoresProductos mp;
        public static bool[,] permisos = FrmMenu.permisos;
        public FrmProductos()
        {
            InitializeComponent();
            mp = new ManejadoresProductos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        void Actualizar()
        {
            mp.Mostrar(dgvProductos, txtBuscar.Text);
        }
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            producto.IdProductos = int.Parse(dgvProductos.Rows[fila].Cells[0].Value.ToString());
            producto.CodigoBarras = dgvProductos.Rows[fila].Cells[1].Value.ToString();
            producto.Nombre = dgvProductos.Rows[fila].Cells[2].Value.ToString();
            producto.Descripcion = dgvProductos.Rows[fila].Cells[3].Value.ToString();
            producto.Marca = dgvProductos.Rows[fila].Cells[4].Value.ToString();
            switch (columna)
            {
                case 5: {
                        if (permisos[0, 2] == false)
                            MessageBox.Show("No tienes permisos");
                        else
                        {
                            FrmProductosAdd a = new FrmProductosAdd();
                            a.ShowDialog();
                            Actualizar();
                        }
                        
                    }break;
                case 6: {
                        if (permisos[0, 3] == false)
                            MessageBox.Show("No tienes permisos");
                        else
                        {
                            mp.Borrar(producto);
                            Actualizar();
                        }
                        
                    }break;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (permisos[0, 1] == false)
                MessageBox.Show("No tienes permisos");
            else
            {
                producto.IdProductos = -1;
                FrmProductosAdd a = new FrmProductosAdd();
                a.ShowDialog();
            }
                
          
            

        }

        private void dgvProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }
    }
}
