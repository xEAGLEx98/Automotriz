using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAutomotriz
{
    public class Usuarios
    {
        public Usuarios(int idUsuarios, string nombre, string apellidoP, string apellidoM, DateTime fDN, string rFC, string pass)
        {
            IdUsuarios = idUsuarios;
            Nombre = nombre;
            ApellidoP = apellidoP;
            ApellidoM = apellidoM;
            FDN = fDN;
            RFC = rFC;
            Pass = pass;
        }

        public int IdUsuarios { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public DateTime FDN { get; set; }
        public string RFC { get; set; }
        public string Pass { get; set; }
    }
}
