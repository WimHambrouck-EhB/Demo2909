using DemoLibrary;
using System;
using System.Collections.Generic;

namespace Demo2909
{
    class Program
    {
        static void Main(string[] args)
        {
            var lijst = new List<string> { "een", "twee", "drie", "vier" };

            lijst.Remove("twee");

            Console.WriteLine(string.Join(", ", lijst));
        }
    }
}
