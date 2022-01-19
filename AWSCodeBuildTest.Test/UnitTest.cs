using AWSCodeBuildTest.Core;
using Xunit;

namespace AWSCodeBuildTest.Test
{
    public class UnitTest
    {
        [Fact]
        public void Test()
        {
            var service = new SimpleService();
            Assert.Equal("Test", service.GetMessage());
        }
    }
}
