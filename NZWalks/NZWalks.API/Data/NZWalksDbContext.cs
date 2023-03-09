﻿using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options): base(options)
        {

        }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Walkcs> Walkcs { get; set; }
    public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
