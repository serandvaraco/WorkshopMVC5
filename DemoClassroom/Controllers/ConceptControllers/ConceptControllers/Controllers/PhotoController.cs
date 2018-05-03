using ConceptControllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ConceptControllers.Controllers
{
    public class PhotoController : Controller
    {

        private static IList<Photo> model =
            new List<Photo>
            {
                new Photo { Id=1, Name="Photo 1" },
                new Photo { Id=2, Name="Photo 2" },
                new Photo { Id=3, Name="Photo 3" },
                new Photo { Id=4, Name="Photo 4" },
                new Photo { Id=5, Name="Photo 5" }

            };

        // GET: Photo
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.PhotoTitle = "Listado de Fotos";
            return View(model);
        }

        public ActionResult Create() => View();

        [HttpPost]
        public ActionResult Create(Photo photo)
        {

            if (ModelState.IsValid)
            {
                model.Add(photo);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult GetPhotos(int take, string name) =>
            Json(model.Where(x => x.Name.Contains(name)).Take(take));
    }
}