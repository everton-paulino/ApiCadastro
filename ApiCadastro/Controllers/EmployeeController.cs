using Cadasatro.Core;
using Cadasatro.Core.Interface;
using Cadastro.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCadastro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController( IEmployeeService employeeService)
        {
            _employeeService = employeeService;   
        }

        [HttpPost]
        public IActionResult Post([FromBody] EmployeeRequest employee)
        {
            var employeeRequest = new EmployeeRequest();
            
            var employeeCreate = new Employee();

            employeeCreate.CompleteName = employee.CompleteName;
            employeeCreate.Function = employee.Function;
            employeeCreate.Session = employee.Session;
            employeeCreate.Company = employee.Company;

            var employeeResponse = _employeeService.CreateCompany(employeeCreate);

            return Ok(employeeCreate);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var employee = _employeeService.GetAll();

            return Ok(employee);
        }

        [HttpGet("{key}")]
        public  IActionResult GetByKey([FromRoute] string key)
        {
            var employee = _employeeService.GetCompanyByKey(key);

            if (employee is null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        [HttpPut("{key}")]
        public IActionResult Put(string key, [FromBody] EmployeeUpdate employeeUpdate)
        {
            var employee = _employeeService.GetCompanyByKey(key);

            if (employee is null)
            {
                return NotFound();
            }

            employee.Updated = DateTime.Now;
            employee.IsActive = employeeUpdate.IsActive;
            employee.Function = employeeUpdate.Function;
            employee.CompleteName = employeeUpdate.CompleteName;
            employee.Session = employeeUpdate.Session;
            employeeUpdate.Company = employeeUpdate.Company;

            var employeeResponse = _employeeService.UpdateCompany(employee);

            return Ok(employeeResponse);
        }

        [HttpDelete("{key}")]
        public IActionResult Delete(string key)
        {
            var employee = _employeeService.GetCompanyByKey(key);

            if (employee is null)
            {
                return NotFound();
            }

            var employeeresponse = _employeeService.DeleteCompany(key);

            return NoContent();

        }
    }
}
