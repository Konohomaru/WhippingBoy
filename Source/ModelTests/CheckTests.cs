using Model;
using NUnit.Framework;

namespace ModelTests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Check_TwoInstances_BothAreEqual()
		{
			var first = Check.Instance;
			var second = Check.Instance;

			Assert.IsTrue(first.Equals(second));
		}
	}
}