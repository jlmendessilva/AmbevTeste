using Ambev.Application.Dtos;
using Ambev.Domain;
using AutoMapper;

namespace Ambev.Application.Mappings
{
    public class DomainMapDto : Profile
    {
        public DomainMapDto()
        {
            CreateMap<Venda, VendaDTO>().ReverseMap();
            CreateMap<ItemVenda, ItemVendaDTO>().ReverseMap();
        }
    }
}
