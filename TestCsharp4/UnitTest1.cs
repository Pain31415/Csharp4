namespace TestCsharp4
{
    [TestClass]
    public class JournalTests
    {
        [TestMethod]
        public void TestJournalOperations()
        {
            Journal journal1 = new Journal("Journal1", 50);
            Journal journal2 = new Journal("Journal2", 100);

            journal1 += 10;
            Assert.AreEqual(60, journal1.NumberOfEmployees);

            journal2 -= 20;
            Assert.AreEqual(80, journal2.NumberOfEmployees);

            Journal journal3 = new Journal("Journal3", 60);
            Journal journal4 = new Journal("Journal4", 80);

            Assert.IsTrue(journal1 == journal3);
            Assert.IsFalse(journal1 != journal3);
            Assert.IsTrue(journal2 > journal4);
            Assert.IsFalse(journal2 < journal4);
        }
    }
}