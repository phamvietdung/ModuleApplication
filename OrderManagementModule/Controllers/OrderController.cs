using Microsoft.AspNetCore.Mvc;
using OrderManagementModule.Interfaces;

namespace OrderManagementModule.Controllers
{
    [ApiController]
    [Route("order")]
    public class OrderController : ControllerBase
    {

        private readonly ILogger<OrderController> _logger;

        private readonly IOrderServices _orderServices;

        public OrderController(ILogger<OrderController> logger, IOrderServices orderServices)
        {
            _logger = logger;
            _orderServices = orderServices;
        }

        [HttpGet]
        public async Task<Guid> GetOrder()
        {
            return await _orderServices.GetOrderId();
        }
    }
}