using Microsoft.EntityFrameworkCore;
using Musica.DAL;
namespace Musica.BL
{
    public class Nomina
    {
        private readonly Musica.DAL.Context _context;

        public Nomina(Context context)
        {
            _context = context;
        }

		public Modelos.AporteImpuestos[] AportesImpuestos(int idMenorAlbum, int idMayorAlbum)
		{
			var data =  _context.Albumes
				.Where(a => a.Id >= idMenorAlbum && a.Id <= idMayorAlbum)
				.Select(a => new Modelos.AporteImpuestos
				{
					AlbumId = a.Id,
					Titulo = a.Titulo,
					Precio = a.Precio,
					AporteIva = a.Precio * 0.15,
					AportePatronal = a.Precio * 0.85
				});
			return data.ToArray();
		}

		public Modelos.Album[] BuscarAlbumes(int idArtista)
		{
			var data = _context.Albumes
				.Where(a => a.ArtistaId == idArtista);			
			return data.ToArray();
		}

		public Modelos.Cancion[] BuscarCanciones(int idAlbum)
		{
			var data = _context.Canciones
			.Where(a => a.AlbumId == idAlbum);
			return data.ToArray();
		}

	}
}