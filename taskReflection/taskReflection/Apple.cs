using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskReflection
{
    internal class Apple : Fruit
    {
        //fields
        private int _vitaminA;
        private int _vitaminB;

        //abstract methods
        public override void getTaste()
        {
            Console.WriteLine("Tasting is apple...");
        }
    }
}