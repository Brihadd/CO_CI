using CO_CI.Models;
using CO_CI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CO_CI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<Department[]> GetAllDepartments()
        {
            try
            {
                return await _departmentService.GetAllDepartments();
            }
            catch (Exception ex)
            {
                // TODO: Log exception
                return new Department[] { };
            }
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<Department> GetDepartmentById(int id)
        {
            try
            {
                return await _departmentService.GetDepartmentById(id);
            }
            catch (Exception ex)
            {
                // TODO: Log exception
                return new Department { };
            }
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateDepartment([FromBody] Department department)
        {
            try
            {
                return Ok(await _departmentService.CreateDepartment(department));
            }
            catch (Exception ex)
            {
                // TODO: Log exception
                return StatusCode(500);
            }
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateDepartment([FromBody] Department department)
        {
            try
            {
                return Ok(await _departmentService.UpdateDepartment(department));
            }
            catch (Exception ex)
            {
                // TODO: Log exception
                return StatusCode(500);
            }
        }
        [HttpDelete]
        [Route("[action]")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            try
            {
                if (await _departmentService.DeleteDepartment(id) == true)
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
                return StatusCode(500);
            }
        }

    }
}
