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
        //Action Method.. 
        public string Detail ()
        {
            return "Hello from our Comic Book Controller. Test";
        }
      
      }
}