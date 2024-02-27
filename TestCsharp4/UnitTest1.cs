namespace TestCsharp4

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Employee emp1 = new Employee("John", "Manager", 1000);
            Employee emp2 = new Employee("Jane", "Manager", 1000);

            Assert.IsTrue(emp1 == emp2, "Salaries should be equal");
            Assert.IsFalse(emp1 != emp2, "Salaries should not be different");

            Assert.IsFalse(emp1 < emp2, "emp1's salary should not be less than emp2's salary");
            Assert.IsFalse(emp1 > emp2, "emp1's salary should not be greater than emp2's salary");

            emp1.IncreaseSalary(100);
            Assert.IsTrue(emp1 > emp2, "emp1's salary should be greater after increase");
            Assert.IsFalse(emp1 < emp2, "emp1's salary should not be less after increase");

            emp2.IncreaseSalary(200);
            Assert.IsTrue(emp1 < emp2, "emp1's salary should be less after emp2's increase");
            Assert.IsFalse(emp1 > emp2, "emp1's salary should not be greater after emp2's increase");
        }
    }
}