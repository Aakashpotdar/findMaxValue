using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace FindMaximumProblem
{
    class Refactor1and2Class<T> : IComparable<Refactor1and2Class<T>> where T : IComparable
    {
        private T var1,var3,var2;
        public Refactor1and2Class(T var1,T var2,T var3)
        {
            this.var1 = var1;
            this.var2 = var2;
            this.var3 = var3;
        }

        public void testMaximum()
        {
            if (var1.CompareTo(var2) > 0 && var1.CompareTo(var3) > 0 || var1.CompareTo(var2) >= 0 && var1.CompareTo(var3) > 0 || var1.CompareTo(var2) > 0 && var1.CompareTo(var3) >= 0)
            {
                Console.WriteLine("the number 1 larger than number 2 and 3");
            }
            else if (var2.CompareTo(var1) > 0 && var2.CompareTo(var3) > 0 || var2.CompareTo(var1) >= 0 && var2.CompareTo(var3) > 0 || var2.CompareTo(var1) > 0 && var2.CompareTo(var3) >= 0)
            {
                Console.WriteLine("the number 2 larger than number 1 and 3");
            }
            else if (var3.CompareTo(var2) > 0 && var3.CompareTo(var1) > 0 || var3.CompareTo(var2) > 0 && var3.CompareTo(var1) >= 0 || var3.CompareTo(var2) >= 0 && var3.CompareTo(var1) > 0)
            {
                Console.WriteLine("the number 3 larger than number 1 and 2");
            }
        }

        public int CompareTo([AllowNull] Refactor1and2Class<T> other)
        {
            throw new NotImplementedException();
        }

    }
}
