using Albumify.Models;
using Albumify.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Albumify.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Album> albums;
            using (var ctx = new AlbumDbContext())
            {
                albums = ctx.Albums.ToList();
            }
            AlbumViewModel vm = new AlbumViewModel
            {
                Albums = albums
            };

            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Wszystkie albumy w jednym miejscu!";

            return View();
        }
        public ActionResult Authors()
        {
            List<string> authors;
            using (var ctx = new AlbumDbContext())
            {
                authors=ctx.Albums.Select(a=>a.Author).Distinct().ToList();
            }
            ViewData["authors"] = authors;
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Skontaktuj się z nami!";

            return View();
        }
    }
}