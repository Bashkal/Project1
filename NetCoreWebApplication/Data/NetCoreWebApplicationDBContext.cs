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

        public DbSet<Guide> Guides { get; set; }
        public DbSet<Department> Departments { get; set; }
}
