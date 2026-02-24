namespace TestHello
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestSayHi()
        {
            Assert.AreEqual("Hello World", Program.Hello.SayHi());
        }
    }
}
