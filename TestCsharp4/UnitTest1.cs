using static System.Formats.Asn1.AsnWriter;

namespace TestCsharp4
{
    [TestClass]
    public class StoreTests
    {
        [TestMethod]
        public void TestStoreOperations()
        {
            Store store1 = new Store("Store1", 100.0);
            Store store2 = new Store("Store2", 150.0);

            store1 += 50.0;
            Assert.AreEqual(150.0, store1.Area);

            store2 -= 30.0;
            Assert.AreEqual(120.0, store2.Area);

            Store store3 = new Store("Store3", 200.0);
            Store store4 = new Store("Store4", 120.0);

            Assert.IsTrue(store1 == store4);
            Assert.IsFalse(store1 != store4);
            Assert.IsTrue(store3 > store2);
            Assert.IsFalse(store4 < store2);
        }
    }
}