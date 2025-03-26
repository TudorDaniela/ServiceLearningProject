namespace ServiceLearningProject.Models
{
    public static class HotelData
    {
        public static List<Booking> GetBookings() => new()
        {
            new Booking { GuestName = "Alice Smith", RoomNumber = 101, CheckIn = DateTime.Today, CheckOut = DateTime.Today.AddDays(3) },
            new Booking { GuestName = "John Doe", RoomNumber = 202, CheckIn = DateTime.Today.AddDays(-1), CheckOut = DateTime.Today.AddDays(1) },
        };

        public static List<Room> GetRooms() => new()
        {
            new Room { RoomNumber = 101, Type = "Single", IsAvailable = false },
            new Room { RoomNumber = 102, Type = "Double", IsAvailable = true },
            new Room { RoomNumber = 201, Type = "Suite", IsAvailable = true },
        };

        public static List<Guest> GetGuests() => new()
        {
            new Guest { FullName = "Alice Smith", Email = "alice@example.com", Phone = "123-456-7890" },
            new Guest { FullName = "John Doe", Email = "john@example.com", Phone = "987-654-3210" },
        };

        public static List<StaffPersonel> GetStaff() => new()
        {
            new StaffPersonel { Name = "Emily Johnson", Position = "Manager", Contact = "emily@hotel.com" },
            new StaffPersonel { Name = "Mike Brown", Position = "Receptionist", Contact = "mike@hotel.com" },
        };
    }

    public class Booking
    {
        public string GuestName { get; set; }
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }

    public class Room
    {
        public int RoomNumber { get; set; }
        public string Type { get; set; }
        public bool IsAvailable { get; set; }
    }

    public class Guest
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    public class StaffPersonel
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Contact { get; set; }
    }
}
