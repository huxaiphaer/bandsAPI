using System;
using BandAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace BandAPI.Controllers
{
    public class BandAlbumContext : DbContext
    {
        public BandAlbumContext(DbContextOptions<BandAlbumContext> options) : base(options)
        {
        }

        public DbSet<Band> Bands { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {


            modelBuilder.Entity<Band>().HasData(
                new Band()
                {
                    Id = Guid.Parse("3c0b8198-c7c5-4521-bdd1-cff61b98a05f"),
                    Name = "Metallica",
                    Founded = new DateTime(1980,1,1),
                    MainGenre = "Heavy Metal"
                },
                new Band()
                {
                    Id = Guid.Parse("0ecca8db-3116-40e3-8178-7a45efa5edf7"),
                    Name = "Guns n Roses",
                    Founded = new DateTime(1985, 2, 1),
                    MainGenre = "Heavy Metal"
                },
                new Band()
                {
                    Id = Guid.Parse("aece25e6-3785-4840-a7d7-3dd18f209dab"),
                    Name = "Metallica",
                    Founded = new DateTime(1980, 1, 2),
                    MainGenre = "Heavy Metal"
                },
                 new Band()
                 {
                     Id = Guid.Parse("7d5577a5-abf1-430d-8591-58a50b58af80"),
                     Name = "Metallica",
                     Founded = new DateTime(1980, 1, 2),
                     MainGenre = "Alternative"
                 },
                 new Band()
                 {
                     Id = Guid.Parse("b5262e7b-4ffe-4a62-a2f5-7c4f090eeb40"),
                     Name = "A - ha ",
                     Founded = new DateTime(1980, 1, 2),
                     MainGenre = "Pop"
                 }
                );


            modelBuilder.Entity<Album>().HasData(

                new Album() {
                    Id = Guid.Parse("6543677d-0262-4f6d-a06e-45a4fb9ac9b0"),
                    Title = "Master of puppets",
                    Description ="One of the best heavy metal albums ever",
                    BandId = Guid.Parse("3c0b8198-c7c5-4521-bdd1-cff61b98a05f")
                },
                new Album()
                {
                    Id = Guid.Parse("9554622a-57cc-4a2d-a648-988e47a1fad4"),
                    Title = "Appetite for Destruction",
                    Description = "Amaznig Rock album with Raw sound",
                    BandId = Guid.Parse("0ecca8db-3116-40e3-8178-7a45efa5edf7")
                },
                new Album()
                {
                    Id = Guid.Parse("fb89faa5-ffab-43f7-b8a6-19fa0a8ba213"),
                    Title = "Huxy and griill",
                    Description = "Amaznig Rock album with Raw sound",
                    BandId = Guid.Parse("aece25e6-3785-4840-a7d7-3dd18f209dab")
                },
                new Album()
                {
                    Id = Guid.Parse("4ebfdc70-4d79-4c43-96a4-d0eda3cd6939"),
                    Title = "Huxy and griill",
                    Description = "Amaznig Rock album with Raw sound",
                    BandId = Guid.Parse("7d5577a5-abf1-430d-8591-58a50b58af80")
                },
                 new Album()
                 {
                     Id = Guid.Parse("341b0995-b0cf-437f-9ba6-de15d0c430a4"),
                     Title = "Jaleel and grill",
                     Description = "Jaleel is a good boy Rock album with Raw sound",
                     BandId = Guid.Parse("b5262e7b-4ffe-4a62-a2f5-7c4f090eeb40")
                 }
                );


            base.OnModelCreating(modelBuilder);
        }
    }


}
