using ControlePagamentoAPI.Application.DTO.DTOs;
using ControlePagamentoAPI.Domain.Models;
using ControlePagamentoAPI.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace ControlePagamentoAPI.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperPagamento : IMapperPagamento
    {
        #region Properties

        List<PagamentoDTO> pagamentoDTOs = new List<PagamentoDTO>();

        #endregion

        #region Methods

        public Pagamento MapperToEntity(PagamentoDTO pagamentoDTO)
        {
            Pagamento pagamento = new Pagamento
            {
                Id = pagamentoDTO.Id,
                ClienteId = pagamentoDTO.ClienteId,
                Valor = pagamentoDTO.Valor,
                Data = pagamentoDTO.Data,
                Status = pagamentoDTO.Status
            };

            return pagamento;
        }

        public IEnumerable<PagamentoDTO> MapperListPagamentos(IEnumerable<Pagamento> pagamentos)
        {
            foreach (var item in pagamentos)
            {
                PagamentoDTO pagamentoDTO = new PagamentoDTO
                {
                    Id = item.Id,
                    ClienteId = item.ClienteId,
                    Valor = item.Valor,
                    Data = item.Data,
                    Status = item.Status
                };

                pagamentoDTOs.Add(pagamentoDTO);
            }

            return pagamentoDTOs;
        }

        public PagamentoDTO MapperToDTO(Pagamento pagamento)
        {
            if(pagamento is null)
                return null;

            PagamentoDTO pagamentoDTO = new PagamentoDTO
            {
                Id = pagamento.Id,
                ClienteId = pagamento.ClienteId,
                Valor = pagamento.Valor,
                Data = pagamento.Data,
                Status = pagamento.Status
            };

            return pagamentoDTO;
        }

        #endregion
    }

}
