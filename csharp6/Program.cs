

using System;


namespace csharp6
{
   


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Order().OrderNumber);

            var consoleWriter = new StaticClassFeature();
            consoleWriter.WriteToConsole("send this to console");

            new StringInterpolation().WriteToConsole("my message to console", "high priority");
            consoleWriter.WriteToConsole( new ExpressionBodiedProperties().ToString());

            Console.ReadLine();
        }
    }
}
