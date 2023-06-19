using Microsoft.EntityFrameworkCore;
using VapeShopWebSite.Models;
using System;
public class EF_DataContext : DbContext
{
    public EF_DataContext(DbContextOptions<EF_DataContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseSerialColumns();
    }
    public DbSet<LiquidsModel> Liquids
    {
        get;
        set;
    }

    public DbSet<PodsModel> Pods
    {
        get;
        set;
    }

}