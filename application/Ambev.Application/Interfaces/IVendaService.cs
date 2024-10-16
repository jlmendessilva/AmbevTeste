using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.Application.Interfaces
{
    public interface IVendaService
    {
        Task Adicionar(VendaDTO venda);
        Task<IEnumerable<VendaDTO>> ObterPorId(Guid id);
        Task Atualizar(VendaDTO venda);
        Task Remover(Guid id);
    }
}
