using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskInterface.Interfaces
{
    internal interface IEmail
    {
        //properties
        public string customEmail { get; set; }

        //methods
        public void generateEmail();
    }
}