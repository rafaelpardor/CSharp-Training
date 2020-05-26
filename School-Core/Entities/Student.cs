namespace CoreSchool.Entities {
    public class Student : BaseSchoolObject {
        public System.Collections.Generic.List<Exam> Exam { get; set; } = new System.Collections.Generic.List<Exam> ();

    }
}