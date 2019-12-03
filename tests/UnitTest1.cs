using Xunit;
using class_library;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void sum()
        {
            Class1 cl = new Class1();
            int expected = 10;
            int actual = cl.sum(7, 3);
            Assert.Equal(expected, actual);
        }
    }
}
