using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleConsoleShoppingApp.Models
{
    public class Phone : Product
    {
        //constructor
        public Phone(string ctrProductName, string ctrBrand, string ctrModel, double ctrPrice, double ctrCost, int ctrCount) : base(ctrProductName, ctrBrand, ctrModel, ctrPrice, ctrCost, ctrCount)
        {
            this.Balance = 0;
        }

        //fields
        public byte RAM;
        public string phoneColor = "Black";
        public double Balance;

        //methods
        public void Call(double seconds)
        {
            Balance = Balance - (seconds * 0.1);

            if (Balance < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Beep(255, 275);
                Console.WriteLine("Your balance is not enough for calling !!!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your call is succesfully");
                Console.WriteLine($"Your current balance is: {Balance}");
            }
        }

        public void increaseBalance(double money)
        {
            Balance += money;
        }
    }
}