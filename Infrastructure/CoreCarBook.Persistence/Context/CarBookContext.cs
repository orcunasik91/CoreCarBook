using CoreCarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreCarBook.Persistence.Context;
public class CarBookContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=127.0.0.1;Initial Catalog=CoreCarBook;User ID=sa;Password=Password1;TrustServerCertificate=True;");
    }
    public DbSet<About> Abouts { get; set; }
    public DbSet<Banner> Banners { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<CarDescription> CarDescriptions { get; set; }
    public DbSet<CarFeature> CarFeatures { get; set; }
    public DbSet<CarPricing> CarPricings { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<FooterAddress> FooterAddresses { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Pricing> Pricings { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<About>(entity =>
        {
            entity.Property(a => a.Title).HasMaxLength(100);
            entity.Property(a => a.ImageUrl).HasMaxLength(200);
        });
        modelBuilder.Entity<Banner>(entity =>
        {
            entity.Property(b => b.Title).HasMaxLength(100);
            entity.Property(b => b.Description).HasMaxLength(500);
            entity.Property(b => b.VideoDescription).HasMaxLength(500);
            entity.Property(b => b.VideoUrl).HasMaxLength(200);
        });
        modelBuilder.Entity<Brand>(entity =>
        {
            entity.Property(b => b.Name).HasMaxLength(100);
        });
        modelBuilder.Entity<Car>(entity =>
        {
            entity.Property(c => c.Model).HasMaxLength(100);
            entity.Property(c => c.CoverImageUrl).HasMaxLength(200);
            entity.Property(c => c.BigImageUrl).HasMaxLength(200);
            entity.Property(c => c.Transmission).HasMaxLength(100);
            entity.Property(c => c.Fuel).HasMaxLength(50);
        });
        modelBuilder.Entity<CarPricing>(entity =>
        {
            entity.Property(cp => cp.Price).HasColumnType("decimal(18,2)");
        });
        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(c => c.Name).HasMaxLength(100);
        });
        modelBuilder.Entity<Contact>(entity =>
        {
            entity.Property(c => c.Name).HasMaxLength(100);
            entity.Property(c => c.Email).HasMaxLength(100);
            entity.Property(c => c.Subject).HasMaxLength(100);
        });
        modelBuilder.Entity<Feature>(entity =>
        {
            entity.Property(f => f.Name).HasMaxLength(100);
        });
        modelBuilder.Entity<FooterAddress>(entity =>
        {
            entity.Property(fa => fa.Address).HasMaxLength(200);
            entity.Property(fa => fa.Email).HasMaxLength(100);
            entity.Property(fa => fa.PhoneNumber).HasMaxLength(20);
        });
        modelBuilder.Entity<Location>(entity =>
        {
            entity.Property(l => l.Name).HasMaxLength(100);
        });
        modelBuilder.Entity<Pricing>(entity =>
        {
            entity.Property(p => p.Name).HasMaxLength(100);
        });
        modelBuilder.Entity<Service>(entity =>
        {
            entity.Property(s => s.Title).HasMaxLength(100);
            entity.Property(s => s.IconUrl).HasMaxLength(200);
        });
        modelBuilder.Entity<SocialMedia>(entity =>
        {
            entity.Property(sm => sm.Name).HasMaxLength(100);
            entity.Property(sm => sm.Url).HasMaxLength(200);
            entity.Property(sm => sm.Icon).HasMaxLength(100);
        });
        modelBuilder.Entity<Testimonial>(entity =>
        {
            entity.Property(t => t.Name).HasMaxLength(100);
            entity.Property(t => t.Title).HasMaxLength(100);
            entity.Property(t => t.ImageUrl).HasMaxLength(200);
        });

        base.OnModelCreating(modelBuilder);
    }
}