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
    [HttpGet("{id}")]

    public ActionResult<Car> GetById(int id)
    {
      try
      {
        Car foundCar = _cs.GetById(id);
        return Ok(foundCar);
      }
      catch (System.Exception e)
      {

        return BadRequest(e.Message);
      }
    }
    [HttpPost]
    public ActionResult<Car> Create([FromBody] Car newCar)
    {
      try
      {
        return Ok(_cs.Create(newCar));
      }
      catch (System.Exception e)
      {

        return BadRequest(e.Message);
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<Car> Delete(int id)
    {
      try
      {
        _cs.Delete(id);
        return Ok("deleted");
      }
      catch (System.Exception e)
      {

        return BadRequest(e.Message);
      }
    }
    // [HttpPut("{id}")]
    // public ActionResult<Car> Edit([FromBody] Car editedCar, string id)
    // {
    //   try
    //   {
    //     editedCar.Id = id;
    //     Car updatedCar = _cs.Edit(editedCar, id);
    //     return Ok(updatedCar);
    //   }
    //   catch (System.Exception e)
    //   {

    //     return BadRequest(e.Message);
    //   }
    // }
  }
}