using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorWebApp1.Model;

namespace BlazorWebApp3.Data
{
    public class BlazorWebApp3Context : DbContext
    {
        public BlazorWebApp3Context (DbContextOptions<BlazorWebApp3Context> options)
            : base(options)
        {
        }

        public DbSet<BlazorWebApp1.Model.Human> Human { get; set; } = default!;
    }
}
