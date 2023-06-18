using LMS.Core.Entities.Books;
using LMS.Core.Entities.Members;

namespace LMS.Core.Entities.Issues
{
    public class Issue
    {
        public int IssueId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpireDate { get; set; }

        public int MemberId { get; set; }
        public Member? Member { get; set; }

        public int BookId { get; set; }
        public Book? Book { get; set; }
    }
}
