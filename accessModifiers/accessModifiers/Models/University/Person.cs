using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace accessModifiers.Models.University
{
    internal class Person
    {
        //constructor
        public Person()
        {

        }
        public Person(string ctrFirstName, string ctrLastName, byte ctrAge)
        {
            this._firstName = ctrFirstName;
            this._lastName = ctrLastName;
            this._age = ctrAge;
        }

        //fields
        private string _firstName;
        private string _lastName;
        private byte _age;

        //properties
        public string firstName { get; set; }
        public string lastName { get; set; }
        public byte Age { get; set; }
    }
}