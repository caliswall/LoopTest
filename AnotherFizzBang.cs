using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoopTest.utils;

namespace LoopTest
{
    public class AnotherFizzBang
    {
        internal static void FizzBangUsingArrays(int startNumber, int endNumber)
        {
            int[] rangeArray = Enumerable.Range(startNumber, endNumber).ToArray();
            foreach (int i in rangeArray)
            {
                var returnString = StringHelper.getFizz(i);
                returnString += StringHelper.getBang(i);

                Console.WriteLine(String.IsNullOrEmpty(returnString) ? i : returnString);

            }
        }

        internal static void FizzBangRecursion(int startNumber, int endNumber)
        {
            if (startNumber <= endNumber)
            {
                var returnString = StringHelper.getFizz(startNumber);
                returnString += StringHelper.getBang(startNumber);

                Console.WriteLine(String.IsNullOrEmpty(returnString) ? startNumber : returnString);
                FizzBangRecursion(startNumber + 1, endNumber);
            }
        }

    }
}