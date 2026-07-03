using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    [ApiController]
    //[Route("api/[controller]")]
    [Route("api/Emp")]
    public class EmployeeController : ControllerBase
    {
        static List<string> employees = new()
        {
            "John",
            "David",
            "Alice",
            "Mary"
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(employees);
        }
    }
}