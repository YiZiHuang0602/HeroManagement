using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HeroManagement.Models;

namespace HeroManagement.Data
{
    public class HeroManagementContext : DbContext
    {
        public HeroManagementContext (DbContextOptions<HeroManagementContext> options)
            : base(options)
        {
        }

        public DbSet<HeroManagement.Models.Hero> Hero { get; set; } = default!;
    }
}
