namespace lambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pointStudents = new List<int> { 57, 73, 89, 97, 49, 67, 93 };
            // single line lambda expression
            Console.WriteLine($"Student point average is: {pointStudents.Average(pointStudentsAverage => pointStudentsAverage)}");

            // multi line lambda expression
            pointStudents.ForEach(pointStudent =>
            {
                if (pointStudent > 90)
                {

                    Console.WriteLine($"Student point greater than 90 is: {pointStudent}");
                }
            });
        }
    }
}