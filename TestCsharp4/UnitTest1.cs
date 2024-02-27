namespace TestCsharp4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMatrixOperations()
        {
            Matrix m1 = new Matrix(2, 2);
            m1[0, 0] = 1;
            m1[0, 1] = 2;
            m1[1, 0] = 3;
            m1[1, 1] = 4;

            Matrix m2 = new Matrix(2, 2);
            m2[0, 0] = 5;
            m2[0, 1] = 6;
            m2[1, 0] = 7;
            m2[1, 1] = 8;

            Matrix sum = m1 + m2;
            Assert.AreEqual(6, sum[0, 0]);
            Assert.AreEqual(8, sum[0, 1]);
            Assert.AreEqual(10, sum[1, 0]);
            Assert.AreEqual(12, sum[1, 1]);

            Matrix diff = m1 - m2;
            Assert.AreEqual(-4, diff[0, 0]);
            Assert.AreEqual(-4, diff[0, 1]);
            Assert.AreEqual(-4, diff[1, 0]);
            Assert.AreEqual(-4, diff[1, 1]);

            Matrix productScalar = m1 * 2;
            Assert.AreEqual(2, productScalar[0, 0]);
            Assert.AreEqual(4, productScalar[0, 1]);
            Assert.AreEqual(6, productScalar[1, 0]);
            Assert.AreEqual(8, productScalar[1, 1]);

            Matrix m3 = new Matrix(2, 3);
            m3[0, 0] = 1;
            m3[0, 1] = 2;
            m3[0, 2] = 3;
            m3[1, 0] = 4;
            m3[1, 1] = 5;
            m3[1, 2] = 6;

            Matrix productMatrix = m1 * m3;
            Assert.AreEqual(9, productMatrix[0, 0]);
            Assert.AreEqual(12, productMatrix[0, 1]);
            Assert.AreEqual(15, productMatrix[0, 2]);
            Assert.AreEqual(19, productMatrix[1, 0]);
            Assert.AreEqual(26, productMatrix[1, 1]);
            Assert.AreEqual(33, productMatrix[1, 2]);

            Matrix m4 = new Matrix(2, 2);
            m4[0, 0] = 1;
            m4[0, 1] = 2;
            m4[1, 0] = 3;
            m4[1, 1] = 4;

            Assert.IsTrue(m1 == m4);
            Assert.IsFalse(m1 != m4);
        }
    }
}