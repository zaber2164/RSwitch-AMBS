﻿using Microsoft.EntityFrameworkCore;
using RSwitch.AMBS.Model.User;
using System.Reflection;

namespace RSwitch.AMBS.DAL
{
    public class RswitchDbContext : DbContext
    {
        public RswitchDbContext(DbContextOptions<RswitchDbContext> options) : base(options)
        {

        }
        //tables
        public DbSet<LoginUser> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
