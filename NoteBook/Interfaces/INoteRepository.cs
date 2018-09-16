using System.Collections.Generic;
using System.Threading.Tasks;
using NoteBook.Models;

namespace NoteBook.Interfaces
{
    public interface INoteRepository
    {
        Task Create(User user, Note note);
        Task <List<Note>> Get();
    }
}
