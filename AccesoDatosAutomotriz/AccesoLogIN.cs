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
        Usuarios u;
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable Login(a)
    }
}
