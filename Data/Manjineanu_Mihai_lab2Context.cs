using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Manjineanu_Mihai_lab2.Models;

namespace Manjineanu_Mihai_lab2.Data
{
    public class Manjineanu_Mihai_lab2Context : DbContext
    {
        public Manjineanu_Mihai_lab2Context (DbContextOptions<Manjineanu_Mihai_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Manjineanu_Mihai_lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Manjineanu_Mihai_lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Manjineanu_Mihai_lab2.Models.Author> Author { get; set; }
    }
}
