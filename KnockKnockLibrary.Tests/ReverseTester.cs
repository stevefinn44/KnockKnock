using Xunit;

namespace KnockKnockLibrary.Tests
{
    public class ReverseTester
    {

        [Fact]
        public void SimpleTest()
        {
            //arange
            var reverseHelper = new ReverseHelper();

            //act
            var result = reverseHelper.Reverse("abc def");

            //assert
            Assert.True(result.Equals("cba fed"), "Simple Reverse works");

        }


        [Fact]
        public void ComplexTest()
        {
            //arange
            var reverseHelper = new ReverseHelper();

            //act
            var result = reverseHelper.Reverse($"abc de\u0301f");

            //assert
            Assert.True(result.Equals("cba fe\u0301d"), "Complex Reverse works");

        }
    }

   
}
