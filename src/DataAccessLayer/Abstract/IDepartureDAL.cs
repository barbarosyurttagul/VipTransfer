using System;
using Entities;

namespace DataAccessLayer.Abstract
{
	public interface IDepartureDAL
	{
		public void Add(string name);

		public List<Departure> GetAll();
	}
}

