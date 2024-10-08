using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace simpleConsoleUniversityApp.Models
{
    public class Person
    {
        //constructor
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        //fields
        public string firstName;
        public string lastName;
        public int age;

        //methods
        public void getInfo()
        {
            Console.WriteLine($"Lastname: {lastName}\nFirstname: {firstName}\nAge: {age}");
        }
        public void getInfo(Student student)
        {
            Console.WriteLine($"Lastname: {lastName}\nFirstname: {firstName}\nAge: {age}\nPoint: {student.point}\nGroup: {student.group}");
        }
    }
}