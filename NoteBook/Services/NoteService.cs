using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.DotNet.PlatformAbstractions;
using NotesApp.Models;
using NotesApp.Data;
using Microsoft.EntityFrameworkCore;
using NotesApp.Interfaces;

namespace NotesApp.Services
{
    public class NoteService : INoteService
    {
        private readonly ApplicationDbContext _context;     

        public NoteService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Note>> Get(User user)
        {
            var result = await _context.Notes
                .Where(note => note.User == user)
                .ToListAsync();
            return result;
        }

        public async Task<Note> Get(int id)
        {
            return await _context.Notes.FindAsync(id);
        }

        public async Task Create(User user, Note note)
        {
            if (note != null)
            {
                note.User = user;
                await _context.Notes.AddAsync(note);
                await _context.SaveChangesAsync();
            }
        }

        public async Task Update(Note note)
        {
            _context.Notes.Update(note);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            _context.Notes.Remove(
                _context.Notes.Find(id));
            await _context.SaveChangesAsync();
        }
    }
}