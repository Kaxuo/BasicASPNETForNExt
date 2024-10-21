using Testing.Models.CustomerFiles;
using Testing.Models.OrderFiles;

namespace Testing.Profile
{
    public class AutoMapperProfile : AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Customer, CustomerDTO>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.Orders, opt => opt.MapFrom(src => src.Orders)); // Use OrderSummaryDTO mapping
            CreateMap<Order, OrderSummaryDTO>();
            CreateMap<Order, OrderDTO>()
                .ForMember(dest => dest.Customer, opt => opt.MapFrom(src => new CustomerInfoDTO
            {
                Name = src.Customer.FirstName,
                LastName = src.Customer.LastName,
            })); ;
            // You don't need to do it since you're already mapping eveyrhting above 
            //CreateMap<Customer, CustomerInfoDTO>();
        }
    }
}
