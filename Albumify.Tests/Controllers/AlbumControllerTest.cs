using Albumify;
using Albumify.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Albumify.Tests.Controllers
{
    [TestClass]
    public class AlbumControllerTest
    {
        [TestMethod]
        public void ListAll()
        {
            AlbumController ctr = new AlbumController();
            ViewResult v = ctr.ListAll() as ViewResult;

            Assert.IsNotNull(v);
        }
        [TestMethod]
        public void ListByAuthor()
        {
            AlbumController ctr = new AlbumController();
            ViewResult v = ctr.ListByAuthor("Nirvana") as ViewResult;

            Assert.IsNotNull(v);
        }
        [TestMethod]
        public void Details()
        {
            AlbumController ctr = new AlbumController();
            ViewResult v = ctr.Details("Nirvana","Nevermind") as ViewResult;

            Assert.IsNotNull(v);
        }
    }
}
