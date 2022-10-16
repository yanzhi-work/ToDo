using System;
using TodoApp.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace TodoApp;

public interface IBookAppService :
    ICrudAppService< 
        BookDto, 
        Guid, 
        PagedAndSortedResultRequestDto,
        CreateBookDto,
        UpdateBookDto>
{

}