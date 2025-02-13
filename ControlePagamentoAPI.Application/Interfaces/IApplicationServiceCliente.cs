using ControlePagamentoAPI.Application.DTO.DTOs;

namespace ControlePagamentoAPI.Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Add(ClienteDTO obj);
        ClienteDTO GetById(int id);
        IEnumerable<ClienteDTO> GetAll();
        void Dispose();
    }
}
