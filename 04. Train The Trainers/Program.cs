namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();
            double sumGrades = 0;
            int presentationCount = 0;
            double averageGrade = 0;
            double sumAverageGrade = 0;
            
            while (presentationName != "Finish")
            {
                sumGrades = 0;
                for (int i = 1; i <= peopleCount; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumGrades += grade;
                }
                averageGrade += sumGrades / peopleCount;
                Console.WriteLine($"{presentationName} - {averageGrade:f2}.");
                presentationCount++;               
                presentationName = Console.ReadLine();
                sumAverageGrade += averageGrade;
                averageGrade = 0;
                
            }
            Console.WriteLine($"Student's final assessment is {sumAverageGrade / presentationCount:f2}.");
        }
    }
}
