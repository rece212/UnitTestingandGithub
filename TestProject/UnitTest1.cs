using UnitTestingandGithub;

namespace TestProject

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FailedTest()
        {
            TestMe t1 = new TestMe("Jack", "I wrote this", "1", "Reece");
            String expected = "My Name is Jack and I wrote this";
            string actual = t1.ToString();
            Assert.AreEqual(expected, actual);

        }
    }
}