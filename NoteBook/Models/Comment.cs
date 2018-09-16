using System;
using System.Collections.Generic;

namespace NoteBook.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }


        public string UserId { get; set; }
        public User User { get; set; }

        public int NoteId { get; set; }
        public Note Note { get; set; }

        public Comment InReplyTo { get; set; }
        public List<Stats> Ratings { get; set; }
        public List<UploadedImage> Attachments { get; set; }

        public Comment()
        {
            Date = DateTime.Now;
            Ratings = new List<Stats>();
            Attachments = new List<UploadedImage>();
        }
    }
}
