using CO_CI.Models;
using CO_CI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CO_CI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<Employee[]> GetAllEmployees()
        {
            try
            {
                return await _employeeService.GetAllEmployees();
            }
            catch (Exception ex)
            {
                // TODO: Log exception
                return new Employee[] { };
            }
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<Employee> GetEmployeeById(int id)
        {
            try
            {
                return await _employeeService.GetEmployeeById(id);
            }
            catch (Exception ex)
            {
                // TODO: Log exception
                return new Employee { };
            }
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateEmployee([FromBody] Employee employee)
        {
            try
            {
                return Ok(await _employeeService.CreateEmployee(employee));
            }
            catch (Exception ex)
            {
                // TODO: Log exception
                return null;
            }
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateEmployee([FromBody] Employee employee)
        {
            try
            {
                return Ok(await _employeeService.UpdateEmployee(employee));
            }
            catch (Exception ex)
            {
                // TODO: Log exception
                return null;
            }
        }
        [HttpDelete]
        [Route("[action]")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            try
            {
                if (await _employeeService.DeleteEmployee(id) == true)
                {
                    return new OkResult();
                }
                else
                {
                    return new BadRequestResult();
                }
            }
            catch (Exception ex)
            {
                // TODO: Log exception
                return null;
            }
        }
    }
}
