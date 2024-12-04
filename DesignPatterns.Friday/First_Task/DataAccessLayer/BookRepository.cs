namespace DesignPatterns.Friday.First_Task.DataAccessLayer
{
    internal class BookRepository : IBookRepository
    {
        private List<Book> books;

        public BookRepository()
        {
            books = new List<Book>();
        }

        public void AddBook(int id, string title, string author)
        {
            Book book = new Book(id, title, author);

            int bookIndex = books.FindIndex(book => book.Id == id);

            if (bookIndex == -1)
            {
                books.Add(book);
            }
            else
            {
                Console.WriteLine("There is already such an Id in the repository");
            }

        }

        public Book GetBookById(int id)
        {
            int bookIndex = books.FindIndex(book => book.Id == id);
            if (bookIndex == -1)
            {
                return new Book();
            }
            return books[bookIndex];
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public void DeleteBookById(int id)
        {
            int bookIndex = books.FindIndex(book => book.Id == id);
            if (bookIndex != -1)
            {
                books.RemoveAt(bookIndex);
                Console.WriteLine("The book was successfully deleted");
            }
        }
    }
}
