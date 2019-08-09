using System;
using System.Collections.Generic;

namespace ClassLibrary2
{
    public partial class Courses
    {
        public Courses()
        {
            Students = new HashSet<Students>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Instructor { get; set; }
        public int Credit { get; set; }
        public int? MajorId { get; set; }

        public virtual Majors Major { get; set; }
        public virtual ICollection<Students> Students { get; set; }
    }
}
