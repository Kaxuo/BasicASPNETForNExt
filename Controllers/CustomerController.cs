using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Testing.Interface;
using Testing.Models.CustomerFiles;

namespace Testing.Controllers
{
    [ApiController]
    [Route("customers")]
    public class CustomerController : ControllerBase
    {

        private readonly ILogger<CustomerController> _logger;
        private readonly ICustomerService _customersRepository;
        private readonly IMapper _mapper;

        public CustomerController(ILogger<CustomerController> logger, ICustomerService repository, IMapper mapper)
        {
            _logger = logger;
            _customersRepository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetCustomers()
        {
            List<Customer> customers = await _customersRepository.GetAllCustomers();
            List<CustomerDTO> customersDTO = _mapper.Map<List<CustomerDTO>>(customers);
            return Ok(customersDTO);
        }
    }
}