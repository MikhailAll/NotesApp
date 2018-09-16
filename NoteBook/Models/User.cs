using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace NoteBook.Models
{
    public class User : IdentityUser
    {
        public UploadedImage Avatar { get; set; }
        public List<Note> Notes { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Stats> Ratings { get; set; }   

        public User()
        {
            Notes = new List<Note>();
            Comments = new List<Comment>();
            Ratings = new List<Stats>();
        }
    }
}
