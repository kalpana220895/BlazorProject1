using AutoMapper;
using BlazerApp1.Data;
using BlazerApp1.Models.Author;
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
        }
    }
}
