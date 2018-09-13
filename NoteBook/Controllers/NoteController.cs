using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NoteBook.Controllers
{
    public class NoteController : Controller
    {
        [HttpGet]
        public IActionResult AddNote()
        {
            return View();
        }
    }
}