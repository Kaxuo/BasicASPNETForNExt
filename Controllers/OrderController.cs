using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Testing.Interface;
using Testing.Models.CustomerFiles;
using Testing.Models.OrderFiles;

namespace Testing.Controllers
{
    [ApiController]
    [Route("orders")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderRepository;
        private readonly IMapper _mapper;

        public OrderController(IOrderService repository, IMapper mapper)
        {
            _orderRepository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Order>>> GetCustomers()
        {
            List<Order> orders = await _orderRepository.GetAllOrders();
            List<OrderDTO> ordersDTO = _mapper.Map<List<OrderDTO>>(orders);
            return Ok(ordersDTO);
        }
    }
}
