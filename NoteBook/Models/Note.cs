using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NoteBook.Models
{
    public class Note
    {
        public int Id { get; set; }
        //public string Header { get; set; }
        public string Text { get; set; }

        public ApplicationUser User { get; set; }
    }
}
