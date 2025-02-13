namespace ControlePagamentoAPI.Application.DTO.Requests
{
    public class PagamentoRequest
    {
        public int ClienteId { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
    }
}

