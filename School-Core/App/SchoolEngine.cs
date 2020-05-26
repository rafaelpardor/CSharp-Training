using System.Linq;
using CoreSchool.Entities;

namespace CoreSchool {
    public sealed class SchoolEngine {
        public School School { get; set; }
        public SchoolEngine () { }
        public void Init () {
            School = new School (
                "Linux Academy", 2019, SchoolType.Online, "Estados Unidos", "Los Angeles");

            LoadCourses ();
            LoadAssigments ();

            // LoadExams ();
        }
        private void LoadAssigments () {
            foreach (var course in School.Courses) {
                System.Collections.Generic.List<Assignment> assigmentList = new System.Collections.Generic.List<Assignment> () {
                    new Assignment { Name = "Math" },
                    new Assignment { Name = "Chimestry" },
                    new Assignment { Name = "Physics" },
                    new Assignment { Name = "Computer Science" },
                    new Assignment { Name = "Art Hisotry" }
                };
                course.Assignments = assigmentList;
            }
        }
        private System.Collections.Generic.List<Student> StudentRandomGenerator (int ammount) {
            string[] firstName1 = { "Rafael", "Rick", "Morty", "Linus" };
            string[] firstname2 = { "Jose", "Alvaro", "Nicolas", "Santiago" };
            string[] lastName1 = { "Pardo", "Perez", "Soto", "Castro", "Linux" };
            string[] lastName2 = { "Rodriguez", "Diaz", "Teodoro", "Loco" };

            var studentList = from fn1 in firstName1 from fn2 in firstname2 from ln1 in lastName1 from ln2 in lastName2
            select new Student { Name = $"{fn1} {fn2} {ln1} {ln2 }" };

            return studentList.OrderBy ((st) => st.UniqueId).Take (ammount).ToList ();
        }

        private void LoadCourses () {
            School.Courses = new System.Collections.Generic.List<Course> {
                new Course { Name = "101", Journey = JourneyType.Day },
                new Course { Name = "201", Journey = JourneyType.Day },
                new Course { Name = "301", Journey = JourneyType.Day },
                new Course { Name = "102", Journey = JourneyType.Afternoon, },
                new Course { Name = "202", Journey = JourneyType.Afternoon, },
                new Course { Name = "302", Journey = JourneyType.Afternoon, },
                new Course { Name = "101", Journey = JourneyType.Night },
                new Course { Name = "201", Journey = JourneyType.Night },
                new Course { Name = "301", Journey = JourneyType.Night },
                new Course { Name = "1001", Journey = JourneyType.Complete }
            };

            System.Random rnd = new System.Random ();
            foreach (var course in School.Courses) {
                int randomAmmount = rnd.Next (20, 30);
                course.Students = StudentRandomGenerator (randomAmmount);
            }
        }

        private void LoadExams () {
            foreach (var course in School.Courses) {
                foreach (var assigment in course.Assignments) {
                    foreach (var student in course.Students) {
                        var rnd = new System.Random (System.Environment.TickCount);
                        for (int i = 0; i < 5; i++) {
                            var test = new Exam {
                                Assignment = assigment,
                                Name = $"{assigment.Name} Test#{i+1}",
                                Grade = (float) (5 * rnd.NextDouble ()),
                                Student = student
                            };
                            student.Exam.Add(test);
                        }
                    }
                }
            }
        }
    }
}