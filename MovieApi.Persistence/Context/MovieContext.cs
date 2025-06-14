﻿using Microsoft.EntityFrameworkCore;
using MovieApi.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MovieApi.Persistence.Identity;

namespace MovieApi.Persistence.Context
{
    public class MovieContext : IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-IGIN0GLR\\SQLEXPRESS;initial Catalog=ApiMovieDb;integrated Security=true;TrustServerCertificate=true");
        }

        public DbSet<Tag> Tags { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Cast> Casts { get; set; }
    }
}
