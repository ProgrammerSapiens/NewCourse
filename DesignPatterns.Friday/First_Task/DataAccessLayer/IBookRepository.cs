namespace DesignPatterns.Friday.First_Task.DataAccessLayer
{
    public interface IBookRepository
    {
        void AddBook(int id, string title, string author);
        Book GetBookById(int id);
        List<Book> GetAllBooks();
        void DeleteBookById(int id);
    }
}
