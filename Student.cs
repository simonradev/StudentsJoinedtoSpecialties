namespace StudentsJoinedToSpecialties
{
    public class Student
    {
        public Student(string facultyNumber, string firstName, string lastName)
        {
            this.FacultyNumber = facultyNumber;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FullName { get { return $"{this.FirstName} {this.LastName}"; } }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FacultyNumber { get; set; }
    }
}
