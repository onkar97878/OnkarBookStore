using OnkarBooks.DataAccess.Repository.iRepository;
using OnkarBooks.Models;

namespace OnkarBooks.DataAccess.Repository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}