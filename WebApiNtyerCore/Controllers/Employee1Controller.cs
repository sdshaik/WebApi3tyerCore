using Microsoft.AspNetCore.Mvc;
using BLL.Models;
using IObjects.Repository;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Security.Cryptography.X509Certificates;

namespace WebApiNtyerCore.Controllers
{

    [ApiController]
    [Route("employee1")]
    public class Employee1Controller : ControllerBase
    {

        private readonly IDataRepository<Employee> _dataRepository;
        public Employee1Controller(IDataRepository<Employee> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        [HttpGet]
        //get all employee
        public IActionResult Get()
        {
            IEnumerable<Employee> employees = _dataRepository.GetAll();
            return Ok(employees);
        }
       // get by id
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            Employee employee = _dataRepository.Get(id);
            if (employee == null)
            {
                return NotFound("Employee Not Found");
            }
            return Ok(employee);
        }
        //add employee
        public IActionResult Post(Employee employee)
        {
          
            _dataRepository.Add(employee);
            return Ok();
        }
            //update Emp
            [HttpPut("{id}")]
            public IActionResult Put(int id,Employee employee)
        {
            Employee employee1 = _dataRepository.Get(id);
            _dataRepository.Update(employee1,employee);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Employee employee = _dataRepository.Get(id);
            _dataRepository.Delete(employee);
            return NoContent();
        }
          
        
       
        

        


    }
}
