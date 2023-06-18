#nullable disable
using AutoMapper;
using LMS.Core.Entities.Books;
using LMS.Web.ViewModels;

namespace LMS.Web.Profiles
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<Book, BookViewModel>()
                .ForMember(dst => dst.Authors, opt => opt.MapFrom(x => x.BookAuthors.Select(y => y.Author).ToList()))
                .ForMember(dst => dst.Subjects, opt => opt.MapFrom(x => x.BookSubjects.Select(y => y.Subject).ToList()));

            CreateMap<BookViewModel, Book>();
        }
    }
}
