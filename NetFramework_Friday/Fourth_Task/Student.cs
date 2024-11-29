namespace NetFramework_Friday.Fourth_Task
{
    public class InvalidStudentDataException : Exception
    {
        public InvalidStudentDataException(string message) : base(message) { }
    }

    internal struct Students
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }
    internal class Student
    {
        List<Students> students = new List<Students>();

        public void AddStudent(string name, int age)
        {
            try
            {
                if (age < 0 || age > 100) throw new InvalidStudentDataException("The unacceptable age of the student");

                Students newStudent = new Students { Name = name, Age = age };
                students.Add(newStudent);
            }
            catch (InvalidStudentDataException StudentException)
            {
                Console.WriteLine(StudentException.Message);
            }
        }

    }
}
