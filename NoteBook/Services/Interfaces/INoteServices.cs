using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoteBook.Models;

namespace NoteBook.Services.Interfaces
{
    public interface INoteServices
    {
        Task Create(User user, Note note);
    }
}
