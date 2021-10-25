using System;
using System.Collections.Generic;

namespace lekcija7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //TaskSum28();
            TaskLucky13();
        }
       
        static void TaskLucky13()
        {
            var list = new List<int> { 2, 3, 2, 6, 2, 2 };
            var result = true;
            foreach (var i in list)
            {
                if (i == 1 || i == 3) result = false;
            }
            Console.WriteLine(result);
        }
        static void TaskSum28()
        {
            var list = new List<int> {1, 2, 3, 2, 6, 2, 2 };
            var sumOfTwo = 0;
            foreach (var i in list)
            {
                if (i == 2) sumOfTwo += i;
            }
            Console.WriteLine($"Sum = {sumOfTwo}; {sumOfTwo == 8}");
        }
    }
}
