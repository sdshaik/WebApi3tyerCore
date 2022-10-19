using BLL.Models;
using IObjects.Repository;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult GetAll()
        {
            IEnumerable<Employee> employees = _dataRepository.GetAll();
            return Ok(employees);
        }
       // get by id
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Getbyid(int id)
        {
            Employee employee = _dataRepository.Get(id);
            if (employee == null)
            {
                return NotFound("Employee Not Found");
            }
            return Ok(employee);
        }
        //add employee
        [HttpPost]
        public IActionResult AddEmp(Employee employee)
        {
          
            _dataRepository.Add(employee);
            return Ok();
        }
        //update Emp
        [HttpPut("{id}")]
         public IActionResult UpdateEmp(int id,Employee employee)
        {
            Employee employee1 = _dataRepository.Get(id);
            _dataRepository.Update(employee1,employee);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEmp(int id)
        {
            Employee employee = _dataRepository.Get(id);
            _dataRepository.Delete(employee);
            return NoContent();
        }
          
        
       
        

        


    }
}
