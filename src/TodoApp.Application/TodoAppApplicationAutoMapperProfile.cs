using TodoApp;
using TodoApp.Dtos;
using AutoMapper;

namespace TodoApp;

public class TodoAppApplicationAutoMapperProfile : Profile
{
    public TodoAppApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Book, BookDto>();
        CreateMap<CreateBookDto, Book>(MemberList.Source);
        CreateMap<UpdateBookDto, Book>(MemberList.Source);
    }
}
