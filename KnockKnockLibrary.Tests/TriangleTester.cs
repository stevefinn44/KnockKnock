using Xunit;

namespace KnockKnockLibrary.Tests
{
   
    public class TriangleTester
    {
        [Theory]
        [InlineData(0, 1, 1)]
        [InlineData(1, 0, 1)]
        [InlineData(1, 1, 0)]
        [InlineData(0, 0, 1)]
        [InlineData(0, 1, 0)]
        [InlineData(1, 0, 0)]
        [InlineData(0, 0, 0)]
        public void AnyZeroSideReturnsFalse(int a, int b, int c)
        {
            //arange
            var triangleHelper = new TriangleHelper();
            var result = triangleHelper.IsTriangle(a, b, c);
            Assert.False(result, "Triangle with a side equal to zero should be false");


        }


       
        [Theory]
        [InlineData(10, 1, 1)]
        [InlineData(1, 10, 1)]
        [InlineData(1, 1, 10)]
        public void AnySideLongerthanSumOfOtherSidesTriangleReturnsFalse(int a, int b, int c)
        {
            //arange
            var triangleHelper = new TriangleHelper();
            var result = triangleHelper.IsTriangle(a, b, c);
            Assert.False(result, "Triangle with any side longer than the sum of the other two  sides should be false");
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(1, 2, 1)]
        [InlineData(1, 1, 2)]
        public void AnySideEqualToSumOfOtherSidesTriangleReturnsFalse(int a, int b, int c)
        {
            //arange
            var triangleHelper = new TriangleHelper();

            //act
            var result = triangleHelper.IsTriangle(a, b, c);

            //assert
            Assert.False(result, "Triangle with any side longer than the sum of the other two  sides should be false");
        }

        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(3, 5, 4)]
        [InlineData(4, 3, 5)]
        [InlineData(4, 5, 3)]
        [InlineData(5, 3, 4)]
        [InlineData(5, 4, 3)]
        public void ValidTriangleReturnsTrue(int a, int b, int c)
        {
            //arange
            var triangleHelper = new TriangleHelper();

            //act
            var result = triangleHelper.IsTriangle(a, b, c);

            //assert
            Assert.True(result, "Triangle with valid sides should be true");
        }

        [Fact]
        public void ThreeSidesSameReturnEquilateral()
        {
            //arange
            var triangleHelper = new TriangleHelper();

            //act
            var result = triangleHelper.GetTriangleType(5,5,5);

            //assert
            Assert.True(result.Equals(TriangleType.Equilateral), "Triangle with sides is equilateral");
        }

        [Fact]
        public void TwoSidesSameReturnIsocoles()
        {
            //arange
            var triangleHelper = new TriangleHelper();

            //act
            var result = triangleHelper.GetTriangleType(5, 5, 3);

            //assert
            Assert.True(result.Equals(TriangleType.Isocoles), "Triangle with two equal sides is isocoles");
        }

        [Fact]
        public void NoSidesSameReturnScalene()
        {
            //arange
            var triangleHelper = new TriangleHelper();

            //act
            var result = triangleHelper.GetTriangleType(5, 4, 3);

            //assert
            Assert.True(result.Equals(TriangleType.Scalene), "Triangle with no equal sides is scalene");
        }
    }
}
