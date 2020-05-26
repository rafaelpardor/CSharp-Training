namespace CoreSchool.Entities {
    public class School:BaseSchoolObject {
        public int FoundationYear { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public SchoolType SchoolType { get; set; }
        public System.Collections.Generic.List<Course> Courses { get; set; }

        public School (string name, int year) => (Name, FoundationYear) = (name, year);

        public School (string name, int year,
            SchoolType schooltype, string country = "", string city = "") {
            Name = name;
            FoundationYear = year;
            Country = country;
            City = city;
        }

        public override string ToString () {
            return $"{Name}, es de tipo {SchoolType}.\nEs de {Country}, {City}";
        }
    }
}