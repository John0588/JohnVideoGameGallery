using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VideoGameGallery.Controllers
{
    public class VideoGamesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ContentResult Detail()
        {
            return new ContentResult()
            {
                Content = "Hello, this is the Video Game Controller Page!"
            };
            
        }
    }
}
