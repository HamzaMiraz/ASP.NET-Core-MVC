using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniEF.Models;

namespace UniEF.Data
{
    public class UniEFContext : DbContext
    {
        public UniEFContext (DbContextOptions<UniEFContext> options)
            : base(options)
        {
        }

        public DbSet<UniEF.Models.Student> Student { get; set; } = default!;
    }
}
