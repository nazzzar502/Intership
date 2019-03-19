using InternshipTest.Person;
using System;
namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        public Student[] interns = new Student[99];
        int knowledge_sum = 0;

        public Internship(string name)
        {
            //TODO: Implementation is needed      
        }

        int count = 0;
        public void GetStudents(University university, int number)
        {
            foreach (Student i in university.students)
            {
                if (i != null) { knowledge_sum = knowledge_sum + i.student_knowledge; }

            }
            knowledge_sum = knowledge_sum / number;



            foreach (Student i in university.students)
            {
                count++;
                if (i != null)
                {
                    if (i.student_knowledge > knowledge_sum)
                    {
                        interns[count] = i;
                    }
                }



            }

        }

        public void ShowStudents()
        {
            foreach (Student i in interns)
            {
                if (i != null)
                {
                    Console.WriteLine(i.student_name);
                    Console.WriteLine(i.student_knowledge);
                }

            }
        }
    }
}
