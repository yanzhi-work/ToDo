using TodoApp.Dtos;
using TodoApp.Web.Pages.TodoApp.Book.ViewModels;
using AutoMapper;

namespace TodoApp.Web;

public class TodoAppWebAutoMapperProfile : Profile
{
    public TodoAppWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<BookDto, EditBookViewModel>();
        CreateMap<CreateBookViewModel, CreateBookDto>();
        CreateMap<EditBookViewModel, UpdateBookDto>();
    }
}
