﻿using static System.Math;
using static System.Console;


//ex.1
namespace Exerсise_1
{
   class Class1
   {
      static void Main()
      {
         WriteLine("Exercise_1");
         double xn = -7, xk = 11, dx = 1, y = 0;
         WriteLine("X  Y");
         while (xn <= xk)
         {
            if (xn <= -3) y = 3;
            if ((-3 < xn) & (xn <= 3)) y = -1 * Sqrt(9 - Pow(xn, 2)) + 3;
            if ((3 < xn) & (xn <= 6)) y = 9 + (-2) * xn;
            if (6 < xn) y = xn - 9;
            WriteLine("{0, 0} {1, 2}", xn, y);
            xn += dx;
         }
      }
   }
}
