namespace Ambev.Application.Dtos
{
    public class VendaDTO
    {
        public Guid Id;
        public DateTime Data;
        public Guid ClienteId;
        public decimal ValorTotal;
        public string Filial;
        public List<ItemVendaDTO> Itens;
        public bool Cancelado;
    }
}
