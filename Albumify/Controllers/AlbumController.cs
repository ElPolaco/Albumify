using Albumify.Models;
using Albumify.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Albumify.Controllers
{
    public class AlbumController : Controller
    {
        // GET: Album
        public string Index()
        {
            string res = "";
           using (var ctx=new AlbumDbContext())
            {
             foreach(var album in ctx.Albums.Where(a=>a.ReleaseDate.Year==1991))
              {
                    res+=album.Name+" by ";
                    res+=album.Author + " released in ";
                    res+=album.ReleaseDate.Year; 
                
              }   
            }
            return res;
        }

        public ActionResult ListAll()
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

            return View("Albums", vm);
        }

        public ActionResult ListByAuthor(string author)
        {
            List<Album> albums;
            using (var ctx = new AlbumDbContext())
            {
                albums = ctx.Albums.Where(a => a.Author == author).ToList();
            }
            if (albums.Count == 0)
            {
                return RedirectToAction("ListAll");
            }
            AlbumViewModel vm = new AlbumViewModel
            {
                Albums = albums
            };

            return View("Albums",vm);
        }

        public ActionResult Details(string author, string name)
        {
            Album album;
            using (var ctx = new AlbumDbContext())
            {
                album = ctx.Albums.Where(a => a.Author == author && a.Name == name).First();
            }
            List<string> tracks;
            using (var ctx= new AlbumDbContext())
            {
                tracks=ctx.Tracks.Where(t=>t.AlbumId.Equals(album.Id)).Select(t=>t.Title).ToList();
            }
            ViewData["tracks"] = tracks;
            return View("Album",album);
        }
    }
}