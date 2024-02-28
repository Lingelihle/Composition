using System;

namespace Composition
{
    public class Logger 
    // composotion has its own Logger syntax 
    {
        public void Log(string message) // create a method 
        {
            Console.WriteLine(message);
        }
    }
}
// we start here by naming the commonalities needed