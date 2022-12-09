using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Manjineanu_Mihai_lab2.Data;
using Manjineanu_Mihai_lab2.Models;

namespace Manjineanu_Mihai_lab2.Pages.Publisher
{
    public class IndexModel : PageModel
    {
        private readonly Manjineanu_Mihai_lab2.Data.Manjineanu_Mihai_lab2Context _context;

        public IndexModel(Manjineanu_Mihai_lab2.Data.Manjineanu_Mihai_lab2Context context)
        {
            _context = context;
        }

        public IList<Models.Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
