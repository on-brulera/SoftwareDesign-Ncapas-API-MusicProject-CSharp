// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
var _context = new Musica.DAL.Context();
//AGREGAR ARTISTAS
_context.Add(new Musica.Modelos.Artista{ 
    Id = 0,
    Nombre = "POMME",
    Pais = "FRANCIA",
    Discografica = "UNIVERSAL MUSIC FRANCE"
    });
//AGREGAR ALBUM
_context.Add(new Musica.Modelos.Album
{
    Id = 0,
    Titulo = "INSPIRACION",
    Genero = "REGGAE",
    Precio = 0,
    FechaLanzamiento = DateTime.Parse("24/6/2022"),
    ArtistaId = 5
});
//Agregar Canciones

_context.Add(new Musica.Modelos.Cancion
{
    Id = 0,
    Titulo = "GRANDIOSE",
    Compositor = "ANGELE",
    Productor = "OSCAR ANTON",
    AlbumId = 1
});
_context.SaveChanges();

_context.Add(new Musica.Modelos.Artista
{
    Id = 0,
    Nombre = "DROOW",
    Pais = "CHILE",
    Discografica = "INDEPENDIENTE"
});

_context.Add(new Musica.Modelos.Artista
{
    Id = 0,
    Nombre = "AGNES OBEL",
    Pais = "ESTADOS UNIDOS",
    Discografica = "UNIVERSAL MUSIC USA"
});


_context.Add(new Musica.Modelos.Artista
{
    Id = 0,
    Nombre = "FABRIZIO PATERLINI",
    Pais = "RUSIA",
    Discografica = "PIAS INTERTAIMENT"
});

_context.Add(new Musica.Modelos.Artista
{
    Id = 0,
    Nombre = "WELLINGTON",
    Pais = "ECUADOR",
    Discografica = "INDEPENDIETE"
});

//Agregar Albumes 

_context.Add(new Musica.Modelos.Album
{
    Id = 0,
    Titulo = "A PEU PRES",
    Genero = "FOLK",
    Precio = 49.99,
    FechaLanzamiento = DateTime.Now,
    ArtistaId = 1,
});

_context.Add(new Musica.Modelos.Album
{
    Id = 0,
    Titulo = "CAVALE",
    Genero = "FOLK CHASON",
    Precio = 50.99,
    FechaLanzamiento = DateTime.Parse("20/6/2022"),
    ArtistaId = 1,
});

_context.Add(new Musica.Modelos.Album
{
    Id = 0,
    Titulo = "INFLAMABLE",
    Genero = "RAP",
    Precio = 50,
    FechaLanzamiento = DateTime.Now,
    ArtistaId = 2
});

_context.Add(new Musica.Modelos.Album
{
    Id = 0,
    Titulo = "ACA DROOW",
    Genero = "REGGAE",
    Precio = 99.99,
    FechaLanzamiento = DateTime.Parse("21/6/2022"),
    ArtistaId = 2
});

_context.Add(new Musica.Modelos.Album
{
    Id = 0,
    Titulo = "CITIZIEN",
    Genero = "FOLK",
    Precio = 0,
    FechaLanzamiento = DateTime.Now,
    ArtistaId = 3
});

_context.Add(new Musica.Modelos.Album
{
    Id = 0,
    Titulo = "AWESOME",
    Genero = "POP",
    Precio = 10.25,
    FechaLanzamiento = DateTime.Parse("21/6/2022"),
    ArtistaId = 3
});


_context.Add(new Musica.Modelos.Album
{
    Id = 0,
    Titulo = "AUTUM STORIES",
    Genero = "MINIMALISTA",
    Precio = 49.99,
    FechaLanzamiento = DateTime.Now,
    ArtistaId = 4
});

_context.Add(new Musica.Modelos.Album
{
    Id = 0,
    Titulo = "REPLIC",
    Genero = "NEO CLASICA",
    Precio = 50,
    FechaLanzamiento = DateTime.Parse("22/6/2022"),
    ArtistaId = 4
});

_context.Add(new Musica.Modelos.Album
{
    Id = 0,
    Titulo = "INEDITO",
    Genero = "POP",
    Precio = 0.99,
    FechaLanzamiento = DateTime.Now,
    ArtistaId = 5
});

_context.Add(new Musica.Modelos.Cancion
{
    Id = 0,
    Titulo = "ON BRULERA",
    Compositor = "CLAIRE",
    Productor = "OSCAR ANTON",
    AlbumId = 1
});

_context.Add(new Musica.Modelos.Cancion
{
    Id = 0,
    Titulo = "FRIO",
    Compositor = "DROOW",
    Productor = "DROOW",
    AlbumId = 3
});

_context.Add(new Musica.Modelos.Cancion
{
    Id = 0,
    Titulo = "INVIERNO",
    Compositor = "DROOW",
    Productor = "DROOW",
    AlbumId = 3
});

_context.Add(new Musica.Modelos.Cancion
{
    Id = 0,
    Titulo = "SOLEI",
    Compositor = "POMME",
    Productor = "CLAIRE",
    AlbumId = 2
});

_context.Add(new Musica.Modelos.Cancion
{
    Id = 0,
    Titulo = "ESTOY BIEN",
    Compositor = "JOSE GAHONA",
    Productor = "DROOW",
    AlbumId = 4
});

_context.Add(new Musica.Modelos.Cancion
{
    Id = 0,
    Titulo = "BROKEN SLEEP",
    Compositor = "AGNES",
    Productor = "RYAN T.K",
    AlbumId = 5
});


_context.Add(new Musica.Modelos.Cancion
{
    Id = 0,
    Titulo = "IT'S HAPPENING AGAIN",
    Compositor = "AGNES",
    Productor = "MARK BROS",
    AlbumId = 6
});

_context.Add(new Musica.Modelos.Cancion
{
    Id = 0,
    Titulo = "VELOMA",
    Compositor = "YIRUMA",
    Productor = "PATRICK LOOK",
    AlbumId = 7
});

_context.Add(new Musica.Modelos.Cancion
{
    Id = 0,
    Titulo = "BAILE I",
    Compositor = "HENRY",
    Productor = "ON_BRULERA",
    AlbumId = 10
});
Console.WriteLine("Se insertaron datos");
*/

var _context = new Musica.DAL.Context();
var nomina = new Musica.BL.Nomina(_context);

Console.WriteLine("APORTES INPUESTO\n");
var aportes = nomina.AportesImpuestos(1,5);
foreach (var alb in aportes)
{
    Console.WriteLine($"{alb.AlbumId} - {alb.Titulo} - {alb.Precio} - {alb.AporteIva} - {alb.AportePatronal}");
}

Console.WriteLine("\nBUSCAR ALBUMES\n");
var albumes = nomina.BuscarAlbumes(1);
foreach (var alb in albumes)
{
    Console.WriteLine($"{alb.ArtistaId}-{alb.Id} - {alb.Titulo} - {alb.Precio}-{alb.FechaLanzamiento}");
}

Console.WriteLine("\nAPORTES CANCIONES\n");
var canciones = nomina.BuscarCanciones(1);
foreach (var can in canciones)
{
    Console.WriteLine($"{can.AlbumId} - {can.Titulo} - {can.Productor} - {can.Compositor}");
}

//var _context = new Musica.DAL.Context();
//var nomina = new Musica.BL.Nomina(_context);
//_context.SaveChanges();
/*
var apiUrl = "https://localhost:5001/api/artistas/";
var webClient = new System.Net.WebClient();
webClient.Headers.Add("Content-Type", "application/json");
var json = webClient.DownloadString(apiUrl);

var artistas = Newtonsoft.Json.JsonConvert.DeserializeObject<Musica.Modelos.Artista[]>(json);

foreach (var art in artistas)
{ 
    Console.WriteLine($"{art.Id} - {art.Nombre} - {art.Pais} - {art.Discografica}");
}

Console.WriteLine("ALBUMES--------------");
apiUrl = "https://localhost:5001/api/albums/";
json = webClient.DownloadString(apiUrl);

var albumes = Newtonsoft.Json.JsonConvert.DeserializeObject<Musica.Modelos.Album[]>(json);

foreach (var alb in albumes)
{
    Console.WriteLine($"{alb.Id}-{alb.Titulo}-{alb.Genero}-{alb.Precio}-{alb.FechaLanzamiento} -");
}



Console.WriteLine("CANCIONES--------------");
apiUrl = "https://localhost:5001/api/Cancions/";
json = webClient.DownloadString(apiUrl);

var canciones = Newtonsoft.Json.JsonConvert.DeserializeObject<Musica.Modelos.Cancion[]>(json);

foreach (var can in canciones)
{
    Console.WriteLine($"{can.Id}-{can.Titulo}-{can.Compositor}-{can.Productor}");
}
*/

/*
var apiUrl = "https://localhost:5001/api/artistas/";
var artistas = Musica.API.Consumer.Crud<Musica.Modelos.Artista>.GetAll(apiUrl);

foreach (var art in artistas)
{
    Console.WriteLine($"{art.Id} - {art.Nombre} - {art.Pais} - {art.Discografica}");
}

Console.WriteLine("-------------------------------------");
apiUrl = "https://localhost:5001/api/albums/";
var albumes = Musica.API.Consumer.Crud<Musica.Modelos.Album>.GetAll(apiUrl);

foreach (var alb in albumes)
{
    Console.WriteLine($"{alb.Id}-{alb.Titulo}-{alb.Genero}-{alb.Precio}-{alb.FechaLanzamiento} -");
}


Console.WriteLine("-------------------------------------");
apiUrl = "https://localhost:5001/api/cancions/";
var can = Musica.API.Consumer.Crud<Musica.Modelos.Cancion>.GetOne(apiUrl+2);

    Console.WriteLine($"{can.Id}-{can.Titulo}-{can.Compositor}-{can.Productor}");

*/

Console.WriteLine("FIN DEL CODIGO");
Console.ReadKey();
