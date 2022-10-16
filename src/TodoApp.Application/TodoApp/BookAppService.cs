using System;
using TodoApp.Permissions;
using TodoApp.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace TodoApp;

public class BookAppService : CrudAppService<Book, BookDto, Guid, PagedAndSortedResultRequestDto, CreateBookDto, UpdateBookDto>,
    IBookAppService
{
    protected override string GetPolicyName { get; set; } = TodoAppPermissions.Book.Default;
    protected override string GetListPolicyName { get; set; } = TodoAppPermissions.Book.Default;
    protected override string CreatePolicyName { get; set; } = TodoAppPermissions.Book.Create;
    protected override string UpdatePolicyName { get; set; } = TodoAppPermissions.Book.Update;
    protected override string DeletePolicyName { get; set; } = TodoAppPermissions.Book.Delete;

    private readonly IBookRepository _repository;

    public BookAppService(IBookRepository repository) : base(repository)
    {
        _repository = repository;
    }
}
