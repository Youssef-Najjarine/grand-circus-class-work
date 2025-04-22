namespace Day1_Student_Class_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to our student class example");
            List<int> scores = new List<int>();
            scores.Add(100);
            scores.Add(90);
            scores.Add(80);
            Student aStudent = new Student("Youssef", scores);
            Console.WriteLine($"aStudent: {aStudent}");
            aStudent.ShowStudent();
        }
    }
}
