using ControlePagamentoAPI.Application.DTO.DTOs;
using ControlePagamentoAPI.Application.DTO.Requests;

namespace ControlePagamentosAPI.Extensions
{
    public static class PagamentoExtensions
    {
        public static PagamentoDTO ToDTO(this PagamentoRequest pagamentoRequest)
        {
            if (pagamentoRequest is null)
                return null;

            return new PagamentoDTO
            {
                ClienteId = pagamentoRequest.ClienteId,
                Valor = pagamentoRequest.Valor,
                Data = pagamentoRequest.Data
            };
        }
    }
}
