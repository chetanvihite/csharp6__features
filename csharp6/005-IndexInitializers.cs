
using Newtonsoft.Json.Linq;


namespace csharp6
{
    class Employee__OLDWAY
    {
        public string FirstName { get; } = "Jane";
        public string LastName { get; } = "Doe";

        public JObject ToJson()
        {
            var result = new JObject();
            result["firstName"] = FirstName;
            result["lastName"] = LastName;
            return result;
        }
    }
    class Employee__CSharp6Way
    {
        public string FirstName { get; } = "Jane";
        public string LastName { get; } = "Doe";

        public JObject ToJson() => 
            new JObject() { ["firstName"] = FirstName, ["lastName"] = LastName };
        
    }
}
