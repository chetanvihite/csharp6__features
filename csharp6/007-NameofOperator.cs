using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp6
{
    public class Employee
    {

    }
    class NameOfOperatorFeature
    {
        public void Add(Employee employee)
        {
            if (employee == null)
                throw new ArgumentNullException("Employee");
        }

        //improved version
        public void AddImproved(Employee employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(Employee));
        }


    }
}
