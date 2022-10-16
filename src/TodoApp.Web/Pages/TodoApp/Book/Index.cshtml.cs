using System.Threading.Tasks;

namespace TodoApp.Web.Pages.TodoApp.Book;

public class IndexModel : TodoAppPageModel
{
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}
