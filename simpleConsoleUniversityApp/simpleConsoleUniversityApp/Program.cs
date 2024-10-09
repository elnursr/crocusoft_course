using simpleConsoleUniversityApp.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person = new Person("John", "Doe", 27);

        Student student = new Student("Arif", "Abdulla", 22, 63, "B8");

        person.getInfo();

        student.getInfo(student);

        //student.getDegree(91);

        student.checkGradiuation();
    }
}