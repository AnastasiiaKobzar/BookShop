using BookShop.Data.Models;

namespace BookShop.Data.Interfaces
{
    public interface IBooksCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
