﻿namespace KPIPractice2
{
    //  Swap<T> — обмін значень
    // - Напишіть статичний метод void Swap<T>(ref T a, ref T b).
    // - У Main обміняйте int x=5,y=10 і string s1="Hello",s2="World".
    public class Task2
    {
        public void Main()
        {
            int x=5,y=10;
            string s1="Hello",s2="World";
            Swap(ref x,ref y);
            Swap(ref s1,ref s2);
            Console.WriteLine($"x: {x}, y:{y}");
            Console.WriteLine($"s1: {s1}, s2:{s2}");
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp= a;
            a=b;
            b=temp;
        }
    }

}
