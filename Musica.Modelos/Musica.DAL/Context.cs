using Microsoft.EntityFrameworkCore;

namespace Musica.DAL
{
    public class Context : DbContext
    {
        private string _connectString;
        public Context()
        {
            _connectString = "Data Source=C:\\Users\\Usuario\\Downloads\\Proyectos - Diseño\\Proyecto Musica\\musica.db;";            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_connectString);
        }

        public DbSet<Musica.Modelos.Album> Albumes { get; set; }
        public DbSet<Musica.Modelos.Artista> Artistas { get; set; }
        public DbSet<Musica.Modelos.Cancion> Canciones { get; set; }
    }
}