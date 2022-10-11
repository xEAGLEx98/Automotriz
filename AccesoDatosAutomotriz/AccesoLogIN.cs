using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using EntidadesAutomotriz;
using System.Data;

namespace AccesoDatosAutomotriz
{
    public class AccesoLogIN
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable Login(Usuarios obje)
        {
            SqlCommand cmd = new SqlCommand("", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("", obje.Nombre);
            cmd.Parameters.AddWithValue("", obje.Pass);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtable1 = new DataTable();
            da.Fill(dtable1);
            return dtable1;
        }
    }
}
