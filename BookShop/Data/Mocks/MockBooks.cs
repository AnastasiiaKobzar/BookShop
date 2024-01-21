using BookShop.Data.Interfaces;
using BookShop.Data.Models;

namespace BookShop.Data.Mocks
{
    public class MockBooks : IAllBooks
    {

        private readonly IBooksCategory _categoryBooks = new MockCategory();
        public IEnumerable<Books> Books 
        {
            get
            {
                return new List<Books>
                {
                    new Books { title ="Misery",
                        shortDesc ="King Stephen", 
                        longDesc ="Paul Sheldon jest autorem poczytnych tandetnych romansideł. Jego cykl o Misery Chastain zdobył ogromną popularność. Autor miał jednak już dość swojej bohaterki i w ostatniej powieści ją uśmiercił. Teraz postanowił zająć się pisaniem poważniejszych książek.",
                        img ="/img/misery.jpg", 
                        price= 50, 
                        isFavourite = true,
                        available = true,
                        Category = _categoryBooks.AllCategories.First() }
                };
            }
        }
        public IEnumerable<Books> getFavBooks { get; set; }

        public Books getObjectBook(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
