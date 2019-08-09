using System;
using ClassLibrary2;
//using GlennUtilities;//adding the Library to the using statement means we don't need to reference it in the code.
//using Console = GlennUtilities.Console;

namespace LibraryProject {

    class Program {

        static void Main(string[] args) {

            var live = new StudentLive(); //create an instance of the Library
            var jonsmith = live.GetStudent(222);
            if(jonsmith == null) {
                throw new Exception("Student Not Found!");
            }


            jonsmith.Firstname = "John";
            var success = live.UpdateStudent(jonsmith);


            //var students = live.ListStudents();




            //foreach (var student in students) {
            //    System.Console.WriteLine($"{student.Firstname} {student.Lastname} {student.Major?.Description}");
            //    //the "?" allows for students with a major that is null
            //}
            //var s5 = live.GetStudent(2);//if you put a find of "444", then you should get "Student not found"
            //if (s5 == null) {
            //    Console.WriteLine("Student not found!");

            //}
            //else {
            //    Console.WriteLine($"S4: {s5.Firstname} {s5.Lastname}");


            }


        
    }

}


//public Student GetStudent(int id) {
//    var s4 = Live.GetStudent(4);//if you put a find of "444", then you should get null
//    if (s4 == null) {
//        Console.WriteLine("Student not found!");

//    }
//    else {
//        Console.WriteLine($"S4: {s4.Firstname} {s4.Lastname}");// go through and change the Students to Student.


// public Student GetStudent(int id) {

//    }



//        }
//    }
//

