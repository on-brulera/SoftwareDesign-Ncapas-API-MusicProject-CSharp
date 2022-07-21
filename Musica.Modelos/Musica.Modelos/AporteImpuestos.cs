using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica.Modelos
{
    public class AporteImpuestos
    {
        public int AlbumId { get; set; }
        public string? Titulo { get; set; }
        public double Precio { get; set; }
        public double AporteIva { get; set; }
        public double AportePatronal { get; set; }
    }
}
