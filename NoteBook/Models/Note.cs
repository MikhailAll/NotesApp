using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;

namespace NoteBook.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public User User { get; set; }
        public List<Comment> Comments { get; set; }

        public Note()
        {
            Date = DateTime.Now;
            Comments = new List<Comment>();
        }
    }
}
