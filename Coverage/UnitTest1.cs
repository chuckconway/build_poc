using Codes;
using Xunit;

namespace Coverage
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var doSomething = new DoSomething();
            
            Assert.Matches("Chuck", doSomething.GetMyName());
        }
    }
}