﻿using Microsoft.EntityFrameworkCore;
using NZWalksAPI.Models.Domain;

namespace NZWalksAPI.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User_Role>().HasOne(x => x.Role).WithMany(y => y.UserRoles)
                  .HasForeignKey(x => x.RoleId);

            modelBuilder.Entity<User_Role>().HasOne(x => x.User).WithMany(y => y.UserRoles)
                 .HasForeignKey(x => x.UserId);
        }
        public DbSet<Region> Regions { get; set; } // telling EF create a region table in database
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User_Role> User_Roles { get; set; }


    }
}