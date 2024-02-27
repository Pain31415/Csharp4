namespace TestCsharp4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreditCardOperations()
        {
            CreditCard card1 = new CreditCard("1234567890123456", 123, 1000.0m);
            CreditCard card2 = new CreditCard("9876543210987654", 456, 500.0m);

            card1 += 500.0m;
            Assert.AreEqual(1500.0m, card1.Balance);

            card2 -= 200.0m;
            Assert.AreEqual(300.0m, card2.Balance);

            CreditCard card3 = new CreditCard("1111222233334444", 123, 2000.0m);
            CreditCard card4 = new CreditCard("5555666677778888", 123, 1500.0m);

            Assert.IsTrue(card1 == card3);
            Assert.IsFalse(card1 != card3);

            Assert.IsTrue(card1 > card2);
            Assert.IsFalse(card2 > card3);
            Assert.IsTrue(card2 < card3);
            Assert.IsFalse(card1 < card4);
        }
    }
}