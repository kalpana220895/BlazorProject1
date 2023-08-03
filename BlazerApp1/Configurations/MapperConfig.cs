using AutoMapper;
using BlazerApp1.Data;
using BlazerApp1.Models.Author;
using BlazerApp1.Models.Book;
using Microsoft.Build.Framework.Profiler;

namespace BlazerApp1.Configurations
{
    public class MapperConfig :Profile

    {
        public MapperConfig()
        {
                CreateMap<AuthorCreateDto, Author>().ReverseMap();
            CreateMap<AuthorUpdateDto, Author>().ReverseMap();
            CreateMap<AuthorReadOnlyDto, Author>().ReverseMap();
            CreateMap<BookCreateDto, Book>().ReverseMap();
            CreateMap<BookUpdateDto, Book>().ReverseMap();


            CreateMap< Book, BookReadOnlyDto>()
                .ForMember(q=>q.AuthorName, d => d.MapFrom(map=> $"{map.Author.FirstName}{map.Author.LastName}"))
                .ReverseMap();

            CreateMap<Book, BookDetailsDto>()
                .ForMember(q => q.AuthorName, d => d.MapFrom(map => $"{map.Author.FirstName}{map.Author.LastName}"))
                .ReverseMap();

        }
    }
}
