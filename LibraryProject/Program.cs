using System;
using ClassLibrary2;
using GlennUtilities;//adding the Library to the using statement means we don't need to reference it in the code.
using Console = GlennUtilities.Console;

namespace LibraryProject {

    class Program {

        static void Main(string[] args) {

            var about = StudentLive.About;//namespace of the library.variable
            Console.Print(about);


        }
    }
}
