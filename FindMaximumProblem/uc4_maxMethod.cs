using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumProblem
{
    class uc4_maxMethod
    {
        public static void Max(int[] values)
        {
            
            int max = values[0];
            for (int i = 1; i < values.Length; i++)
                if (values[i].CompareTo(max) > 0) max = values[i];
            Console.WriteLine("max number: " + max);
            
        }
    }
}
