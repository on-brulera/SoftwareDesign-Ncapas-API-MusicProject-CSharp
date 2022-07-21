using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Musica.WEB.MVC.Controllers
{
    public class CancionsController : Controller
    {
        private readonly string apiUrl = "https://localhost:5001/api/cancions/";
        // GET: CancionsController
        public ActionResult Index()
        {
            var canciones = API.Consumer.Crud<Modelos.Cancion>.GetAll(apiUrl);
            return View(canciones);
        }

        // GET: CancionsController/Details/5
        public ActionResult Details(int id)
        {
            var cancion = API.Consumer.Crud<Modelos.Cancion>.GetOne(apiUrl+id);
            return View(cancion);
        }

        // GET: CancionsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CancionsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Modelos.Cancion cancion)
        {
            try
            {
                API.Consumer.Crud<Modelos.Cancion>.Insert(apiUrl,cancion);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(cancion);
            }
        }

        // GET: CancionsController/Edit/5
        public ActionResult Edit(int id)
        {
            var cancion = API.Consumer.Crud<Modelos.Cancion>.GetOne(apiUrl + id);
            return View(cancion);
        }

        // POST: CancionsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Modelos.Cancion cancion)
        {
            try
            {
               API.Consumer.Crud<Modelos.Cancion>.Update(apiUrl + id,cancion);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(cancion);
            }
        }

        // GET: CancionsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CancionsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Modelos.Cancion cancion)
        {
            try
            {
                API.Consumer.Crud<Modelos.Cancion>.Delete(apiUrl+id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(cancion);
            }
        }
    }
}
