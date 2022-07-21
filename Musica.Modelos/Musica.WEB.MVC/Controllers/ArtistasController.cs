using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Musica.WEB.MVC.Controllers
{
    public class ArtistasController : Controller
    {
        private readonly string apiUrl = "https://localhost:5001/api/artistas/";
        // GET: ArtistasController
        public ActionResult Index()
        {
            var artistas = Musica.API.Consumer.Crud<Musica.Modelos.Artista>.GetAll(apiUrl);
            return View(artistas);
        }

        // GET: ArtistasController/Details/5
        public ActionResult Details(int id)
        {
            var artista = API.Consumer.Crud<Modelos.Artista>.GetOne(apiUrl+id);
            return View(artista);
        }

        // GET: ArtistasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArtistasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Modelos.Artista artista)
        {
            try
            {
                API.Consumer.Crud<Modelos.Artista>.Insert(apiUrl, artista);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(artista);
            }
        }

        // GET: ArtistasController/Edit/5
        public ActionResult Edit(int id)
        {
            var artista = Musica.API.Consumer.Crud<Musica.Modelos.Artista>.GetOne(apiUrl + id);
            return View(artista);
        }

        // POST: ArtistasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Modelos.Artista artista)
        {
            try
            {
                API.Consumer.Crud<Modelos.Artista>.Update(apiUrl + id, artista);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(artista);
            }
        }

        // GET: ArtistasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ArtistasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Modelos.Artista artista)
        {
            try
            {
                API.Consumer.Crud<Modelos.Artista>.Delete(apiUrl+id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(artista);
            }
        }
    }
}
