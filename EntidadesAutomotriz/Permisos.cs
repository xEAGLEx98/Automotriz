using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAutomotriz
{
    public class Permisos
    {
        public Permisos(int fkIdUsuario, int seleccion, bool lectura, bool escritura, bool eliminacion, bool actualizacion)
        {
            FkIdUsuario = fkIdUsuario;
            Seleccion = seleccion;
            Lectura = lectura;
            Escritura = escritura;
            Eliminacion = eliminacion;
            Actualizacion = actualizacion;
        }

        public int FkIdUsuario { get; set; }
        public int Seleccion { get; set; }
        public bool Lectura { get; set; }
        public bool Escritura { get; set; }
        public bool Eliminacion { get; set; }
        public bool Actualizacion { get; set; }
    }
}
