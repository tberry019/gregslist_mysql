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
      string sql = "SELECRT * FROM cars;";
      List<Car> cars = _db.Query<Car>(sql).ToList();
      return cars;
    }
  }
}