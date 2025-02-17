﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Models.Order;

namespace Talabat.Core.Services.Interfaces
{
    public interface IOrderService
    {
        Task<Order?> CreateOrderAsync(string BuyerEmail , string basketId , int DeliveryMethodId,Address ShippingAddress);
        Task<IReadOnlyList<Order>?> GetOrdersForSpecificUserAsync(string BuyerEmail);
        Task<Order?> GetOrderByIdForSpecificUserAsync(string BuyerEmail,int OrderId);
    }
}
