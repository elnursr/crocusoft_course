using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskReflection
{
    internal class Pinapple : Fruit
    {
        //fields
        private int _vitaminE;
        private int _vitaminD;

        //abstract methods
        public override void getTaste()
        {
            Console.WriteLine("Tasting is pinapple...");
        }
    }
}