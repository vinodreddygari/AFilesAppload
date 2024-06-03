using AFilesAppload.AppModels;
using AFilesAppload.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AFilesAppload.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FileApploadController : ControllerBase
    {
        [HttpPost]
        [Route("Appload")]
        public IActionResult Appload([FromForm] FileApploadModel fileAppload)
        {
            if(fileAppload.formFile == null)
            {
                return BadRequest();
            }
            bool status=FileApp.PostFile(fileAppload.formFile);
            if(status)
            {
                return Ok("Successfully Apploaded");
            }
            else
            {
                return StatusCode(500);
            }
        }
    }
}
