using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MockTestingSample.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mock = new Mock<IFileNameAnilizeService>();
            var fileName1 = "action";            
            mock.Setup(x => x.Anilize1(It.IsAny<string>())).Returns(true);
            Assert.IsTrue(mock.Object.Anilize1(fileName1));
        }
    }
}
