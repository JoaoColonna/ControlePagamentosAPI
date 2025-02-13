using ControlePagamentoAPI.Application.DTO.DTOs;
using ControlePagamentoAPI.Domain.Models;

namespace ControlePagamentoAPI.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperCliente
    {
        #region Mappers

        Cliente MapperToEntity(ClienteDTO clienteDTO);
        IEnumerable<ClienteDTO> MapperListClientes(IEnumerable<Cliente> clientes);
        ClienteDTO MapperToDTO(Cliente Cliente);

        #endregion

    }
}
