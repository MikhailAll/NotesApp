namespace NoteBook.Models
{
    public class Rating
    {
        public int Id { get; set; }

        public int StatsId { get; set; }
        public Stats Stats { get; set; }
    }
}
