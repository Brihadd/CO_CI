﻿using CO_CI.Models;
using Microsoft.EntityFrameworkCore;

namespace CO_CI.Services
{
    public class OrderService : IOrderService
    {
        private readonly DataContext _context;

        public OrderService(DataContext context)
        {
            _context = context;
        }
        public async Task<Order> CreateOrder(Order order)
        {
            order.Created = DateTime.Now;
            order.Updated = DateTime.Now;
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();

            return order;
        }

        public async  Task<bool> DeleteOrder(int orderId)
        {
            var orderToDelete = await _context.Orders.
                 Where(x => x.Id == orderId).FirstOrDefaultAsync();
            if (orderToDelete != null)
            {
                _context.Orders.Remove(orderToDelete);
                await _context.SaveChangesAsync();
                return true;
            }
            else
                return false;
        }

        public async Task<Order[]> GetAllOrders()
        {
            return await _context.Orders.ToArrayAsync();
        }

        public async Task<Order> GetOrderById(int orderId)
        {
            return await _context.Orders.Where(x => x.Id == orderId).FirstAsync();
        }

        public async Task<Order> UpdateOrder(Order order)
        {
            var orderToUpdate = await _context.Orders.
                Where(x => x.Id == order.Id).FirstOrDefaultAsync();

            if (orderToUpdate != null)
            {
                orderToUpdate.Updated = DateTime.Now;
                orderToUpdate.OrderCode = order.OrderCode;
                orderToUpdate.ContractorId= order.ContractorId;
                orderToUpdate.ContractorName = order.ContractorName;
                orderToUpdate.DepartmentId = order.DepartmentId;
                orderToUpdate.DepartmentName= order.DepartmentName;
                orderToUpdate.StartDate = order.StartDate;
                orderToUpdate.EndDate = order.EndDate;
                orderToUpdate.HourRate = order.HourRate;
                orderToUpdate.MDRate= order.MDRate;
                orderToUpdate.OrderState = order.OrderState;
                orderToUpdate.Info = order.Info;


                await _context.SaveChangesAsync();

                return order;
            }

            return null;
        }
    }
}
