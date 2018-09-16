using System.Collections.Generic;
using System.Threading.Tasks;
using NoteBook.Models;
using NoteBook.Data;
using Microsoft.EntityFrameworkCore;
using NoteBook.Interfaces;

namespace NoteBook.Services
{
    public class NoteServices : INoteRepository
    {
        private readonly ApplicationDbContext _context;

        public NoteServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(User user, Note note)
        {
            note.User = user;

                await _context.Notes.AddAsync(note);
                await _context.SaveChangesAsync();
            
        }

        public async Task<List<Note>> Get()
        {
            return await _context.Notes
                .Include(note => note.User)
                .ToListAsync();
        }
    }
}
