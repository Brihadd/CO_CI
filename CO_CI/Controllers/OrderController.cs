using CO_CI.Models;
using CO_CI.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace CO_CI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<Order[]> GetAllOrders()
        {
            try
            {
                return await _orderService.GetAllOrders();
            }
            catch (Exception ex)
            {
                // TODO: Log exception
                return new Order[] { };
            }
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<Order> GetOrderById(int id)
        {
            try
            {
                return await _orderService.GetOrderById(id);
            }
            catch (Exception ex)
            {
                // TODO: Log exception
                return new Order { };
            }
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateOrder([FromBody] Order order)
        {
            try
            {
                return Ok(await _orderService.CreateOrder(order));
            }
            catch (Exception ex)
            {
                // TODO: Log exception
                return null;
            }
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateOrder([FromBody] Order order)
        {
            try
            {
                return Ok(await _orderService.UpdateOrder(order));
            }
            catch (Exception ex)
            {
                // TODO: Log exception
                return null;
            }
        }
        [HttpDelete]
        [Route("[action]")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            try
            {
                if (await _orderService.DeleteOrder(id) == true)
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
