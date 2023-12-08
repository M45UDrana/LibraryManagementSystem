using LMS.Core.Entities.Books;

namespace LMS.Core.Repositories
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> GetAllWithAuthorsSubjects();
        Book GetSingleWithAuthorsSubjects(int id);
    }
}