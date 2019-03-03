using System.Collections.Generic;

namespace Handicard.Models
{
    public class Course
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Hole> Holes { get; set; }
    }
}
