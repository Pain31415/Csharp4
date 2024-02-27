namespace TestCsharp4
{
    [TestClass]
    public class BookListTests
    {
        [TestMethod]
        public void TestBookListOperations()
        {
            BookList bookList = new BookList();

            bookList.AddBook("Book 1");
            bookList.AddBook("Book 2");
            bookList.AddBook("Book 3");

            Assert.AreEqual(3, bookList.Count);

            bookList.RemoveBook("Book 2");
            Assert.IsFalse(bookList.ContainsBook("Book 2"));
            Assert.AreEqual(2, bookList.Count);

            bookList[0] = "New Book";
            Assert.AreEqual("New Book", bookList[0]);
        }
    }
}