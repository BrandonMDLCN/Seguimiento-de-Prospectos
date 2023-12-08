using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguimiento_De_Prospectos
{
    public class P_Prospectos
    {
        public string Nombre_pro { get; set; }
        public string ApellidoP_Pro { get; set; }
        public string ApellidoM_Pro { get; set; }
        public string Calle_Pro { get; set; }
        public int Numero_Pro { get; set; }
        public string Colonia_Pro { get; set; }
        public int Cp_Pro { get; set; }
        public string Telefono { get; set; }
        public string RFC_Pro { get; set; }
        public string Estatus_Pro { get; set; }

        public string Observaciones_Pro { get; set; }

        public byte[] Archivo_pro { get; set; }

        public string NombreArchivo_pro { get; set; }
    }
}
