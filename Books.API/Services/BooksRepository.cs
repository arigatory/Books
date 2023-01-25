using Books.API.DbContexts;
using Books.API.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Books.API.Services
{
    public class BooksRepository : IBooksRepository
    {
        private readonly BooksContext _context;

        public BooksRepository(BooksContext context){
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }
        public Task<Book?> GetBookAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> GetBooksAsync()
        {
            throw new NotImplementedException();
        }
    }
}
