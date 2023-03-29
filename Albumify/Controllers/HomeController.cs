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
        public string AddAlbums()
        {
           var albums = new List<Album>();
            albums.Add(new Album { Name = "Nevermind", Author = "Nirvana", ReleaseDate = new DateTime(1991, 9, 24), CoverImage = "https://ecsmedia.pl/c/nevermind-remastered-b-iext123060262.jpg" });
            albums.Add(new Album { Name = "In Utero", Author = "Nirvana", ReleaseDate = new DateTime(1993, 9, 13), CoverImage = "https://ecsmedia.pl/c/in-utero-20th-anniversary-edition-b-iext122782692.jpg" });
            albums.Add(new Album { Name = "Use Your Illusion I", Author = "Guns N' Roses", ReleaseDate = new DateTime(1991, 9, 17), CoverImage = "https://ecsmedia.pl/c/use-your-illusion-i-b-iext120305172.jpg" });
            albums.Add(new Album { Name = "Bleach", Author = "Nirvana", ReleaseDate = new DateTime(1989, 6, 15), CoverImage = "https://ecsmedia.pl/c/bleach-b-iext120310380.jpg" });
            albums.Add(new Album { Name = "Hysteria", Author = "Def Leppard", ReleaseDate = new DateTime(1987, 8, 3), CoverImage = "https://ecsmedia.pl/c/hysteria-reedycja-b-iext124292915.jpg" });
            albums.Add(new Album { Name = "Disintegration", Author = "The Cure", ReleaseDate = new DateTime(1989, 5, 2), CoverImage = "https://ecsmedia.pl/c/disintegration-remastered-b-iext124368166.jpg" });
            albums.Add(new Album { Name = "Kiss Me, Kiss Me, Kiss Me", Author = "The Cure", ReleaseDate = new DateTime(1987, 5, 5), CoverImage = "https://ecsmedia.pl/c/kiss-me-kiss-me-kiss-me-b-iext120299868.jpg" });

            using (var context = new AlbumDbContext())
            {
                context.Albums.AddRange(albums);
                context.SaveChanges();
            }


                using (var context = new AlbumDbContext())
            {
                var inUteroAlbumId = 2;
                var useYourIllusionAlbumId = 3;
                var tracks = new List<Track>
                {
                    new Track { Title = "Smells Like Teen Spirit", AlbumId = 1 },
                    new Track { Title = "In Bloom", AlbumId = 1 },
                    new Track { Title = "Come as You Are", AlbumId = 1 },
                    new Track { Title = "Breed", AlbumId = 1 },
                    new Track { Title = "Lithium", AlbumId = 1 },
                    new Track { Title = "Polly", AlbumId = 1 },
                    new Track { Title = "Territorial Pissings", AlbumId = 1 },
                    new Track { Title = "Drain You", AlbumId = 1 },
                    new Track { Title = "Lounge Act", AlbumId = 1 },
                    new Track { Title = "Stay Away", AlbumId = 1 },
                    new Track { Title = "On a Plain", AlbumId = 1 },
                    new Track { Title = "Something in the Way", AlbumId = 1 },
                };
                context.Tracks.AddRange(tracks);
                context.SaveChanges();

                var inUteroTracks = new List<Track>
                {
                    new Track { Title = "Serve the Servants", AlbumId = inUteroAlbumId },
                    new Track { Title = "Scentless Apprentice", AlbumId = inUteroAlbumId },
                    new Track { Title = "Heart-Shaped Box", AlbumId = inUteroAlbumId },
                    new Track { Title = "Rape Me", AlbumId = inUteroAlbumId },
                    new Track { Title = "Frances Farmer Will Have Her Revenge on Seattle", AlbumId = inUteroAlbumId },
                    new Track { Title = "Dumb", AlbumId = inUteroAlbumId },
                    new Track { Title = "Very Ape", AlbumId = inUteroAlbumId },
                    new Track { Title = "Milk It", AlbumId = inUteroAlbumId },
                    new Track { Title = "Pennyroyal Tea", AlbumId = inUteroAlbumId },
                    new Track { Title = "Radio Friendly Unit Shifter", AlbumId = inUteroAlbumId },
                    new Track { Title = "Tourette's", AlbumId = inUteroAlbumId },
                    new Track { Title = "All Apologies", AlbumId = inUteroAlbumId }
                };

                var useYourIllusionTracks = new List<Track>
                {
                    new Track { Title = "Right Next Door to Hell", AlbumId = useYourIllusionAlbumId },
                    new Track { Title = "Dust N' Bones", AlbumId = useYourIllusionAlbumId },
                    new Track { Title = "Live and Let Die", AlbumId = useYourIllusionAlbumId },
                    new Track { Title = "Don't Cry (Original)", AlbumId = useYourIllusionAlbumId },
                    new Track { Title = "Perfect Crime", AlbumId = useYourIllusionAlbumId },
                    new Track { Title = "You Ain't the First", AlbumId = useYourIllusionAlbumId },
                    new Track { Title = "Bad Obsession", AlbumId = useYourIllusionAlbumId },
                    new Track { Title = "Back Off Bitch", AlbumId = useYourIllusionAlbumId },
                    new Track { Title = "Double Talkin' Jive", AlbumId = useYourIllusionAlbumId },
                    new Track { Title = "November Rain", AlbumId = useYourIllusionAlbumId },
                    new Track { Title = "The Garden", AlbumId = useYourIllusionAlbumId },
                    new Track { Title = "Garden of Eden", AlbumId = useYourIllusionAlbumId },
                    new Track { Title = "Don't Damn Me", AlbumId = useYourIllusionAlbumId },
                    new Track { Title = "Bad Apples", AlbumId = useYourIllusionAlbumId },
                    new Track { Title = "Dead Horse", AlbumId = useYourIllusionAlbumId },
                    new Track { Title = "Coma", AlbumId = useYourIllusionAlbumId }
                };

                context.Tracks.AddRange(inUteroTracks);
                context.Tracks.AddRange(useYourIllusionTracks);
                context.SaveChanges();
                var tracksBleach = new List<Track>
                {
                    new Track { Title = "Blew", AlbumId = 4 },
                    new Track { Title = "Floyd the Barber", AlbumId = 4 },
                    new Track { Title = "About a Girl", AlbumId = 4 },
                    new Track { Title = "School", AlbumId = 4 },
                    new Track { Title = "Love Buzz", AlbumId = 4 },
                    new Track { Title = "Paper Cuts", AlbumId = 4 },
                    new Track { Title = "Negative Creep", AlbumId = 4 },
                    new Track { Title = "Scoff", AlbumId = 4 },
                    new Track { Title = "Swap Meet", AlbumId = 4 },
                    new Track { Title = "Mr. Moustache", AlbumId = 4 },
                    new Track { Title = "Sifting", AlbumId = 4 }
                };
                context.Tracks.AddRange(tracksBleach);
                context.SaveChanges();
                var tracksHysteria = new List<Track>
                {
                    new Track { Title = "Women", AlbumId = 5 },
                    new Track { Title = "Rocket", AlbumId = 5 },
                    new Track { Title = "Animal", AlbumId = 5 },
                    new Track { Title = "Love Bites", AlbumId = 5 },
                    new Track { Title = "Pour Some Sugar on Me", AlbumId = 5 },
                    new Track { Title = "Armageddon It", AlbumId = 5 },
                    new Track { Title = "Gods of War", AlbumId = 5 },
                    new Track { Title = "Don't Shoot Shotgun", AlbumId = 5 },
                    new Track { Title = "Run Riot", AlbumId = 5 },
                    new Track { Title = "Hysteria", AlbumId = 5 },
                    new Track { Title = "Excitable", AlbumId = 5 },
                    new Track { Title = "Love and Affection", AlbumId = 5 }
                };
                context.Tracks.AddRange(tracksHysteria);
                context.SaveChanges();

                var tracksDisintegration = new List<Track>
                {
                    new Track { Title = "Plainsong", AlbumId = 6 },
                    new Track { Title = "Pictures of You", AlbumId = 6 },
                    new Track { Title = "Closedown", AlbumId = 6 },
                    new Track { Title = "Lovesong", AlbumId = 6 },
                    new Track { Title = "Last Dance", AlbumId = 6 },
                    new Track { Title = "Lullaby", AlbumId = 6 },
                    new Track { Title = "Fascination Street", AlbumId = 6 },
                    new Track { Title = "Prayers for Rain", AlbumId = 6 },
                    new Track { Title = "The Same Deep Water as You", AlbumId = 6 },
                    new Track { Title = "Disintegration", AlbumId = 6 },
                    new Track { Title = "Homesick", AlbumId = 6 },
                    new Track {Title ="Untitled",AlbumId = 6},
                };
                context.Tracks.AddRange(tracksDisintegration);
                context.SaveChanges();


                var tracksKissMe = new List<Track>
                    {
                        new Track { Title = "The Kiss", AlbumId = 7 },
                        new Track { Title = "Catch", AlbumId = 7 },
                        new Track { Title = "Torture", AlbumId = 7 },
                        new Track { Title = "If Only Tonight We Could Sleep", AlbumId = 7 },
                        new Track { Title = "Why Can't I Be You?", AlbumId = 7 },
                        new Track { Title = "How Beautiful You Are", AlbumId = 7 },
                        new Track { Title = "The Snakepit", AlbumId = 7 },
                        new Track { Title = "Just Like Heaven", AlbumId = 7 },
                        new Track { Title = "All I Want", AlbumId = 7 },
                        new Track { Title = "Hot Hot Hot!!!", AlbumId = 7 },
                        new Track { Title = "One More Time", AlbumId = 7 },
                        new Track { Title = "Like Cockatoos", AlbumId = 7 },
                        new Track { Title = "Icing Sugar", AlbumId = 7 },
                        new Track { Title = "The Perfect Girl", AlbumId = 7 },
                        new Track { Title = "A Thousand Hours", AlbumId = 7 },
                        new Track { Title = "Shiver and Shake", AlbumId = 7 },
                        new Track { Title = "Fight", AlbumId = 7 },
                        new Track { Title = "The Kiss (RS Home demo)", AlbumId = 7 },
                        new Track { Title = "The Perfect Girl (Studio demo)", AlbumId = 7 }
                    };

                context.Tracks.AddRange(tracksKissMe);
                context.SaveChanges();
            }

            return "OK";
        }
    }
}