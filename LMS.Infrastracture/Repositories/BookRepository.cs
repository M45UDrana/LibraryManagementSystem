#nullable disable
using LMS.Core.Entities.Books;
using LMS.Core.Repositories;
using LMS.Infrastracture.Data;
using Microsoft.EntityFrameworkCore;

namespace LMS.Infrastracture.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(LibraryContext context) : base(context)
        {
        }

        public IEnumerable<Book> GetAllWithAuthorsSubjects()
        {
            return LibraryContext.Books
                .Include(ba => ba.BookAuthors)
                    .ThenInclude(a => a.Author)
                .Include(bs => bs.BookSubjects)
                    .ThenInclude(s => s.Subject)
                .Include(i => i.Issue)
                .ToList();
        }

        public Book GetSingleWithAuthorsSubjects(int id)
        {
            return LibraryContext.Books
                .Where(b => b.BookId == id)
                .Include(ba => ba.BookAuthors)
                    .ThenInclude(a => a.Author)
                .Include(bs => bs.BookSubjects)
                    .ThenInclude(s => s.Subject)
                .Include(i => i.Issue)
                .FirstOrDefault();
        }

        public LibraryContext LibraryContext
        {
            get { return Context as LibraryContext; }
        }
    }
}
