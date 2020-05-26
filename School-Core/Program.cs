using System.Collections.Generic;
using CoreSchool.Entities;
using CoreSchool.Util;

namespace CoreSchool {
    class Program {
        static void Main (string[] args) {
            // Logic main
            var engine = new SchoolEngine ();
            engine.Init ();

            // Console printing
            Printer.WriteTitle ("Welcome to Net-Core School.");
            PrintSchoolCourses (engine.School);
        }

        private static void PrintSchoolCourses (School school) {
            Printer.WriteTitle ("Printing the courses of the school.");
            if (school?.Courses != null) {
                foreach (var course in school.Courses) {
                    System.Console.WriteLine ($"School: {school.Name}, ID course: {course.UniqueId}, Course Name: {course.Name}, {course.Journey}");
                }
            }
        }
    }
}