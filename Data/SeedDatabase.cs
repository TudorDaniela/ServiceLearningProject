using ServiceLearningProject.Models;

namespace ServiceLearningProject.Data
{
    public static class SeedDatabase
    {
        public static void Initialize(HotelDbContext context)
        {
            if (context.Rooms.Any()) return;

            context.Rooms.AddRange(
                new Room { RoomNumber = 101, Type = "Single", IsAvailable = false },
                new Room { RoomNumber = 102, Type = "Double", IsAvailable = true },
                new Room { RoomNumber = 201, Type = "Suite", IsAvailable = true }
            );

            context.Guests.AddRange(
                new Guest { FullName = "Alice Smith", Email = "alice@example.com", Phone = "123-456-7890" },
                new Guest { FullName = "John Doe", Email = "john@example.com", Phone = "987-654-3210" }
            );

            context.Bookings.AddRange(
                new Booking { GuestName = "Alice Smith", RoomNumber = 101, CheckIn = DateTime.Today, CheckOut = DateTime.Today.AddDays(3) },
                new Booking { GuestName = "John Doe", RoomNumber = 202, CheckIn = DateTime.Today.AddDays(-1), CheckOut = DateTime.Today.AddDays(1) }
            );

            context.Staff.AddRange(
                new StaffPersonel { Name = "Emily Johnson", Position = "Manager", Contact = "emily@hotel.com" },
                new StaffPersonel { Name = "Mike Brown", Position = "Receptionist", Contact = "mike@hotel.com" }
            );

            context.SaveChanges();
        }
    }
 }
