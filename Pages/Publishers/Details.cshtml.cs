﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly Manjineanu_Mihai_lab2.Data.Manjineanu_Mihai_lab2Context _context;

        public DetailsModel(Manjineanu_Mihai_lab2.Data.Manjineanu_Mihai_lab2Context context)
        {
            _context = context;
        }

      public Models.Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Publisher == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else 
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}
