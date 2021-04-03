using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Using directive has been added in order to use "Controller" base class
using System.Web.Mvc;

namespace ComicBookArtGalleryProject.Controllers
{
    //Updating class to inherit from the MVC controller base class
     public class ComicBooksController: Controller
      {
        //Action Method: Changed "Content Result" for "Action Result" in order to use the RedirectResult method..
        public ActionResult Detail()
        {

            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return Redirect("/");
            }

            return Content("Hello from our Comic Book Controller");
        }
      
      }
}