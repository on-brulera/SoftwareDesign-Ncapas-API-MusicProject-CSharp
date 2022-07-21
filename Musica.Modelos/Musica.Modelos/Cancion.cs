using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica.Modelos
{
    public class Cancion
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Compositor { get; set; }
        public string? Productor { get; set; }

        //Clave foránea
        public int AlbumId { get; set; }

        //Relacion con Album
        public Album? Album { get; set; }
    }
}
