using System;
using System.Collections.Generic;

namespace NotesApp.Models
{
    public class Note
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public Note()
        {
            Date = DateTime.Now;
        }
    }
}
