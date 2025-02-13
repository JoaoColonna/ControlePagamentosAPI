using ControlePagamentoAPI.Application.Interfaces;
using ControlePagamentoAPI.Application.DTO.Requests;
using ControlePagamentosAPI.Extensions;
using Microsoft.AspNetCore.Mvc;
using ControlePagamentoAPI.Application.Services;

namespace ControlePagamentosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentosController : ControllerBase
    {
        private readonly IApplicationServicePagamento _applicationServicePagamento;
        private readonly IApplicationServiceCliente _applicationServiceCliente;
        public PagamentosController(
            IApplicationServicePagamento ApplicationServicePagamento, 
            IApplicationServiceCliente ApplicationServiceCliente) 
        {
            _applicationServicePagamento = ApplicationServicePagamento;
            _applicationServiceCliente = ApplicationServiceCliente;
        }

        // POST api/pagamentos
        [HttpPost]
        public ActionResult Post([FromBody] PagamentoRequest pagamentoRequest)
        {
            try
            {
                if (pagamentoRequest is null)
                    return NotFound();

                var pagamentoDTO = pagamentoRequest.ToDTO();

                _applicationServicePagamento.Add(pagamentoDTO);
                return Ok("Pagamento Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET api/pagamentos?clienteId={clienteId}
        [HttpGet]
        public async Task<ActionResult> GetByClienteId([FromQuery] int clienteId)
        {
            try
            {
                if (clienteId == 0)
                    return NotFound();

                var pagamentos = await _applicationServicePagamento.GetByClienteId(clienteId);
                return Ok(pagamentos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut("{id}/status")]
        public ActionResult AtualizarStatus(int id, [FromBody] StatusRequest statusRequest)
        {
            try
            {
                var pagamento = _applicationServicePagamento.GetById(id);
                if (pagamento is null)
                    return NotFound("Pagamento não encontrado.");

                var cliente = _applicationServiceCliente.GetById(pagamento.ClienteId);
                if (cliente is null)
                    return BadRequest("Cliente não encontrado.");

                _applicationServicePagamento.AtualizarStatus(id, statusRequest.Status);
                return Ok("Status do pagamento atualizado com sucesso.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
