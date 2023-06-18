#nullable disable
using AutoMapper;
using LMS.Core.Entities.Books;
using LMS.Web.ViewModels;

namespace LMS.Web.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorViewModel>()
                .ForMember(dst => dst.Books, opt => opt.MapFrom(x => x.BookAuthors.Select(y => y.Book).ToList()));

            CreateMap<AuthorViewModel, Author>();
        }
    }
}
