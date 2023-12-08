using AutoMapper;
using LMS.Core.Entities.Members;
using LMS.Web.ViewModels;

namespace LMS.Web.Profiles
{
    public class MemberProfile : Profile
    {
        public MemberProfile()
        {
            CreateMap<Member, MemberViewModel>();
            CreateMap<MemberViewModel, Member>();
        }
    }
}
