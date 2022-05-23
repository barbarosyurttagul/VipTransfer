using System;
using Entities;

namespace DataAccessLayer.Abstract
{
	public interface IDepartureDAL
	{
		public void Add(Departure departure);

		public List<Departure> GetAll();
	}
}

