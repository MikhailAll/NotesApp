using System;
using System.Collections.Generic;

namespace NoteBook.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public List<Comment> Comments { get; set; }
        public List<Stats> Ratings { get; set; }
        public List<UploadedImage> Attachments { get; set; }

        public Note()
        {
            Date = DateTime.Now;
            Comments = new List<Comment>();
            Ratings = new List<Stats>();
            Attachments = new List<UploadedImage>();
        }
    }
}
