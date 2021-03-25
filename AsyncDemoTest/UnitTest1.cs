using System;
using Xunit;
using AsyncDemo;
using System.Threading.Tasks;

namespace AsyncDemoTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var asyncTaskHandler = new AsyncTaskHandler();
            Task<string> greetingTask = asyncTaskHandler.AsyncGreeting();
            Assert.Equal("Hello World!", greetingTask.Result);
        }
    }
}
