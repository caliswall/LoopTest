using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoopTest.utils
{
    internal static class MultipleNumberHelper
    {
         ///<Summary>
        /// Check to see if a number is a multiple of another number
        ///</Summary>
        internal static Boolean isMultipleOf(int numberToCheck, int multipleOf) {
            return numberToCheck % multipleOf == 0;
        }
    }
}