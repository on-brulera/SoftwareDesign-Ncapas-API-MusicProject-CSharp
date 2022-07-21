using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica.Modelos
{
    public class Album
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Genero { get; set; }
        public double Precio { get; set; }
        public DateTime FechaLanzamiento { get; set; }

        //Clave foránea
        public int ArtistaId { get; set; }

        //Relacion con Artista
        public Artista? Artista { get; set; }

        //Relación con Cancion
        public List<Cancion>? Canciones { get; set; }
    }    
}

