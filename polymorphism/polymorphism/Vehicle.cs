using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Polymorphism
{
    internal abstract class Vehicle
    {
        //constructor
        protected Vehicle()
        {
            productionDate = DateTime.Now;
        }

        //fields
        private double _distance;
        private double _time;

        //properties
        public string brandName { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Distance
        {
            get
            {
                return this._distance;
            }
            set
            {
                this._distance = value;
            }
        }
        public double Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
            }
        }
        public readonly DateTime productionDate;

        //methods
        public virtual void getInfo()
        {
            Console.WriteLine($"Name: {brandName}\nModel: {Model}\nColor: {Color}");
        }
        public void getAverageSpeed()
        {
            double averageSpeed = Math.Round(Distance / Time, 2);
            Console.WriteLine($"Average speed is: {averageSpeed} km/h");
        }
        public abstract void defineNatureHarmness();
        public virtual string ToString()
        {
            return $"Name: {brandName}\nModel: {Model}";
        }
    }
}