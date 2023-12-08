#nullable disable
using LMS.Core.Entities.Books;
using LMS.Core.Repositories;
using LMS.Infrastracture.Data;
using Microsoft.EntityFrameworkCore;

namespace LMS.Infrastracture.Repositories
{
    public class SubjectRepository : Repository<Subject>, ISubjectRepository
    {
        public SubjectRepository(LibraryContext context) : base(context)
        {
        }

        public IEnumerable<Subject> GetAllWithBooks()
        {
            return LibraryContext.Subjects
                .Include(bs => bs.BookSubjects)
                .ToList();
        }

        public Subject GetSingleWithBooks(int id)
        {
            return LibraryContext.Subjects
                .Where(s => s.SubjectId == id)
                .Include(bs => bs.BookSubjects)
                    .ThenInclude(b => b.Book)
                .FirstOrDefault();
        }

        public LibraryContext LibraryContext
        {
            get { return Context as LibraryContext; }
        }
    }
}
