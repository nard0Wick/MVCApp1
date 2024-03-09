using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCApp1.Models;

namespace MVCApp1.Data
{
    public class MVCApp1Context : DbContext
    {
        public MVCApp1Context (DbContextOptions<MVCApp1Context> options)
            : base(options)
        {
        }

        public DbSet<MVCApp1.Models.Movie> Movie { get; set; } = default!;
    }
}
