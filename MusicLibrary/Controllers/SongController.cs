﻿using Microsoft.AspNetCore.Mvc;

namespace MusicLibrary.Controllers
{
    public class SongController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
