using Microsoft.AspNetCore.Mvc;
using FirstWebAPI.Models;
using FirstWebAPI.Filters;

namespace FirstWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [CustomAuthFilter]
    public class EmployeeController : ControllerBase
    {
        private List<Employee> employees;

        public EmployeeController()
        {
            employees = GetStandardEmployeeList();
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "John",
                    Salary = 50000,
                    Permanent = true,
                    DateOfBirth = new DateTime(1998,5,15),

                    Department = new Department
                    {
                        Id = 1,
                        Name = "IT"
                    },

                    Skills = new List<Skill>
                    {
                        new Skill{Id=1,Name="C#"},
                        new Skill{Id=2,Name="SQL"}
                    }
                },

                new Employee
                {
                    Id = 2,
                    Name = "Alice",
                    Salary = 45000,
                    Permanent = false,
                    DateOfBirth = new DateTime(1999,3,10),

                    Department = new Department
                    {
                        Id = 2,
                        Name = "HR"
                    },

                    Skills = new List<Skill>
                    {
                        new Skill{Id=3,Name="Communication"}
                    }
                }
            };
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<Employee>> Get()
        {
            throw new Exception("Testing Exception Filter");

            //return Ok(employees);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            employees.Add(employee);

            return Ok(employee);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Employee employee)
        {
            return Ok(employee);
        }
    }
}