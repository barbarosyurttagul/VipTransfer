using System;
using Entities;

namespace Business.Abstract
{
	public interface IDepartureServ
	{
		public void Add(Departure departure);
		public List<Departure> GetAll();
	}
}

