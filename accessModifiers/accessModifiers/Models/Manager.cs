using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace accessModifiers.Models
{
    internal class Manager
    {
        //methods
        protected Employee getPromotion(Employee employee)
        {
            employee.Salary += 100;
            return employee;
        }
    }
}