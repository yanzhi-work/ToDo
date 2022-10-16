using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApp;
using TodoApp.Dtos;
using TodoApp.Web.Pages.TodoApp.Book.ViewModels;

namespace TodoApp.Web.Pages.TodoApp.Book;

public class EditModalModel : TodoAppPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public EditBookViewModel ViewModel { get; set; }

    private readonly IBookAppService _service;

    public EditModalModel(IBookAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<BookDto, EditBookViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<EditBookViewModel, UpdateBookDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}