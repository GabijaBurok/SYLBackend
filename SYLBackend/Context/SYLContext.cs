using Microsoft.EntityFrameworkCore;
using SYLBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SYLBackend.Context
{
    public class SYLContext : DbContext
    {
        public SYLContext(DbContextOptions<SYLContext> options) : base(options)
        {

        }

        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Shops> Shops { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}