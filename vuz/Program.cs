﻿using static System.Math;
using static System.Console;



namespace Exerсise
{
   class Class1
   {
      static void Main()
      {
         //ex.1
         WriteLine("Exercise_1");
         double xn = -7, xk = 11, dx = 1, y = 0;
         WriteLine("  X    Y");
         while (xn <= xk)
         {
            if (xn <= -3) y = 3;
            if ((-3 < xn) & (xn <= 3)) y = -1 * Sqrt(9 - Pow(xn, 2)) + 3;
            if ((3 < xn) & (xn <= 6)) y = 9 + (-2) * xn;
            if (6 < xn) y = xn - 9;
            WriteLine("{0, 3} {1, 4}", xn, y);
            xn += dx;
         }

         //ex.2
         WriteLine("Exercise_2");
         for (double n = 42004; n < 43000; n += 10)
         {
            if (n % 72 == 0) WriteLine(n);
         }
      }
   }
}