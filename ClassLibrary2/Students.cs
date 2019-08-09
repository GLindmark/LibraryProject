using System;
using System.Collections.Generic;

namespace ClassLibrary2
{
    public partial class Students
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Sat { get; set; }
        public double Gpa { get; set; }
        public bool IsFulltime { get; set; }
        public int? MajorId { get; set; }
        public int? CourseId { get; set; }

        public virtual Courses Course { get; set; }
        public virtual Majors Major { get; set; }
    }
}
