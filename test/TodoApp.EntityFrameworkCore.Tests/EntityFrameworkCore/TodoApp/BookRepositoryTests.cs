using System;
using System.Threading.Tasks;
using TodoApp;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace TodoApp.EntityFrameworkCore.TodoApp;

public class BookRepositoryTests : TodoAppEntityFrameworkCoreTestBase
{
    private readonly IBookRepository _bookRepository;

    public BookRepositoryTests()
    {
        _bookRepository = GetRequiredService<IBookRepository>();
    }

    /*
    [Fact]
    public async Task Test1()
    {
        await WithUnitOfWorkAsync(async () =>
        {
            // Arrange

            // Act

            //Assert
        });
    }
    */
}
