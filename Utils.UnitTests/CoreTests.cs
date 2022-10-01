using KamalRaj.Utils;

namespace Utils.UnitTests
{
    public class CoreTests
    {
        [Fact]
        public void PrimitiveTests()
        {
            var a = new UncasedString("Tree");
            var b = new UncasedString("tree");

            Assert.Equal(a, b);

            Assert.True(b == a);
        }
    }
}