using ASP_NET.Models;
using AutoMapper;

namespace ASP_NET.db
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<BookDTO, Book>().ReverseMap();
        }
    }
}
