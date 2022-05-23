using System;
using Business.Abstract;
using Business.Concrete;
using DataAccessLayer.Concrete;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace VipTransfer.WebAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class DepartureController
	{
        IDepartureServ service = new DepartureImpl(new DepartureDAL());

        [HttpGet(Name = "GetDepartures")]
        public IEnumerable<Departure> Get()
        {
            return service.GetAll();
        }
    }
}

