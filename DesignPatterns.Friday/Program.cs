using DesignPatterns.Friday.First_Task.BusinessLogic;
using DesignPatterns.Friday.First_Task.DataAccessLayer;
using DesignPatterns.Friday.Second_Task.BusinessLogic;
using DesignPatterns.Friday.Second_Task.Data;
using DesignPatterns.Friday.Second_Task.Presentation;

namespace DesignPatterns.Friday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First task
            BookRepository bookRepository = new BookRepository();
            LibraryService libraryService = new LibraryService(bookRepository);

            libraryService.AddBookToLibrary();
            libraryService.AddBookToLibrary();
            libraryService.GetAllBooksFromLibrary();
            libraryService.DeleteBookFromLibrary();

            //Second task
            IOrderRepository orderRepository = new OrderRepository();
            IProductRepository productRepository = new ProductRepository();
            IProductService productService = new ProductService(productRepository);
            IOrderService orderService = new OrderService(orderRepository, productService);
            Presentation presentation = new Presentation(orderService, productService);

            presentation.AddProducts(1, "Salt", 11.27);
            presentation.AddProducts(2, "Orange", 22.35);
            presentation.AddProducts(3, "Meat", 98.12);
            presentation.AddProducts(4, "Salmon", 85.33);
            presentation.AddOrder(1, new List<int> { 1, 2, 3, 4 });
            presentation.ShowOrderById(1);
            presentation.DeleteProductById(1);
            presentation.ShowOrderById(1);
            presentation.DeleteOrderById(1);
            presentation.ShowOrderById(1);
        }
    }
}
