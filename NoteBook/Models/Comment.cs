using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteBook.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public Note Note { get; set; }
        public Comment InReplyTo { get; set; }
        public User User { get; set; }
    }
}
