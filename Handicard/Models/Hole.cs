namespace Handicard.Models
{
    public class Hole
    {
        public long Id { get; set; }
        public long CourseId { get; set; }
        public int HoleNumber { get; set; }
        public int Par { get; set; }
        public int StrokeIndex { get; set; }
    }
}
