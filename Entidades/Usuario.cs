using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string RFC { get; set; }
        public string UsuarioNombre { get; set; }
        public List<Permiso> Permisos { get; set; }

        public Usuario()
        {
            Permisos = new List<Permiso>();
        }
    }
}
