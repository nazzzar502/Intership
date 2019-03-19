using InternshipTest.Person;

namespace InternshipTest.Institution
{
    public class University
    {
        public Student[] students = new Student[99];
        public University(string name)
        {
            //TODO: Implementation is needed  
        }

        public void AddStudent(int number, Student student)
        {
            students[number] = student;
        }

    }
}
