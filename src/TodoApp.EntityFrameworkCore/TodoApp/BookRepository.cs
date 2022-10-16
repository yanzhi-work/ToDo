using System;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace TodoApp;

public class BookRepository : EfCoreRepository<TodoAppDbContext, Book, Guid>, IBookRepository
{
    public BookRepository(IDbContextProvider<TodoAppDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Book>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}