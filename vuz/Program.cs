﻿using static System.Console;


namespace Laba_4
{
    class Class_1
    {
        static void Main()
        {
            List<int> lt = [0, 1, 2, 3, 4];
            foreach (int n in lt) Write($"{n}  ");
            Write("\n");
            lt.Add(5);
            foreach( int n in lt) Write($"{n}  ");
            Write("\n");
            List<int> lt_1 = [0, 1, 2];
            foreach (int n in lt_1) Write($"{n}  ");
            Write("\n");
            lt.InsertRange(2, lt_1);
            foreach (int n in lt) Write($"{n}  ");
            Write($"\n{lt.Count}\n");
            WriteLine(lt.Max());
            WriteLine(lt.Min());
            int[] a = new int[3];
            lt_1.CopyTo(a);
            foreach (int n in a) Write($"{n}  ");
            lt_1.RemoveAt(1);
            Write("\n");
            foreach (int n in lt_1) Write($"{n}  ");
            Write("\n");
        }
    }
}