using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace accessModifiers.Models
{
    internal class Employee : Manager
    {
        public Employee(string ctrName)
        {
            this._name = ctrName;
        }

        //fields
        private string _name;
        private decimal _salary;
        private bool _isSuccessful;

        //properties
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        public decimal Salary { get; set; }
        public bool isSuccessful { get; set; }
    }
}