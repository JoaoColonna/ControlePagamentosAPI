using ControlePagamentoAPI.Application.DTO.DTOs;
using ControlePagamentoAPI.Application.Interfaces;
using ControlePagamentoAPI.Domain.Core.Interfaces.Services;
using ControlePagamentoAPI.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace ControlePagamentoAPI.Application.Services
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente _serviceCliente;
        private readonly IMapperCliente _mapperCliente;

        public ApplicationServiceCliente(IServiceCliente ServiceCliente
                                                 , IMapperCliente MapperCliente)

        {
            _serviceCliente = ServiceCliente;
            _mapperCliente = MapperCliente;
        }


        public void Add(ClienteDTO obj)
        {
            var objCliente = _mapperCliente.MapperToEntity(obj);
            _serviceCliente.Add(objCliente);
        }

        public void Dispose()
        {
            _serviceCliente.Dispose();
        }

        public IEnumerable<ClienteDTO> GetAll()
        {
            var objPagamentos = _serviceCliente.GetAll();
            return _mapperCliente.MapperListClientes(objPagamentos);
        }

        public ClienteDTO GetById(int id)
        {
            var objcliente = _serviceCliente.GetById(id);
            return _mapperCliente.MapperToDTO(objcliente);
        }

        //public void Remove(ClienteDTO obj)
        //{
        //    var objCliente = _mapperCliente.MapperToEntity(obj);
        //    _serviceCliente.Remove(objCliente);
        //}

        //public void Update(ClienteDTO obj)
        //{
        //    var objCliente = _mapperCliente.MapperToEntity(obj);
        //    _serviceCliente.Update(objCliente);
        //}
    }
}
