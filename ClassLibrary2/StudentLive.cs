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

            //    }

            //    }

        }
    }
}
