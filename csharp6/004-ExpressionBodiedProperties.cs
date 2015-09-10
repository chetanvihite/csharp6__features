using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp6
{
    class ExpressionBodiedProperties
    {
        public string FirstName { get; set; } = "Chetan";
        public string LastName { get; set; } = "Vihite";
        public int Age { get; set; } = 32;

        // old way
        public string FullName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
        // new way
        public string FullNameNew() => string.Format($"{FirstName}  {LastName}");

        public override string ToString() => $"Name: {FirstName} , Age: {Age}";

    }
}
