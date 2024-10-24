using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskReflection
{
    internal class Orange : Fruit
    {
        //fields
        private int _vitaminC;

        //abstract methods
        public override void getTaste()
        {
            Console.WriteLine("Tasting is orange...");
        }
    }
}