using LMS.Core.Entities.Issues;

namespace LMS.Core.Entities.Members
{
    public class Member
    {
        public int MemberId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public MemberType MemberType { get; set; }

        public ICollection<Issue>? Issues { get; set; }
    }
}
