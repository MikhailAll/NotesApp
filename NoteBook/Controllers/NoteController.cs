using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NotesApp.Data;
using NotesApp.Models;
using NotesApp.Interfaces;
using NotesApp.Models.ViewModels;


namespace NotesApp.Controllers
{
    public class NoteController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly INoteService _noteServices;

        public NoteController(ApplicationDbContext context, UserManager<User> userManager, INoteService noteServices)
        {
            _context = context;
            _userManager = userManager;
            _noteServices = noteServices;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            IndexNotesViewModel viewModel = new IndexNotesViewModel()
            {
                NoteId = null,
                Notes = await _noteServices.Get(
                    await _userManager.GetUserAsync(HttpContext.User))
            };
            return View(viewModel);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(Note note)
        {
            await _noteServices.Create(
                await _userManager.GetUserAsync(HttpContext.User), note);
            return RedirectToAction("Index", "Note");
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Delete(IndexNotesViewModel viewModel)
        {
            if (viewModel.NoteId != null)
                await _noteServices.Delete(viewModel.NoteId.Value);
            return RedirectToAction("Index", "Note");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Update(IndexNotesViewModel viewModel)
        {
            if (viewModel.NoteId != null)
            {
                var note = await _noteServices.Get(viewModel.NoteId.Value);
                return View(note);
            }

            return RedirectToAction("Index", "Note");
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Update(Note note)
        {
            if (note != null)
            {
                note.User = await _userManager.GetUserAsync(
                    HttpContext.User);
                await _noteServices.Update(note);
            }

            return RedirectToAction("Index", "Note");
        }
    }
}