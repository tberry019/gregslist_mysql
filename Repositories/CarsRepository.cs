using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using gregslist_mysql.Models;

namespace gregslist_mysql
{
  public class CarsRepository
  {
    private readonly IDbConnection _db;
    public CarsRepository(IDbConnection db)
    {
      _db = db;
    }
    internal List<Car> GetAll()
    {
      string sql = "SELECT * FROM cars;";
      List<Car> cars = _db.Query<Car>(sql).ToList();
      return cars;
    }
    internal Car GetById(int id)
    {
      string sql = "SELECT * FROM cars WHERE id = @id";
      Car car = _db.QueryFirstOrDefault<Car>(sql, new { id });
      return car;
    }
    internal Car Create(Car newCar)
    {
      string sql = @"
        INSERT INTO cars
          (price, make, model, modelYear, description, imgurl)
          VALUES
          (@Price, @Make, @Model, @ModelYear, @Description, @ImgUrl);
          SELECT LAST_INSERT_ID();
          ";
      int id = _db.ExecuteScalar<int>(sql, newCar);
      newCar.Id = id;
      return newCar;
    }
    internal void Delete(int id)
    {
      string sql = "DELETE FROM cars WHERE id = @id LIMIT 1";
      int modified = _db.Execute(sql, new { id });
      if (modified == 0)
      {
        throw new System.Exception("Something is wrong mayne");
      }
    }
    internal void Update(Car original)
    {
      string sql = @"
      UPDATE cars
      SET
        price = @Price,
        make = @Make,
        model = @Model,
        modelYear = @ModelYear,
        description = @Description,
        imgurl = @ImgUrl
      WHERE id = @Id;
      ";
      _db.Execute(sql, original);
    }
  }
}