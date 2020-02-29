using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class StarWarsDbContext : DbContext, IStarWarsDbContext
    {
        public DbSet<Film> Films { get; set; }
    }
}
