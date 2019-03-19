using System;
namespace InternshipTest.Person
{
    public class Student
    {
        public string student_name;
        public int student_knowledge;
        public Student(string name)
        {
            //TODO: Implementation is needed
            student_name = name;
        }

        public void SetKnowledge(Knowledge knowledge)
        {
            //TODO: Implementation is needed
            student_knowledge = knowledge.knowledge_level;

        }
    }
}