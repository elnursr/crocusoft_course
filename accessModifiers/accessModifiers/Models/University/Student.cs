using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace accessModifiers.Models.University
{
    internal class Student : Person
    {
        //constructor
        public Student(string ctrFirstName, string ctrLastName, byte ctrAge, bool ctrIsOnline) : base(ctrFirstName, ctrLastName, ctrAge)
        {
            firstName = ctrFirstName;
            lastName = ctrLastName;
            Age = ctrAge;
            isOnline = ctrIsOnline;
        }

        //fields
        private bool _isOnline;

        //properties
        public bool isOnline { get; set; }
    }
}