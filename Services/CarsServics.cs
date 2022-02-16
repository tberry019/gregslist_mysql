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
    internal Car GetById(int id)
    {
      Car car = _repo.GetById(id);
      if (car == null)
      {
        throw new System.Exception("Invalid Id");
      }
      return car;
    }
    internal Car Create(Car newCar)
    {
      Car car = _repo.Create(newCar);
      return car;
    }
    internal void Delete(int id)
    {
      GetById(id);
      _repo.Delete(id);
    }
  }
}