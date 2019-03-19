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

            Console.WriteLine("Load students from file? Yes/No");
            if(Console.ReadLine() == "Yes") {
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
            }
            else
            {
               Student Ane = new Student("Ane");
                Ane.SetKnowledge(A);
                Student Jane = new Student("Jane");
                Jane.SetKnowledge(B);
                Student Michael = new Student("Michael");
                Michael.SetKnowledge(D);
                Student Andrew = new Student("Andrew");
                Andrew.SetKnowledge(A);
                Student Bill = new Student("Bill");
                Bill.SetKnowledge(C);

                
                university.students = new Student[] { Ane, Andrew, Jane, Michael, Bill };
                number = 5;
            }
            // Console.WriteLine(university.students[1].student_name);

            internship.GetStudents(university, number);
            Console.WriteLine("Список студентів,що пройшли");
            internship.ShowStudents();
            Console.ReadLine();


        }
    }
}
