using ControlePagamentoAPI.Application.DTO.DTOs;

namespace ControlePagamentoAPI.Application.Interfaces
{
    public interface IApplicationServicePagamento
    {
        void Add(PagamentoDTO obj);

        PagamentoDTO GetById(int id);

        //IEnumerable<PagamentoDTO> GetAll();

        void Update(PagamentoDTO obj);

        //void Remove(PagamentoDTO obj);

        void Dispose();

    }
}
