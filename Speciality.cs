namespace StudentsJoinedToSpecialties
{
    public class Speciality
    {
        public Speciality(string firstName, string lastName, string facultyNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = facultyNumber;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get { return $"{this.FirstName} {this.LastName}"; } }

        public string FacultyNumber { get; set; }
    }
}
