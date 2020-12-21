using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BDefenderApp.Model;

namespace BDefenderApp.Data
{
    public class BDefenderAppContext : DbContext
    {
        public BDefenderAppContext (DbContextOptions<BDefenderAppContext> options)
            : base(options)
        {
        }

        public DbSet<BDefenderApp.Model.User> User { get; set; }
    }
}
