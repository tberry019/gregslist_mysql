// using Microsoft.AspNetCore.Mvc;
// using gregsList_csharp.Services;
// using gregsList_csharp.Models;

// namespace gregsList_csharp.Controllers
// {
//   [ApiController]
//   [Route("api/[controller]")]
//   public class HousesController : ControllerBase
//   {
//     private readonly HousesService _hs;
//     public HousesController(HousesService hs)
//     {
//       _hs = hs;
//     }

//     [HttpGet]

//     public ActionResult<List<House>> GetAll()
//     {
//       try
//       {
//         return Ok(_hs.GetAll());
//       }
//       catch (System.Exception e)
//       {

//         return BadRequest(e.Message);
//       }
//     }
//     [HttpGet("{houseId}")]

//     public ActionResult<House> GetById(string houseId)
//     {
//       try
//       {
//         House foundHouse = _hs.GetById(houseId);
//         return Ok(foundHouse);
//       }
//       catch (System.Exception e)
//       {

//         return BadRequest(e.Message);
//       }
//     }
//     [HttpPost]
//     public ActionResult<House> Create([FromBody] House newHouse)
//     {
//       try
//       {
//         return Ok(_hs.Create(newHouse));
//       }
//       catch (System.Exception e)
//       {

//         return BadRequest(e.Message);
//       }
//     }
//     [HttpDelete("{houseId}")]
//     public ActionResult<House> Delete(string houseId)
//     {
//       try
//       {
//         return Ok(_hs.Delete(houseId));
//       }
//       catch (System.Exception e)
//       {

//         return BadRequest(e.Message);
//       }
//     }
//     [HttpPut("{houseId}")]
//     public ActionResult<House> Edit([FromBody] House editedHouse, string houseId)
//     {
//       try
//       {
//         editedHouse.Id = houseId;
//         House updatedHouse = _hs.Edit(editedHouse, houseId);
//         return Ok(updatedHouse);
//       }
//       catch (System.Exception e)
//       {

//         return BadRequest(e.Message);
//       }
//     }
//   }
// }