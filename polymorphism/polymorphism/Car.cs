using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Polymorphism
{
    internal class Car : Vehicle
    {
        //fields
        private bool _isElectric;

        //properties
        public byte doorCount { get; set; }
        public bool isElectric
        {
            get
            {
                return _isElectric;
            }
            set
            {
                _isElectric = value;
            }
        }

        //methods
        public override void defineNatureHarmness()
        {
            if (isElectric)
            {
                Console.WriteLine($"Nature harmness is low");
            }
            else
            {
                Console.WriteLine($"Nature harmness is high");
            }
        }
    }
}