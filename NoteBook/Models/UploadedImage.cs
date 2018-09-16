namespace NoteBook.Models
{
    public class UploadedImage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }


        public string UserId { get; set; }
        public User User { get; set; }

        public int NoteId { get; set; }
        public Note Note { get; set; }

        public int CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}