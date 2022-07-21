using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Musica.WEB.MVC.Controllers
{
    public class AlbumsController : Controller
    {
        private readonly string apiUrl = "https://localhost:5001/api/albums/";
        // GET: AlbumsController
        public ActionResult Index()
        {
            var albumes = Musica.API.Consumer.Crud<Musica.Modelos.Album>.GetAll(apiUrl);
            return View(albumes);
        }

        // GET: AlbumsController/Details/5
        public ActionResult Details(int id)
        {
            var album = API.Consumer.Crud<Modelos.Album>.GetOne(apiUrl+id);
            return View(album);
        }

        // GET: AlbumsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AlbumsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Modelos.Album album)
        {
            try
            {
                API.Consumer.Crud<Modelos.Album>.Insert(apiUrl, album);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("",ex.Message);
                return View(album);
            }
        }

        // GET: AlbumsController/Edit/5
        public ActionResult Edit(int id)
        {
            var album = API.Consumer.Crud<Modelos.Album>.GetOne(apiUrl + id);
            return View(album);
        }

        // POST: AlbumsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Modelos.Album album)
        {
            try
            {
                API.Consumer.Crud<Modelos.Album>.Update(apiUrl+id,album);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(album);
            }
        }

        // GET: AlbumsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AlbumsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Modelos.Album album)
        {
            try
            {
                API.Consumer.Crud<Modelos.Album>.Delete(apiUrl + id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(album);
            }
        }
    }
}
