namespace Csharp4
{
    public class BookList
    {
        private List<string> books;

        public BookList()
        {
            books = new List<string>();
        }

        public void AddBook(string book)
        {
            books.Add(book);
        }

        public void RemoveBook(string book)
        {
            books.Remove(book);
        }

        public bool ContainsBook(string book)
        {
            return books.Contains(book);
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < books.Count)
                    return books[index];
                else
                    throw new IndexOutOfRangeException("Index is out of range");
            }
            set
            {
                if (index >= 0 && index < books.Count)
                    books[index] = value;
                else
                    throw new IndexOutOfRangeException("Index is out of range");
            }
        }

        public int Count
        {
            get { return books.Count; }
        }
    }
}
