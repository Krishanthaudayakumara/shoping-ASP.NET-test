﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OnlineShopping2.Models
{
    public class EFOrder:IOrder
    {
        private ApplicationDbContext context;

        public EFOrder(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Order> Orders => context.Orders
            .Include(o => o.Lines)
            .ThenInclude(l => l.Product);
        public void SaveOrder(Order order)
        {
            context.AttachRange(order.Lines.Select(l => l.Product));
            if(order.OrderID==0)
            {
                context.Orders.Add(order);
            }
            context.SaveChanges();
        }
            
    }
}
