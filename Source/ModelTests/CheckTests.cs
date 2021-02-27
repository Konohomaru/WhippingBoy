using Model;
using Xunit;

namespace ModelTests
{
	public class CheckTests
    {
        [Fact]
        public void Check_Status_Ok()
        {
            Assert.Equal("AAAAAAAA", Check.Status);
        }
    }
}
