using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace NotesApp.Models
{
    public class User : IdentityUser
    {
        public List<Note> Notes { get; set; }

        public User()
        {
            Notes = new List<Note>();
        }
    }
}
