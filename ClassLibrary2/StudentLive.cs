using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary2 {

    public class StudentLive {

        public static string About = "About StudentLib";//create a string we can access.  Must be public


        public List<Students> ListStudents() {
            var db = new AppEfdbContext();//db created
            return db.Students.ToList();//returns a list of the students
        }

        public Students GetStudent(int id) {
            var db = new AppEfdbContext();
            return db.Students.Find(id);

        }
        public bool UpdateStudent(Students s) {
            var db = new AppEfdbContext();
            var sDB = GetStudent(s.Id);
            if (sDB == null) {
                throw new Exception("Student annot be found!");
            }
            sDB.Firstname = s.Firstname;
            sDB.Lastname = s.Lastname;
            sDB.Gpa = s.Gpa;
            sDB.Sat = s.Sat;
            sDB.IsFulltime = s.IsFulltime;
            sDB.MajorId = s.MajorId;
            var major = db.Majors.Find(s.MajorId);
            if(major == null) {
                return false;
            }
            //db.Update<Students>(sDB);  This does the same as the line below
            db.Students.Update(sDB);
            db.SaveChanges();
            return true;

        }
    }
}
