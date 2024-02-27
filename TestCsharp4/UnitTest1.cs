namespace TestCsharp4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            City city1 = new City("City1", 100000);
            City city2 = new City("City2", 150000);

            city1 += 5000;
            Assert.AreEqual(105000, city1.Population);

            city2 -= 10000;
            Assert.AreEqual(140000, city2.Population);

            Assert.IsTrue(city1 < city2);

            City city3 = new City("City3", 140000);
            Assert.IsTrue(city2 == city3);
            Assert.IsFalse(city1 != city3);
        }
    }
}