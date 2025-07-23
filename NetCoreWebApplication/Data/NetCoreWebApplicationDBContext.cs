using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCoreWebApplication.Models;

    public class NetCoreWebApplicationDBContext : DbContext
    {
        public NetCoreWebApplicationDBContext (DbContextOptions<NetCoreWebApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<NetCoreWebApplication.Models.Guide> Guide { get; set; } = default!;
        public DbSet<NetCoreWebApplication.Models.Department> Department { get; set; } = default!;
}
