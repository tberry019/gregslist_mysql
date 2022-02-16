// using Microsoft.AspNetCore.Mvc;
// using gregsList_csharp.Services;
// using gregsList_csharp.Models;

// namespace gregsList_csharp.Controllers
// {
//   [ApiController]
//   [Route("api/[controller]")]
//   public class JobsController : ControllerBase
//   {
//     private readonly JobsService _js;
//     public JobsController(JobsService js)
//     {
//       _js = js;
//     }

//     [HttpGet]

//     public ActionResult<List<Job>> GetAll()
//     {
//       try
//       {
//         return Ok(_js.GetAll());
//       }
//       catch (System.Exception e)
//       {

//         return BadRequest(e.Message);
//       }
//     }
//     [HttpGet("{jobId}")]

//     public ActionResult<Job> GetById(string jobId)
//     {
//       try
//       {
//         Job foundJob = _js.GetById(jobId);
//         return Ok(foundJob);
//       }
//       catch (System.Exception e)
//       {

//         return BadRequest(e.Message);
//       }
//     }
//     [HttpPost]
//     public ActionResult<Job> Create([FromBody] Job newJob)
//     {
//       try
//       {
//         return Ok(_js.Create(newJob));
//       }
//       catch (System.Exception e)
//       {

//         return BadRequest(e.Message);
//       }
//     }
//     [HttpDelete("{jobId}")]
//     public ActionResult<Job> Delete(string jobId)
//     {
//       try
//       {
//         return Ok(_js.Delete(jobId));
//       }
//       catch (System.Exception e)
//       {

//         return BadRequest(e.Message);
//       }
//     }
//     [HttpPut("{jobId}")]
//     public ActionResult<Job> Edit([FromBody] Job editedJob, string jobId)
//     {
//       try
//       {
//         editedJob.Id = jobId;
//         Job updatedJob = _js.Edit(editedJob, jobId);
//         return Ok(updatedJob);
//       }
//       catch (System.Exception e)
//       {

//         return BadRequest(e.Message);
//       }
//     }
//   }
// }