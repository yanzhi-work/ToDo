using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApp;
using TodoApp.Dtos;
using TodoApp.Web.Pages.TodoApp.Book.ViewModels;

namespace TodoApp.Web.Pages.TodoApp.Book;

public class CreateModalModel : TodoAppPageModel
{
    [BindProperty]
    public CreateBookViewModel ViewModel { get; set; }

    private readonly IBookAppService _service;

    public CreateModalModel(IBookAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateBookViewModel, CreateBookDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}