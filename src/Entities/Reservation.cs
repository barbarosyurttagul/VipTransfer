using System;
namespace Entities
{
	public class Reservation
	{
        public int Id { get; set; }
        public Departure Departure { get; set; }
        public Arrival Arrival { get; set; }
        public DateTime DepartureTime { get; set; }
        public string? FlightNumber { get; set; }
    }
}

