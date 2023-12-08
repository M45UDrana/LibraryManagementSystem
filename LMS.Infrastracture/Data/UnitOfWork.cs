using LMS.Core.Repositories;
using LMS.Infrastracture.Repositories;

namespace LMS.Infrastracture.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        #region private fields
        private readonly LibraryContext _context;
        private IBookRepository? _books;
        private IAuthorRepository _authors = null!;
        private ISubjectRepository _subjects = null!;
        private IMemberRepository _members = null!;
        private ITransactionRepository _issues = null!;
        #endregion private fields

        public UnitOfWork(LibraryContext context)
        {
            _context = context;
        }

        #region properties
        public IBookRepository Books => _books ??= new BookRepository(_context);
        public IAuthorRepository Authors => _authors ??= new AuthorRepository(_context);

        public ISubjectRepository Subjects => _subjects ??= new SubjectRepository(_context);

        public IMemberRepository Members => _members ??= new MemberRepository(_context);

        public ITransactionRepository Issues => _issues ??= new TransactionRepository(_context);
        #endregion properties

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
