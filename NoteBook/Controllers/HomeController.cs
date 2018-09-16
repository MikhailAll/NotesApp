using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NoteBook.Data;
using NoteBook.Models;
using NoteBook.Interfaces;

namespace NoteBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly INoteRepository _noteServices;

        public HomeController(ApplicationDbContext context, INoteRepository noteServices)
        {
            _context = context;
            _noteServices = noteServices;
        }

        public async Task<IActionResult> Index()
        {
            var notes = await _noteServices.Get();
            return View(notes);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
