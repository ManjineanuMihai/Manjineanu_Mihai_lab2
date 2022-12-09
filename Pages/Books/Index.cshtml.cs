using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Manjineanu_Mihai_lab2.Models;

namespace Manjineanu_Mihai_lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Manjineanu_Mihai_lab2.Data.Manjineanu_Mihai_lab2Context _context;

        public IndexModel(Manjineanu_Mihai_lab2.Data.Manjineanu_Mihai_lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book
                    .Include(x => x.Publisher)
                    .Include(x => x.Author)
                    .ToListAsync(); 

            }
        }
    }
}
