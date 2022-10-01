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

        [Fact]
        public void DictionaryTests()
        {

            Assert.Throws<ArgumentException>(() =>
            {
                var dict = new Dictionary<UncasedString, int>();
                dict.Add((UncasedString)"Tree", 1);
                dict.Add((UncasedString)"tree", 1);
            });

            var noun = new UncasedString("Google"); 
            var verb = new UncasedString("google");

            var dict = new Dictionary<UncasedString, int>();
            dict[noun] = 1;
            dict[verb] = 2;

            Assert.Equal(2, dict[noun]);

        }
    }
}