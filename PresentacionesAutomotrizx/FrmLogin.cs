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
    public partial class FrmLogin : Form
    {
        AccesoUsuarios au;
        public static int IdUsuario;
        public static string Password;
        public static string usuario;
        public FrmLogin()
        {
            InitializeComponent();
            au = new AccesoUsuarios();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var ds = au.Login(txtUsuario.Text);
            var ds1 = au.Login(txtContraseña.Text);
            var dt = new DataTable();
            //var dt2 = new DataTable();
            dt = ds.Tables[0];
            //dt2 = ds1.Tables[0];
            IdUsuario = int.Parse(dt.Rows[0]["idusuario"].ToString());
            //Password = dt2.Rows[1]["pass"].ToString();
            usuario = dt.Rows[0]["nombre"].ToString();
            if (usuario == txtUsuario.Text)
            {
               
               
                    MessageBox.Show("Bienvenido: " + txtUsuario.Text);
                    FrmMenu frm = new FrmMenu();
                    frm.ShowDialog();
                    Close();
               
            }
        }
    }
}
