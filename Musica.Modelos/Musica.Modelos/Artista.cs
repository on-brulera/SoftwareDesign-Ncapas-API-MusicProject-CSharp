namespace Musica.Modelos
{
    public class Artista
    {
        public int Id { get; set; } 
        public String? Nombre { get; set; }
        public String? Pais { get; set; }
        public String? Discografica { get; set; }
        
        //Relación con Album
        public List<Album>? Albumes { get; set; }
    }
}