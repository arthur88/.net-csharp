using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwaggerUI.Models;

namespace dotNetSwaggerFullAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// Get list of all emplyess
        /// </summary>
        /// <returns>The list of Employees.</returns>
        // GET: api/Employee
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return GetEmployees();
        }

        //GET: api/employee/5
        [HttpGet("{id}", Name = "Get")]
        public Employee Get(int id)
        {
            return GetEmployees().Find(e => e.Id == id);
        }

        /// <summary>
        /// Crerates an Employee
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/Employee
        ///     {
        ///         "firstName": Adam
        ///         "lastName": Mercknick
        ///         EmailId: Adam@Mercknick.com
        ///     }
        /// </remarks>
        /// <param name="employee"></param>
        /// <returns>A new;y creaed employee</returns>
        /// <response code="201">Returns a new;y created employee</response>
        /// <response code="400">Error code: if item is null</response>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [Produces("application/json")]
        public Employee post([FromBody] Employee employee)
        {
            //logic to create new employee
            return new Employee();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee employee)
        {
            //logic to update employee
        }

        [HttpDelete("{id}")]
        public void delete(int id)
        {
            //logic to delete
        }

        private List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Smith",
                    EmailId = "john.smith@email.com"
                },
                new Employee()
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Doe",
                    EmailId = "jane.doe@gmail.com"
                }

            };
        }
    }

}
