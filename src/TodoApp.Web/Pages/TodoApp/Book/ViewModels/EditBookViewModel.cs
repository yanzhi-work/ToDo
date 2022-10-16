using System;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.Web.Pages.TodoApp.Book.ViewModels;

public class EditBookViewModel
{
    [Display(Name = "BookName")]
    public string Name { get; set; }

    [Display(Name = "BookPublishDate")]
    public DateTime PublishDate { get; set; }

    [Display(Name = "BookPrice")]
    public float Price { get; set; }
}
