using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoteBook.Models;
using NoteBook.Services.Interfaces;
using NoteBook.Data;

namespace NoteBook.Services
{
    public class NoteServices : INoteServices
    {
        private readonly ApplicationDbContext _context;

        public NoteServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(User user, Note note)
        {
                note.User = user;

                _context.Notes.Add(note);
                await _context.SaveChangesAsync();
        }
    }
}
