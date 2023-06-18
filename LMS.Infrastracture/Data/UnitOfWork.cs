using LMS.Core.Repositories;
using LMS.Infrastracture.Repositories;

namespace LMS.Infrastracture.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LibraryContext _context;

        public UnitOfWork(LibraryContext context)
        {
            _context = context;
        }

        private IBookRepository _books = null!;
        public IBookRepository Books
        {
            get
            {
                if (_books == null)
                {
                    _books = new BookRepository(_context);
                }
                return _books;
            }
        }

        private IAuthorRepository _authors = null!;
        public IAuthorRepository Authors
        {
            get
            {
                if (_authors == null)
                {
                    _authors = new AuthorRepository(_context);
                }
                return _authors;
            }
        }

        private ISubjectRepository _subjects = null!;
        public ISubjectRepository Subjects
        {
            get
            {
                if (_subjects == null)
                {
                    _subjects = new SubjectRepository(_context);
                }
                return _subjects;
            }
        }

        private IMemberRepository _members = null!;
        public IMemberRepository Members
        {
            get
            {
                if (_members == null)
                {
                    _members = new MemberRepository(_context);
                }
                return _members;
            }
        }

        private ITransactionRepository _issues = null!;
        public ITransactionRepository Issues
        {
            get
            {
                if (_issues == null)
                {
                    _issues = new TransactionRepository(_context);
                }
                return _issues;
            }
        }

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
