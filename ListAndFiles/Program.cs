using System;
using System.Collections.Generic;

namespace ListAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruit = new List<string>();

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter a fruit: ");
                fruit.Add(Console.ReadLine());
            }
            foreach(string fruitItem in fruit)
            {
                Console.WriteLine($"fruit on the list: {fruitItem}");
            }

        }
    }
}
