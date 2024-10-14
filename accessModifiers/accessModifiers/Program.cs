using accessModifiers.Models;
using accessModifiers.Models.University;
using System.Collections;

namespace accessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region acces_modifiers
            //Employee john = new Employee("John");
            ////{
            ////    Salary = 255,
            ////    isSuccessful = true,
            ////};
            //john.Salary = 255;
            //john.isSuccessful = true;

            //Assistant assistant = new Assistant();

            //assistant.getFeedback(john);

            //Console.WriteLine($"Employee salary is: {john.Salary}");
            #endregion

            //Student john = new Student("John", "Doe", 25, false);
            //Student barry = new Student("Barry", "Riddell", 28, true);

            //{
            //    firstName = "John",
            //    lastName = "Doe",
            //    Age = 25,
            //    isOnline = false
            //};

            studentGroup student_group = new studentGroup("Z191");

            //student_group.getAllStudents();

            //Console.WriteLine(studentList);

            //group.getAllStudents(studentList);
        }
    }
}