using LMS.Core.Entities.Members;

namespace LMS.Core.Repositories
{
    public interface IMemberRepository : IRepository<Member>
    {
        Member GetMemberWithIssuedBooks(int id);
    }
}