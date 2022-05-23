using System;
namespace Entities
{
	public class Departure
	{
        public int Id { get; set; }
        public string Name { get; set; }

        public Departure()
        {

        }
        public Departure(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

