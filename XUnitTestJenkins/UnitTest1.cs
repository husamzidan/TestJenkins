using System;
using TestJenkins;
using Xunit;

namespace XUnitTestJenkins
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("Test message", Program.GetMessage());
        }
    }
}
