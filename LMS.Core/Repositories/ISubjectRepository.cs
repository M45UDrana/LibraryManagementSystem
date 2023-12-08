using LMS.Core.Entities.Books;

namespace LMS.Core.Repositories
{
    public interface ISubjectRepository : IRepository<Subject>
    {
        IEnumerable<Subject> GetAllWithBooks();
        Subject GetSingleWithBooks(int id);
    }
}