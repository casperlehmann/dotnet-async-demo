using System;

namespace AsyncDemo
{
    class Demo
    {
        static void Main(string[] args)
        {
            string greeting = new AsyncTaskHandler().GetString();
            Console.WriteLine(greeting);
        }
    }
}
