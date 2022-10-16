using System;

namespace TodoApp.Dtos;

[Serializable]
public class UpdateBookDto
{
    public string Name { get; set; }

    public DateTime PublishDate { get; set; }

    public float Price { get; set; }
}