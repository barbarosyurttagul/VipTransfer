using Business.Abstract;
using Business.Concrete;
using DataAccessLayer.Concrete;
using Entities;
using Xunit;

namespace XunitTestProject;

public class UnitTest1
{
    [Fact]
    public void ShouldDeparturesEqualToGivenNumber()
    {
        IDepartureServ service = new DepartureImpl(new DepartureDAL());
        service.Add(new Departure { Id = 4, Name = "Manavgat" });

        Assert.Equal(4, service.GetAll().Count);
    }
}
