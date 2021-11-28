using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tarnavean_Ilinca_Lab8.Models;

namespace Tarnavean_Ilinca_Lab8.Data
{
    public class Tarnavean_Ilinca_Lab8Context : DbContext
    {
        public Tarnavean_Ilinca_Lab8Context (DbContextOptions<Tarnavean_Ilinca_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Tarnavean_Ilinca_Lab8.Models.Book> Book { get; set; }

        public DbSet<Tarnavean_Ilinca_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Tarnavean_Ilinca_Lab8.Models.Category> Category { get; set; }
    }
}
