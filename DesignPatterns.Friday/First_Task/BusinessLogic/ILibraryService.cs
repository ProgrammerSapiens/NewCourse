namespace DesignPatterns.Friday.First_Task.BusinessLogic
{
    public interface ILibraryService
    {
        void AddBookToLibrary();
        void GetBookByIdFromLibrary();
        void GetAllBooksFromLibrary();
        void DeleteBookFromLibrary();
    }
}
