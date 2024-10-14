using Polymorphism;

namespace polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle bmw = new Car()
            {
                brandName = "BMW",
                Model = "M5 Competition",
                Color = "Black",
                isElectric = false,
                Distance = 115,
                Time = 2
            };
            //bmw.brandName = "BMW";
            //bmw.Model = "M5 Competition";
            //bmw.Color = "Black";
            //bmw.isElectric = false;
            //bmw.Distance = 115;
            //bmw.Time = 2;

            Vehicle landRover = new Car()
            {
                brandName = "Land Rover",
                Model = "Range Rover Sport",
                Color = "Magenta",
                isElectric = false,
                Distance = 217,
                Time = 3
            };

            Vehicle tesla = new Car()
            {
                brandName = "Tesla",
                Model = "Model X",
                Color = "Dark Gray",
                isElectric = true,
                Distance = 345,
                Time = 5
            };

            Vehicle ibis = new Bicycle()
            {
                brandName = "Ibis",
                Model = "Ripmo V2 XT Review",
                Color = "Gray",
                Distance = 59,
                Time = 7
            };

            Vehicle bmx = new Bicycle()
            {
                brandName = "BMX",
                Model = "Huch Pro Star",
                Color = "White",
                Distance = 47,
                Time = 5
            };

            Vehicle[] vehicleList = new[] { bmw, landRover, tesla, ibis, bmx };

            for (int i = 0; i < vehicleList.Length; i++)
            {
                Console.WriteLine("*******-------*******");
                vehicleList[i].getInfo();
                vehicleList[i].getAverageSpeed();
                vehicleList[i].defineNatureHarmness();
                Console.WriteLine(vehicleList[i].productionDate);
            }
        }
    }
}