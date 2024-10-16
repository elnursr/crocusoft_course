using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskInterface.Interfaces;

namespace taskInterface
{
    internal class Student : IEmail
    {
        //constructor
        public Student()
        {
            Count++;
            ID += Count;
        }

        //properties
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public static int Count { get; set; }
        public string customEmail { get; set; }

        //methods
        public void Capitalize(string word)
        {
            Console.WriteLine(word.ToUpper());
        }
        public void generateEmail()
        {
            customEmail = $"{firstName.ToLower()}.{lastName.ToLower()}{ID}@gmail.com";
            Console.WriteLine(customEmail);
        }
    }
}