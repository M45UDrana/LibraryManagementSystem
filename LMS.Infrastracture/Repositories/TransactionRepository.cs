#nullable disable
using LMS.Core.Entities.Issues;
using LMS.Core.Repositories;
using LMS.Infrastracture.Data;
using Microsoft.EntityFrameworkCore;

namespace LMS.Infrastracture.Repositories
{
    public class TransactionRepository : Repository<Issue>, ITransactionRepository
    {
        public TransactionRepository(LibraryContext context) : base(context)
        {
        }

        public IEnumerable<Issue> GetAllIssuedBooks()
        {
            return LibraryContext.Issues
                .Include(b => b.Book)
                .Include(m => m.Member)
                .ToList();
        }

        public Issue GetByBookId(int bookId)
        {
            return LibraryContext.Issues
                .Where(i => i.BookId == bookId)
                .Include(b => b.Book)
                .Include(m => m.Member)
                .FirstOrDefault();
        }

        public LibraryContext LibraryContext
        {
            get { return Context as LibraryContext; }
        }
    }
}
