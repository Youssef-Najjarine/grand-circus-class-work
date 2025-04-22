using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Student_Class_Example
{
    public class Student
    {
        private string studentName;
        private List<int> testScores;

        public Student(string name, List<int> scores)
        {
            studentName = name;
            testScores = scores;
        }
        public void ShowStudent()
        {
            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("Scores: ");
            foreach (int score in testScores)
            {
                Console.WriteLine(score);
            }
        }
    }
}
