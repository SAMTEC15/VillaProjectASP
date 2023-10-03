using MagicVilla.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicVilla.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "James",
                    Details = "Great",
                    Occupancy = 4,
                    Sqft = 550,
                    Amenity = "Amw",
                    Rate = 200,
                    ImageUrl = "Beauitiful",
                    CreateAt = DateTime.Now
                },
                new Villa
                {
                    Id = 2,
                    FirstName = "Paul",
                    LastName = "Philip",
                    Details = "Excelent",
                    Occupancy = 4,
                    Sqft = 500,
                    Amenity = "Amw",
                    Rate = 300,
                    ImageUrl = "Beauitiful",
                    CreateAt = DateTime.Now
                },
                new Villa
                {
                    Id = 3,
                    FirstName = "Peter",
                    LastName = "Wisdom",
                    Details = "Elijah",
                    Occupancy = 4,
                    Sqft = 550,
                    Amenity = "Amw",
                    Rate = 300,
                    ImageUrl = "Beauitiful",
                    CreateAt = DateTime.Now
                },
                new Villa
                {
                    Id = 4,
                    FirstName = "Emma",
                    LastName = "Sam",
                    Details = "Chika",
                    Occupancy = 4,
                    Sqft = 500,
                    Amenity = "Amw",
                    Rate = 300,
                    ImageUrl = "Florence",
                    CreateAt = DateTime.Now
                },
                new Villa
                {
                    Id = 5,
                    FirstName = "Joy",
                    LastName = "Miracle",
                    Details = "Ebube",
                    Occupancy = 4,
                    Sqft = 550,
                    Amenity = "Amw",
                    Rate = 300,
                    ImageUrl = "Faith",
                    CreateAt = DateTime.Now
                });

        }
    }
}  
