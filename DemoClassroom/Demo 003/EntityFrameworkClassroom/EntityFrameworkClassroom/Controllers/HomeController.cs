using EntityFrameworkClassroom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkClassroom.Controllers
{
    public class HomeController : Controller
    {
        readonly PhotosDBEntities db = 
            new PhotosDBEntities(); 
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Photo);
        }
    }
}