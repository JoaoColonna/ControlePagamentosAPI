using ControlePagamentoAPI.Application.DTO.DTOs;
using ControlePagamentoAPI.Application.DTO.Requests;

namespace ControlePagamentosAPI.Extensions
{
    public static class ClienteExtensions
    {
        public static ClienteDTO ToDTO(this ClienteRequest clienteRequest)
        {
            if (clienteRequest is null)
                return null;

            return new ClienteDTO
            {
                Nome = clienteRequest.Nome,
                Email = clienteRequest.Email
            };
        }
    }
}
