using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    [Route(template: "[controller]")]
    public class DepartmentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("Get All Student");
        }

        [HttpGet(template:"{code}")]
        public IActionResult GetA(string code)
        {
            return Ok("Get this " + code + " department data");
        }

        [HttpPost]
        public IActionResult Insert()
        {
            return Ok("insert new department");
        }

        [HttpPut(template: "{code}")]
        public IActionResult Update(string code)
        {
            return Ok("Update this " + code + " department data");
        }

        [HttpDelete(template: "{code}")]
        public IActionResult Delete(string code)
        {
            return Ok("Delete this " + code + " department data");
        }
    }
}
