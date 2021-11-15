using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoopTest.utils
{
    internal static class StringHelper
    {
        internal static String getFizz(int i)
        {
            return MultipleNumberHelper.isMultipleOf(i, 3) ? "Fizz" : "";
        }

        internal static String getBang(int i)
        {
            return MultipleNumberHelper.isMultipleOf(i, 5) ? "Bang" : "";
        }
    }
}