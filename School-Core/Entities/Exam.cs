namespace CoreSchool.Entities {
    public class Exam : BaseSchoolObject {
        public Student Student { get; set; }
        public Assignment Assignment { get; set; }
        public float Grade { get; set; }

    }
}