using System;
using Business.Abstract;
using DataAccessLayer.Abstract;
using Entities;

namespace Business.Concrete
{
    public class DepartureImpl : IDepartureServ
    {
        private IDepartureDAL _departureDAL;

        public DepartureImpl(IDepartureDAL departureDAL)
        {
            _departureDAL = departureDAL;
        }

        public void Add(Departure departure)
        {
            _departureDAL.Add(departure);
        }

        public List<Departure> GetAll()
        {
            return _departureDAL.GetAll();
        }
    }
}

