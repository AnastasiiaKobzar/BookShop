using BookShop.Data.Models;

namespace BookShop.ViewModels
{
    public class BooksListViewModel
    {
        public IEnumerable<Books> allBooks { get; set; }
        public string currCategory { get; set; }
    }
}
