
namespace ControlePagamentoAPI.Domain.Models
{
    public class Pagamento : Base
    {
        public int ClienteId { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }

        public void AtualizarStatus(string novoStatus)
        {
            if (Status == "Pago" || Status == "Cancelado")
                throw new InvalidOperationException("Não é possível alterar pagamentos finalizados.");

            if (novoStatus != "Pago" && novoStatus != "Cancelado")
                throw new ArgumentException("Status inválido.");

            Status = novoStatus;
        }
    }
}
