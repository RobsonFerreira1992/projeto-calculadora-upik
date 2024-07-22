using Microsoft.AspNetCore.Mvc;
using CalculatorApi.Models;

namespace CalculatorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {
        [HttpPost]
        public IActionResult Calculate([FromBody] CalculadoraRequest request)
        {
            if (string.IsNullOrEmpty(request.Operation))
            {
                return BadRequest("Operação inválida");
            }

            double result = request.Operation switch
            {
                "+" => request.Number1 + request.Number2,
                "-" => request.Number1 - request.Number2,
                "*" => request.Number1 * request.Number2,
                "/" => request.Number2 != 0 ? request.Number1 / request.Number2 : throw new DivideByZeroException(),
                "%" => request.Number1 % request.Number2,
                _ => throw new InvalidOperationException("Operação inválida")
            };

            return Ok(new { Result = result });
        }
    }
}