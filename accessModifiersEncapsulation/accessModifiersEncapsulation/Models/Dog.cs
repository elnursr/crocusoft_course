using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessModifiersEncapsulation.Models
{
    public class Dog : Animal
    {
        //constructor
        public Dog(string ctrName, string ctrGender, string ctrBreed) : base(ctrName, ctrGender)
        {
            Name = ctrName;
            this._breed = ctrBreed;
        }

        //fields
        private string _breed;

        //properties
        public string Breed
        {
            get
            {
                return this._breed;
            }
            init
            {
                this._breed = value;
            }
        }
    }
}