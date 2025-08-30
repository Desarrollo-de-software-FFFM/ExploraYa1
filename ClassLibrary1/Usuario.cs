using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turismo.Dominio
{
    public class Usuario
    {
        public required int IdUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string NombreUsuario { get; set; }
        public string CorreoElectronico { get; set; }
        public string FotoPerfilUrl { get; set; }
        public string Rol { get; set; }
        public string Estado { get; set; }
        public List<Notificacion> ListaNotificaciones { get; set; }
        public string FrecuenciaNotificaciones { get; set; }


    }
}
