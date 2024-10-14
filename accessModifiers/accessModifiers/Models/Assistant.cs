using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace accessModifiers.Models
{
    internal class Assistant : Manager
    {
        //methods
        public void getFeedback(Employee employee)
        {
            if (employee.isSuccessful)
            {
                getPromotion(employee);
            }
        }
    }
}