using Ambev.Application.Interfaces;
using Ambev.Domain;
using AutoMapper;

namespace Ambev.Application.Services
{
    public class VendaService : IVendaService
    {
        private IVendaService _service;
        private readonly IMapper _mapper;
        public VendaService(IVendaService service, IMapper mapper) 
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task Adicionar(VendaDTO venda)
        {
            throw new NotImplementedException();
        }

        public async Task Atualizar(VendaDTO venda)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<VendaDTO>> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
