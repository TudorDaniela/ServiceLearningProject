using Microsoft.EntityFrameworkCore;
using ServiceLearningProject.Models;
using System.Collections.Generic;

namespace ServiceLearningProject.Data
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options) { }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<StaffPersonel> Staff { get; set; }
    }
}
