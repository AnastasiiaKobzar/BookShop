using BookShop.Data.Models;

namespace BookShop.Data.Interfaces
{
    public interface IAllBooks
    {
        IEnumerable<Books> Books { get; }
        IEnumerable<Books> getFavBooks { get; set; }
        Books getObjectBook(int bookId);
    }
}
