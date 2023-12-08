using AutoMapper;
using LMS.Core.Entities.Books;
using LMS.Web.ViewModels;

namespace LMS.Web.Profiles
{
    public class SubjectProfile : Profile
    {
        public SubjectProfile()
        {
            CreateMap<Subject, SubjectViewModel>()
                .ForMember(dst => dst.Books, opt => opt.MapFrom(x => x.BookSubjects.Select(y => y.Book).ToList()));
            CreateMap<SubjectViewModel, Subject>();
        }
    }
}
