using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TodoApp
{
    public class Book : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }

    protected Book()
    {
    }

    public Book(
        Guid id,
        string name,
        DateTime publishDate,
        float price
    ) : base(id)
    {
        Name = name;
        PublishDate = publishDate;
        Price = price;
    }
    }
}
