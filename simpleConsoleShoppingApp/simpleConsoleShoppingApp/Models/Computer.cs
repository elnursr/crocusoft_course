using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleConsoleShoppingApp.Models
{
    public class Computer : Product
    {
        //constructor
        public Computer(string ctrProductName, string ctrBrand, string ctrModel, double ctrPrice, double ctrCost, int ctrCount, string ctrCPU, string ctrOS) : base(ctrProductName, ctrBrand, ctrModel, ctrPrice, ctrCost, ctrCount)
        {
            this.CPU = ctrCPU;
            this.OS = ctrOS;
        }

        //fields
        public string CPU;
        public string OS;
        public bool hasGraphicCard;
    }
}