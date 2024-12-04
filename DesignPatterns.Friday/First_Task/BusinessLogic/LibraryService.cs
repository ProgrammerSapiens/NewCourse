using DesignPatterns.Friday.First_Task.DataAccessLayer;
using System.Threading.Channels;

namespace DesignPatterns.Friday.First_Task.BusinessLogic
{
    public class LibraryService : ILibraryService
    {
        IBookRepository bookRepository;

        public LibraryService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public void AddBookToLibrary()
        {
            Console.WriteLine("Enter an ID of the book");
            string stringId = Console.ReadLine() ?? string.Empty;
            int id = int.TryParse(stringId, out int parsedId) ? parsedId : -1;

            if (id != -1)
            {
                Console.WriteLine("Enter a title of the book");
                string title = Console.ReadLine() ?? string.Empty;

                if (!string.IsNullOrEmpty(title))
                {
                    Console.WriteLine("Enter an author of the book");
                    string author = Console.ReadLine() ?? string.Empty;

                    if (!string.IsNullOrEmpty(author))
                    {
                        bookRepository.AddBook(id, title, author);

                        Book book = bookRepository.GetBookById(id);
                        if (book.Title == title || book.Author == author)
                        {
                            Console.WriteLine("The book was successfully added");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The author's name can not be empty");
                    }
                }
                else
                {
                    Console.WriteLine("The title of the book can not be empty");
                }
            }
            else
            {
                Console.WriteLine("The id of the book can not be empty");
            }
        }

        public void DeleteBookFromLibrary()
        {
            Console.WriteLine("Enter the Id of the book that you want to delete");
            string stringId = Console.ReadLine() ?? string.Empty;
            int id = int.TryParse(stringId, out int parsedId) ? parsedId : -1;

            if (id != -1)
            {
                bookRepository.DeleteBookById(id);
            }
        }

        public void GetAllBooksFromLibrary()
        {
            List<Book> books = new List<Book>();
            books = bookRepository.GetAllBooks();
            foreach (Book book in books)
            {
                Console.WriteLine($"Id: {book.Id}, title - {book.Title}, author - {book.Author}");
            }
        }

        public void GetBookByIdFromLibrary()
        {
            Console.WriteLine("Enter an id of the book");

            string stringId = Console.ReadLine() ?? string.Empty;
            int id = int.TryParse(stringId, out int parsedId) ? parsedId : -1;

            if (id != -1)
            {
                Book book = new Book();
                book = bookRepository.GetBookById(id);
                Console.WriteLine($"Id: {book.Id}, title - {book.Title}, author - {book.Author}");
            }
        }
    }
}
