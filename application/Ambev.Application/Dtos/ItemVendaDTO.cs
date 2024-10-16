namespace Ambev.Application.Dtos
{
    public class ItemVendaDTO
    {
        public Guid Id;
        public Guid ProdutoId;
        public int Quantidade;
        public decimal ValorUnitario;
        public decimal Desconto;
        public decimal ValorTotal;
    }
}
