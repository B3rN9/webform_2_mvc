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
            if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                //return new RedirectResult("/");
                return Redirect("/");
            }

            return Content("Hello from the otherside");
            //return new ContentResult()
            //{
            //    Content = "Hello from the otherside"
            //};
        }
    }
}