using Microsoft.AspNetCore.Mvc;
using gregslist_mysql.Services;
using System.Collections.Generic;
using gregslist_mysql.Models;

namespace gregsList_csharp.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CarsController : ControllerBase
  {
    private readonly CarsService _cs;
    public CarsController(CarsService cs)
    {
      _cs = cs;
    }

    [HttpGet]

    public ActionResult<List<Car>> GetAll()
    {
      try
      {
        return Ok(_cs.GetAll());
      }
      catch (System.Exception e)
      {

        return BadRequest(e.Message);
      }
    }
    // [HttpGet("{carId}")]

    // public ActionResult<Car> GetById(string carId)
    // {
    //   try
    //   {
    //     Car foundCar = _cs.GetById(carId);
    //     return Ok(foundCar);
    //   }
    //   catch (System.Exception e)
    //   {

    //     return BadRequest(e.Message);
    //   }
    // }
    // [HttpPost]
    // public ActionResult<Car> Create([FromBody] Car newCar)
    // {
    //   try
    //   {
    //     return Ok(_cs.Create(newCar));
    //   }
    //   catch (System.Exception e)
    //   {

    //     return BadRequest(e.Message);
    //   }
    // }
    // [HttpDelete("{carId}")]
    // public ActionResult<Car> Delete(string carId)
    // {
    //   try
    //   {
    //     return Ok(_cs.Delete(carId));
    //   }
    //   catch (System.Exception e)
    //   {

    //     return BadRequest(e.Message);
    //   }
    // }
    // [HttpPut("{carId}")]
    // public ActionResult<Car> Edit([FromBody] Car editedCar, string carId)
    // {
    //   try
    //   {
    //     editedCar.Id = carId;
    //     Car updatedCar = _cs.Edit(editedCar, carId);
    //     return Ok(updatedCar);
    //   }
    //   catch (System.Exception e)
    //   {

    //     return BadRequest(e.Message);
    //   }
    // }
  }
}