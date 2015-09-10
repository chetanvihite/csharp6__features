using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp6
{
    class Employee__OLDWAYNullConditions
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee__OLDWAYNullConditions FromJson(JObject json)
        {
            if (json != null &&
                json["firstName"] != null &&
                json["firstName"].Type == JTokenType.String &&
                json["lastName"] != null &&
                json["lastName"].Type == JTokenType.String
                )

                return new Employee__OLDWAYNullConditions()
                {
                    FirstName = (string)json["firstName"],
                    LastName = (string)json["lastName"]
                };

            return null;
        }
    }
    class Employee__CSharp6WayofNullHandling
    {
        public string FirstName { get; } = "Jane";
        public string LastName { get; } = "Doe";

        public Employee__OLDWAYNullConditions FromJson(JObject json)
        {
            if (json?["firstName"]?.Type == JTokenType.String &&
                json?["lastName"]?.Type == JTokenType.String)

                return new Employee__OLDWAYNullConditions()
                {
                    FirstName = (string)json["firstName"],
                    LastName = (string)json["lastName"]
                };

            return null;
        }
    }
}
