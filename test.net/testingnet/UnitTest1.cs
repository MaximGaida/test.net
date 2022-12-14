using Microsoft.VisualStudio.TestPlatform.TestHost;
using test.net.data;

namespace testingnet
{
    public class UnitTest1
    {
        [Fact]
        public void PassingAddTest()
        {
            Assert.Equal(4, dataclass.Add(2, 2));
        }



        [Fact]
        public void PassingAddTest1()
        {
            Assert.Equal(6, dataclass.Add(3, 3));
        }

        [Fact]
        public void PassingAddTest2()
        {
            Assert.Equal(8, dataclass.Add(4, 4));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.NotEqual(5, dataclass.Add(2, 2));
        }
    }


}
////