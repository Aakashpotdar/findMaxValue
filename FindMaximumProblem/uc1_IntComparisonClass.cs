using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumProblem
{
    class uc1_IntComparisonClass
    {
        public void compairInt(int num1,int num2,int num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0 || num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) > 0 || num1.CompareTo(num2) > 0 && num1.CompareTo(num3) >= 0)
            {
                Console.WriteLine("the number 1 larger than number 2 and 3");
            }
            else if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0|| num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) > 0|| num2.CompareTo(num1) > 0 && num2.CompareTo(num3) >= 0)
            {
                Console.WriteLine("the number 2 larger than number 1 and 3");
            }
            else if (num3.CompareTo(num2) > 0 && num3.CompareTo(num1) > 0|| num3.CompareTo(num2) > 0 && num3.CompareTo(num1) >= 0 || num3.CompareTo(num2) >= 0 && num3.CompareTo(num1) > 0)
            {
                Console.WriteLine("the number 3 larger than number 1 and 2");
            }
        }
    }
}
