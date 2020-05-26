namespace CoreSchool.Entities {
    public class Course : BaseSchoolObject {
        public JourneyType Journey { get; set; }
        public System.Collections.Generic.List<Assignment> Assignments { get; set; }
        public System.Collections.Generic.List<Student> Students { get; set; }

        public override string ToString () => $"Name of the course: {Name}";

    }
}