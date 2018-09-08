using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using NoteBook.Data;
using NoteBook.Models;
using Microsoft.AspNetCore.Identity;

namespace NoteBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            var currentUserId = _userManager.GetUserId(HttpContext.User);
            var currentUserNotes = _context.Notes.Where(u => u.UserId == currentUserId);
            return View(currentUserNotes as List<Note>);
        }

        [HttpPost]
        public IActionResult AddNote(Note note)
        {
            if (note!=null)
            {
                var currentUserId = _userManager.GetUserId(HttpContext.User);
                note.UserId = currentUserId;
                _context.Notes.Add(note);
                _context.SaveChanges();
                return View("Index");
            }
            return StatusCode(403);
        }
        [HttpGet]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [HttpGet]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
