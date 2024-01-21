using BookShop.Data.Interfaces;
using BookShop.Data.Models;

namespace BookShop.Data.Mocks
{
    public class MockCategory : IBooksCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { name = "Miękka okładka", desc = "Pojedynczy zadrukowany arkusz kartonu"},
                    new Category { name = "Twarda okładka", desc = "Do oprawy używana jest tektura"}
                };
            }
        }
    }
}
