using ControlePagamentoAPI.Application.DTO.DTOs;
using ControlePagamentoAPI.Application.Interfaces;
using ControlePagamentoAPI.Domain.Core.Interfaces.Services;
using ControlePagamentoAPI.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace ControlePagamentoAPI.Application.Services
{
    public class ApplicationServicePagamento : IDisposable, IApplicationServicePagamento
    {
        private readonly IServicePagamento _servicePagamento;
        private readonly IMapperPagamento _mapperPagamento;

        public ApplicationServicePagamento(IServicePagamento servicePagamento, IMapperPagamento mapperPagamento)
        {
            _servicePagamento = servicePagamento;
            _mapperPagamento = mapperPagamento;
        }

        public void Add(PagamentoDTO obj)
        {
            var objPagamento = _mapperPagamento.MapperToEntity(obj);
            _servicePagamento.Add(objPagamento);
        }

        //public IEnumerable<PagamentoDTO> GetAll()
        //{
        //    var objPagamentos = _servicePagamento.GetAll();
        //    return _mapperPagamento.MapperListPagamentos(objPagamentos);
        //}

        public PagamentoDTO GetById(int id)
        {
            var objPagamento = _servicePagamento.GetById(id);
            return _mapperPagamento.MapperToDTO(objPagamento);
        }

        //public void Remove(PagamentoDTO obj)
        //{
        //    var objPagamento = _mapperPagamento.MapperToEntity(obj);
        //    _servicePagamento.Remove(objPagamento);
        //}

        public void Update(PagamentoDTO obj)
        {
            var objPagamento = _mapperPagamento.MapperToEntity(obj);
            _servicePagamento.Update(objPagamento);
        }

        public void Dispose()
        {
            _servicePagamento.Dispose();
        }
    }

}
