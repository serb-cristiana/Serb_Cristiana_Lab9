using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Serb_Cristiana_Lab8.Models;

namespace Serb_Cristiana_Lab8.Data
{
    public class Serb_Cristiana_Lab8Context : DbContext
    {
        public Serb_Cristiana_Lab8Context (DbContextOptions<Serb_Cristiana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Serb_Cristiana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Serb_Cristiana_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Serb_Cristiana_Lab8.Models.Category> Category { get; set; }
    }
}
