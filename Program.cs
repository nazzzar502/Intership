using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Knowledge A = new Knowledge(5);
            Knowledge B = new Knowledge(4);
            Knowledge C = new Knowledge(3);
            Knowledge D = new Knowledge(2);
            Knowledge F = new Knowledge(1);



            var s = new Student("Alex");
            University university = new University("CH.U.I.");
            // university.AddStudent(new Student("Andrew Kostenko"));
            //  university.AddStudent(new Student("Julia Veselkina"));
            // university.AddStudent(new Student("Maria Perechrest"));

            Internship internship = new Internship("Interlink");
            Console.WriteLine("List of internship's students:");
            //Console.WriteLine(internship.GetStudents());

            bool state = false;
            string name;
            string level;
            int number = 0;
            int a;
            while (state == false)
            {
                number += 1;

                Console.WriteLine("Введіть імя студента");
                name = Console.ReadLine();

                Console.WriteLine("Введіть рівень знань студента А,B,C,D,F");
                level = Console.ReadLine();

                Student student = new Student(name);

                switch (level)
                {

                    case "A":
                        student.SetKnowledge(A);

                        break;
                    case "B":
                        student.SetKnowledge(B);

                        break;
                    case "C":
                        student.SetKnowledge(C);

                        break;
                    case "D":
                        student.SetKnowledge(D);

                        break;
                    case "F":
                        student.SetKnowledge(F);

                        break;
                    default:
                        break;

                }

                university.AddStudent(number, student);

                Console.WriteLine("Продовжити? Yes/No");
                if (Console.ReadLine() == "No") { state = true; }
            }

            // Console.WriteLine(university.students[1].student_name);

            internship.GetStudents(university, number);
            Console.WriteLine("Список студентів,що пройшли");
            internship.ShowStudents();
            Console.ReadLine();


        }
    }
}
