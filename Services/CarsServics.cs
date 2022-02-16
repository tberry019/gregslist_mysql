using System.Collections.Generic;
using gregslist_mysql.Models;

namespace gregslist_mysql.Services
{
  public class CarsService
  {
    private readonly CarsRepository _repo;

    public CarsService(CarsRepository repo)
    {
      _repo = repo;
    }
    internal List<Car> GetAll()
    {
      List<Car> cars = _repo.GetAll();
      return cars;
    }

  }
}