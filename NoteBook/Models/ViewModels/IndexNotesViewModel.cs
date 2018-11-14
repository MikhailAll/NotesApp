using System.Collections.Generic;

namespace NotesApp.Models.ViewModels
{
    public class IndexNotesViewModel
    {
        public IEnumerable<Note> Notes { get; set; }
        public int? NoteId { get; set; }          
    }
}
