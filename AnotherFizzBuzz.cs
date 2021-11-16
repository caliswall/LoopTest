using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoopTest.utils;

namespace LoopTest
{
    public class AnotherFizzBuzz
    {
        internal static void FizzBuzzUsingArrays(int startNumber, int endNumber)
        {
            int[] rangeArray = Enumerable.Range(startNumber, endNumber).ToArray();
            foreach (int i in rangeArray)
            {
                var returnString = StringHelper.getFizz(i);
                returnString += StringHelper.getBuzz(i);

                Console.WriteLine(String.IsNullOrEmpty(returnString) ? i : returnString);

            }
        }

        internal static void FizzBuzzRecursion(int startNumber, int endNumber)
        {
            if (startNumber <= endNumber)
            {
                var returnString = StringHelper.getFizz(startNumber);
                returnString += StringHelper.getBuzz(startNumber);

                Console.WriteLine(String.IsNullOrEmpty(returnString) ? startNumber : returnString);
                FizzBuzzRecursion(startNumber + 1, endNumber);
            }
        }

    }
}