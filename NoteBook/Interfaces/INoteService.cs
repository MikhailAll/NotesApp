using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using NotesApp.Models;

namespace NotesApp.Interfaces
{
    public interface INoteService
    {
        Task<IEnumerable<Note>> Get(User user);
        Task<Note> Get(int id);
        Task Create(User user, Note note);
        Task Delete(int id);
        Task Update(Note note);
    }
}
