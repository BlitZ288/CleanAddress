using AutoMapper;
using CleanAddress.Dadata.Client.Dto;
using CleanAddress.Model;

namespace CleanAddress.Mappings
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<CleanAddressDto, Address>()
                .ForMember(dest => dest.CleanAddress, opts => opts.MapFrom(src => src.Result))
                .ForMember(dest => dest.Country, opts => opts.MapFrom(src => src.Country))
                .ForMember(dest => dest.PostalCode, opts => opts.MapFrom(src => src.Postal_code));
        }
    }
}
