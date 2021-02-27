using Model;
using Xunit;

namespace ModelTests
{
	public class CheckTests
    {
        [Fact]
        public void Check_Status_Ok()
        {
            Assert.Equal("Hi, I'm OK!", Check.Status);
        }
    }
}
