using System;
using DatingApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApi.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; }
}
