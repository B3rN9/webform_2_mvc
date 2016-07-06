using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {

            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness as <strong>Peter Parkes</strong> leaves this world :(</p>";
            ViewBag.Artists = new string[] { "Script: Dan Slott", "Pencils: Humberto Ramos", "Inks: Victor Olazaba", "Colors: Edgar Delgado", "Letters: Chris Eliopoulus" };

            return View();
        }
    }
}