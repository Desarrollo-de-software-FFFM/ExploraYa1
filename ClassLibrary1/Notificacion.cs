using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turismo.Dominio
{
    public class Notificacion
    {
        public required string Titulo { get; set; }
        public string Descripcion { get; set; }
        public required EstadoNotificacion Estado { get; set; }
    }

    public enum EstadoNotificacion
    {
        Leida,
        NoLeida
    }
}
