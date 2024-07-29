using Microsoft.AspNetCore.Mvc;
using CalculatorApi.Models;
using CalculatorApi.Services;
using CalculatorCalc.Utils.Extensions;

namespace CalculatorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {
        private IActionResult PerformOperation(CalculadoraRequest request, string operation)
        {
            try
            {
                double result = request.Calculate(operation);

                HistoricoService.AddHistoricoEntry(request.Number1, request.Number2, operation, result);

                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("soma")]
        public IActionResult Soma([FromBody] CalculadoraRequest request)
        {
            return PerformOperation(request, "+");
        }

        [HttpPost("subtracao")]
        public IActionResult Subtracao([FromBody] CalculadoraRequest request)
        {
            return PerformOperation(request, "-");
        }

        [HttpPost("multiplicacao")]
        public IActionResult Multiplicacao([FromBody] CalculadoraRequest request)
        {
            return PerformOperation(request, "*");
        }

        [HttpPost("divisao")]
        public IActionResult Divisao([FromBody] CalculadoraRequest request)
        {
            return PerformOperation(request, "/");
        }
        [HttpPost("resto-divisao")]
        public IActionResult RestoDivisao([FromBody] CalculadoraRequest request)
        {
            return PerformOperation(request, "%");
        }

        [HttpGet("historico")]
        public IActionResult GetHistorico()
        {
            var historico = HistoricoService.GetHistorico();
            return Ok(historico);
        }
    }
}