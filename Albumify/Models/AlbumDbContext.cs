using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Albumify.Models
{
    public class AlbumDbContext: DbContext
    {
        public AlbumDbContext() : base("name=AlbumDbConnection")
        {
           
        }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }
    }
}