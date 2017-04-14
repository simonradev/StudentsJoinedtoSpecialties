namespace StudentsJoinedToSpecialties
{
    public class StudentSpeciality
    {
        public StudentSpeciality(string studentFullName, string specialityFullName, string facultyNumber)
        {
            this.StudentFullName = studentFullName;
            this.SpecialityFullName = specialityFullName;
            this.FacultyNumber = facultyNumber;
        }

        public string StudentFullName { get; set; }

        public string SpecialityFullName { get; set; }

        public string FacultyNumber { get; set; }
    }
}
