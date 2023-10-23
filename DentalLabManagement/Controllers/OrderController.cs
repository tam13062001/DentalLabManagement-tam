﻿using DentalLabManagement.BusinessTier.Constants;
using DentalLabManagement.BusinessTier.Enums;
using DentalLabManagement.BusinessTier.Payload.Order;
using DentalLabManagement.API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DentalLabManagement.API.Controllers
{
    [ApiController]
    public class OrderController : BaseController<OrderController>
    {
        private readonly IOrderService _orderService;

        public OrderController(ILogger<OrderController> logger, IOrderService orderService) : base(logger)
        {
            _orderService = orderService;
        }

        [HttpPost(ApiEndPointConstant.Order.OrdersEndPoint)]
        [ProducesResponseType(typeof(CreateOrderResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateNewOrder (CreateOrderRequest order)
        {
            var response = await _orderService.CreateNewOrder(order);
            return Ok(response);
        }

        [HttpGet(ApiEndPointConstant.Order.OrderEndPoint)]
        [ProducesResponseType(typeof(GetOrderDetailResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetOrderDetail(int id)
        {
            var response = await _orderService.GetOrderTeethDetail(id);
            return Ok(response);
        }

        [HttpGet(ApiEndPointConstant.Order.OrdersEndPoint)]
        [ProducesResponseType(typeof(GetOrderDetailResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetOrders(string? invoiceId, OrderMode? mode,OrderStatus? status, int page, int size)
        {
            var response = await _orderService.GetOrders(invoiceId, mode, status, page, size);
            return Ok(response);
        }

        [HttpPut(ApiEndPointConstant.Order.OrderEndPoint)]
        [ProducesResponseType(typeof(UpdateOrderResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdateOrderStatus(int id, UpdateOrderRequest updateOrderRequest)
        {
            var response = await _orderService.UpdateOrderStatus(id, updateOrderRequest);
            return Ok(response);
        }
    }
}
