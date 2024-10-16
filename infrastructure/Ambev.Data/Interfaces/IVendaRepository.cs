using Ambev.Domain;

namespace Ambev.Application.Interfaces
{
    public interface IVendaRepository
    {
        void Adicionar(Venda venda);
        Venda ObterPorId(Guid id);
        void Atualizar(Venda venda);
        void Remover(Guid id);

    }
}
