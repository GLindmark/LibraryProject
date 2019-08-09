using System;
using System.Collections.Generic;

namespace ClassLibrary2
{
    public partial class Majors
    {
        public Majors()
        {
            Courses = new HashSet<Courses>();
            Students = new HashSet<Students>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int MinSat { get; set; }

        public virtual ICollection<Courses> Courses { get; set; }
        public virtual ICollection<Students> Students { get; set; }
    }
}
