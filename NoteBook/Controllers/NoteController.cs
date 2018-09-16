using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NoteBook.Data;
using NoteBook.Models;
using NoteBook.Interfaces;

namespace NoteBook.Controllers
{
    public class NoteController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly INoteRepository _noteServices;

        public NoteController(ApplicationDbContext context, UserManager<User> userManager, INoteRepository noteServices)
        {
            _context = context;
            _userManager = userManager;
            _noteServices = noteServices;
        }

        [HttpGet]
        public IActionResult AddNote()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddNote(Note note)
        {
            await _noteServices.Create(await _userManager.GetUserAsync(HttpContext.User), note);
            return View();
        }
    }
}