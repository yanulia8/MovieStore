﻿using Microsoft.EntityFrameworkCore;
using MovieStore.Models;

namespace MovieStore.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Action" },
                new Genre { Id = 2, Name = "Drama" },
                new Genre { Id = 3, Name = "Crime" },
                new Genre { Id = 4, Name = "History" },
                new Genre { Id = 5, Name = "SciFi" }
                );
        }
    }
}