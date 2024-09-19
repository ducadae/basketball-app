using System;
using API.Models;
using Microsoft.EntityFrameworkCore;


namespace API.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
  public DbSet<Players> Players { get; set; }
  public DbSet<Users> Users { get; set; }
  public DbSet<FirstNames> FirstNames { get; set; }
  public DbSet<LastNames> LastNames { get; set; }
}
