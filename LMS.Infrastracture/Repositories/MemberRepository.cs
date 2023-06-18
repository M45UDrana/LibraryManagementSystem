#nullable disable
using LMS.Core.Entities.Members;
using LMS.Core.Repositories;
using LMS.Infrastracture.Data;
using Microsoft.EntityFrameworkCore;

namespace LMS.Infrastracture.Repositories
{
    public class MemberRepository : Repository<Member>, IMemberRepository
    {
        public MemberRepository(LibraryContext context) : base(context)
        {
        }

        public Member GetMemberWithIssuedBooks(int id)
        {
            return LibraryContext.Members
                .Include(i => i.Issues)
                    .ThenInclude(b => b.Book)
                .SingleOrDefault(m => m.MemberId == id);
        }

        public LibraryContext LibraryContext
        {
            get { return Context as LibraryContext; }
        }
    }
}
