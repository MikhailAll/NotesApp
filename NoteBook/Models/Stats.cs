namespace NoteBook.Models
{
    public class Stats
    {
        public int Id { get; set; }

        public Rating Rating { get; set; }
        public bool? Rate { get; set; }


        public string UserId { get; set; }
        public User User { get; set; }

        public Note Note { get; set; }

        public int CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}