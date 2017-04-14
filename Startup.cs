namespace StudentsJoinedToSpecialties
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Startup
    {
        public static void Main()
        {
            List<Speciality> specialities = new List<Speciality>();
            specialities = ReadInputsUntillKeywordIsReceived(
                                                        specialities, 
                                                        "Students:", 
                                                        arr => new Speciality(arr[0], arr[1], arr[2]));

            List<Student> students = new List<Student>();
            students = ReadInputsUntillKeywordIsReceived(
                                                        students, 
                                                        "END", 
                                                        arr => new Student(arr[0], arr[1], arr[2]));

            List<StudentSpeciality> studentsSpecialities = specialities.Join(students, 
                                                           sp => sp.FacultyNumber, 
                                                           st => st.FacultyNumber, 
                                                           (speciality, student) => 
                                                           new StudentSpeciality(student.FullName, 
                                                                                 speciality.FullName, 
                                                                                 speciality.FacultyNumber))
                                                                                 .ToList();

            PrintResult(studentsSpecialities);
        }

        private static void PrintResult(List<StudentSpeciality> studentsSpecialities)
        {
            StringBuilder result = new StringBuilder();
            foreach (StudentSpeciality  studentSpeciality in studentsSpecialities
                                                                .OrderBy(stsp => stsp.StudentFullName))
            {
                result.AppendLine(
                    $"{studentSpeciality.StudentFullName} {studentSpeciality.FacultyNumber} {studentSpeciality.SpecialityFullName}");
            }

            Console.Write(result.ToString());
        }

        private static List<TType> ReadInputsUntillKeywordIsReceived<TType>(List<TType> list, 
                                                                            string keyWord, 
                                                                            Func<string[], TType> func)
        {
            string inputLine = Console.ReadLine();
            while (inputLine != keyWord)
            {
                string[] classInfo = SplitString(inputLine, ' ');

                TType toAdd = func(classInfo);

                list.Add(toAdd);

                inputLine = Console.ReadLine();
            }

            return list;
        }

        public static string[] SplitString(string toSplit, char toSplitBy)
        {
            return toSplit.Split(new[] { toSplitBy }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
