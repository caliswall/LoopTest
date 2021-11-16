using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoopTest
{
    public class SimpleForLoop
    {
        public static void SimpleFizzBang(int startNumber, int length) {
            for (int i = startNumber; i <= length; i++)
            {
                var returnString = String.Empty;
                if(i % 3 == 0) 
                {
                    returnString = "Fizz";
                }
                if(i % 5 == 0)
                {
                    returnString += "Buzz";
                }

                if(String.IsNullOrEmpty(returnString)) {
                    returnString = i.ToString();
                }

                Console.WriteLine(returnString);
            }
        }
    }
}