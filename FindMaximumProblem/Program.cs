using System;

namespace FindMaximumProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            uc1_IntComparisonClass intobj = new uc1_IntComparisonClass();
            Console.WriteLine("Int comparison");
            int num1 = 23;
            int num2 = 20;
            int num3 = 30;

            intobj.compairInt(num1,num2,num3);
            Console.WriteLine("-------------------------");
            
            uc2_floatComparisonClass floatobj = new uc2_floatComparisonClass();
            Console.WriteLine("Float comparison");
            float number1 = 3.20f;
            float number2 = 4.30f;
            float number3 = 0.10f;

            floatobj.compairFloat(number1, number2, number3);
            Console.WriteLine("-------------------------");

            uc3_stringComparisonClass stringobj = new uc3_stringComparisonClass();
            Console.WriteLine("String comparison");
            string Line1 = "apple";
            string Line2 = "banana";
            string Line3 = "orange";

            stringobj.compairString(Line1, Line2,Line3);
            Console.WriteLine("-------------------------");

            Console.WriteLine("* comparison of int using generic");
            new Refactor1and2Class<int>(num1, num2, num3).testMaximum();
            Console.WriteLine("");
            Console.WriteLine("* comparison of float using generic");
            new Refactor1and2Class<float>(number1, number2, number3).testMaximum();
            Console.WriteLine("");
            Console.WriteLine("* comparison of string using generic");
            new Refactor1and2Class<string>(Line1, Line2, Line3).testMaximum();
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");

            Console.WriteLine("* comparison of int using Max method");
            int num4 = 40;
            int[] values = { num1, num2, num3, num4 };
            uc4_maxMethod.Max(values);

            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
            Console.WriteLine("* comparison of int using generic and Max method");
            int num = 45;
            int[] values2 = { num1, num2, num3, num };
            uc5_extendMax<int>.Max<int>(values);
            
            Console.WriteLine("-------------------------");
            Console.WriteLine("* comparison of float using generic and Max method");
            
            float[] value = { number1, number2, number3 };
            uc5_extendMax<float>.Max<float>(value);

        }
    }
}
