using AutoMapper;
using BookStoreApi.Models.Entities;
using BookStoreApi.Models.Repositories;

namespace BookStoreApi.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateBookModel, Book>();
            CreateMap<BooksModel, Book>();
            CreateMap<BookModel, Book>();
        }
    }
}
