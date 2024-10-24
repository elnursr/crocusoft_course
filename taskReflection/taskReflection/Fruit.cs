using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskReflection
{
    internal abstract class Fruit
    {
        //fields
        private string _sort;
        private double _price;

        //properties
        public string Sort
        {
            get
            {
                return this._sort;
            }
            set
            {
                this._sort = value;
            }
        }
        public double Price
        {
            get
            {
                return this._price;
            }
            set
            {
                this._price = value;
            }
        }

        //methods
        public abstract void getTaste();
        public void getInfo()
        {
            Console.WriteLine($"Price: {Price}\nSort: {Sort}");
        }
    }
}