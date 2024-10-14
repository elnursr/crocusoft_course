using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Polymorphism
{
    internal class Bicycle : Vehicle
    {
        //properties
        public string Type { get; set; }

        //methods
        public override void defineNatureHarmness()
        {
            Console.WriteLine($"Nature harmness is none");
        }
    }
}