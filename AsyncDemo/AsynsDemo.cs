using System;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncDemo
{
    public class AsyncTaskHandler
    {
        public string GetString()
        {
            string x = AsyncGreeting().Result;
            return x;
        }

        public async Task<string> AsyncGreeting()
        {
            /*
            Return a greeting, but only after doing some other stuff first.
            This consists of one Async task and three synchronous method calls.
            Because of the one async call, this entire method is async.
            */

            Console.WriteLine("Task delays for 500 ms");
            var task = Task.Delay(500); // Async
            Console.WriteLine("Task now running");

            ThreadSleepForXms(x: 100); // Sync
            Console.WriteLine("Task still running");
            
            ThreadSleepForXms(x: 100); // Sync
            Console.WriteLine("Task still running");
            
            ThreadSleepForXms(x: 100); // Sync
            Console.WriteLine("Task still running");
            
            await task; // Wait for Async method to finish
            Console.WriteLine("Task completed");
            return "Hello World!";
        }
        private void ThreadSleepForXms(int x)
        {
            /*
            This method is synchronous
            */
            Console.WriteLine("Thread sleeps for 100 ms");
            Thread.Sleep(x);
            Console.WriteLine("Thread woke up");
        }        
    }
}
