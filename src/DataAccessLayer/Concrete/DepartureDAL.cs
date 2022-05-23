using System;
using DataAccessLayer.Abstract;
using Entities;

namespace DataAccessLayer.Concrete
{
    public class DepartureDAL : IDepartureDAL
    {
        List<Departure> departures = new();

        public DepartureDAL()
        {
            departures.Add(new Departure { Id = 1, Name = "Antalya" });
            departures.Add(new Departure { Id = 2, Name = "Alanya" });
            departures.Add(new Departure { Id = 3, Name = "Gazipaşa" });
        }

        public void Add(Departure departure)
        {
            departures.Add(departure);

        }

        public List<Departure> GetAll()
        {
            return departures;
        }
    }
}

