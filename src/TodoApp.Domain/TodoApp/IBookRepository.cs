using System;
using Volo.Abp.Domain.Repositories;

namespace TodoApp;

public interface IBookRepository : IRepository<Book, Guid>
{
}
