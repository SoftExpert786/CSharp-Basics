using Microsoft.EntityFrameworkCore;
using PokemonAPI.Models;

namespace PokemonAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> countries { get; set; }
        public DbSet<Owner> owners { get; set; }
        public DbSet<Pokemon> pokemons { get; set; }
        public DbSet<pokemonCategory> pokemonCategories { get; set; }
        public DbSet<pokemonOwner> pokemonOwners { get; set; }
        public DbSet<Review> reviews { get; set; }
        public DbSet<Reviewer> reviewers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<pokemonCategory>().HasKey(pc => new { pc.PokemonId, pc.CategoryId });
            modelBuilder.Entity<pokemonCategory>().HasOne(p => p.Pokemon).WithMany(pc => pc.PokemonCategory).HasForeignKey(p => p.PokemonId);
            modelBuilder.Entity<pokemonCategory>().HasOne(p => p.Pokemon).WithMany(pc => pc.PokemonCategory).HasForeignKey(p => p.CategoryId);
            modelBuilder.Entity<pokemonOwner>().HasKey(po => new { po.PokemonId, po.OwnerId });
            modelBuilder.Entity<pokemonOwner>().HasOne(p => p.Pokemon).WithMany(po => po.PokemonOwner).HasForeignKey(p => p.PokemonId);
            modelBuilder.Entity<pokemonOwner>().HasOne(p => p.Pokemon).WithMany(po => po.PokemonOwner).HasForeignKey(p => p.OwnerId);

        }

    }
}