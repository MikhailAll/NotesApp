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
using NoteBook.Services.Interfaces;

namespace NoteBook.Controllers
{
    public class NoteController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly INoteServices _noteServices;

        public NoteController(ApplicationDbContext context, UserManager<User> userManager, INoteServices noteServices)
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